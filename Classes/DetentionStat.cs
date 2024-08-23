using System.Data;
using System.Globalization;

namespace DetentionSystem.Classes;
public class DetentionStat
{
    public readonly string Account;
    public readonly int Total;
    public readonly int Done;
    public readonly int Undone;
    public readonly int Overdue;
    public readonly int OverdueIntoWarning;
    public readonly Dictionary<int, int> DetentionInWeeks;
    public readonly Dictionary<string, int> AccountsWithDetentions;
    public readonly Dictionary<string, int> HomeroomsWithDetentions;
    public readonly Dictionary<string, int> DetentionsFromDepartments;
    public readonly Dictionary<int, int> TotalTimes;
    public readonly Dictionary<string, int> TypeOfDetentions;
    public readonly int AveragePerWeek;
    public readonly int EstimateInEndOfSemester;
    public readonly int MostWeek;
    public readonly int LeastWeek;

    public DetentionStat(string owner, Detention[] detentions)
    {
        Account = owner;

        Total = detentions.Sum(d => d.DetentionTimes ?? 0);
        Done = detentions.Sum(d => d.DoTimes ?? 0);
        Undone = Total - Done;

        DetentionInWeeks = [];
        TotalTimes = [];
        TypeOfDetentions = [];
        DetentionsFromDepartments = [];
        HomeroomsWithDetentions = [];
        AccountsWithDetentions = [];
        foreach (var detention in detentions)
        {
            if (detention.DetentionDate != null)
            {
                var week = GetWeekOfSemester(detention.DetentionDate.Value);
                DetentionInWeeks[week] = DetentionInWeeks.GetValueOrDefault(week) + 1;

                // Check if current time is in the same week as the detention
                if (!IsSameWeek(detention.DetentionDate.Value, DateTime.Now)) // This makes more accurancy
                {
                    Overdue += detention.DetentionTimes ?? 0;
                }
            }
            if (detention.AccountID != null)
            {
                var account = detention.AccountID.Trim();

                AccountsWithDetentions[account] = AccountsWithDetentions.GetValueOrDefault(account) + (detention.DetentionTimes ?? 1);
            }
            if (detention.Homeroom != null)
            {
                var homeroom = detention.Homeroom.Trim();

                HomeroomsWithDetentions[homeroom] = HomeroomsWithDetentions.GetValueOrDefault(homeroom) + (detention.DetentionTimes ?? 1);
            }
            if (detention.UploadDept != null)
            {
                var uploadDept = detention.UploadDept.Trim();

                DetentionsFromDepartments[uploadDept] = DetentionsFromDepartments.GetValueOrDefault(uploadDept) + (detention.DetentionTimes ?? 1);
            }
            if (detention.DetentionTimes != null)
            {
                var detentionTimes = detention.DetentionTimes.Value;

                TotalTimes[detentionTimes] = TotalTimes.GetValueOrDefault(detentionTimes) + 1;
            }
            if (detention.DetentionType != null)
            {
                var type = detention.DetentionType.Trim();
                type = type == "" ? "[EMPTY]" : type;

                TypeOfDetentions[type] = TypeOfDetentions.GetValueOrDefault(type) + (detention.DetentionTimes ?? 1);
            }
        }

        // Sort lists
        AccountsWithDetentions = AccountsWithDetentions.OrderByDescending(kv => kv.Key).ToDictionary(kv => kv.Key, kv => kv.Value);
        HomeroomsWithDetentions = HomeroomsWithDetentions.OrderByDescending(kv => kv.Key).ToDictionary(kv => kv.Key, kv => kv.Value);
        /*DetentionsFromDepartments = DetentionsFromDepartments.OrderByDescending(kv => kv.Key).ToDictionary(kv => kv.Key, kv => kv.Value);
        TypeOfDetentions = TypeOfDetentions.OrderByDescending(kv => kv.Key).ToDictionary(kv => kv.Key, kv => kv.Value);*/

        OverdueIntoWarning = Overdue / 7;

        MostWeek = int.MinValue;
        LeastWeek = int.MaxValue;
        var sum = 0;
        foreach (var dtInWeeksPair in DetentionInWeeks)
        {
            if (dtInWeeksPair.Value > MostWeek)
            {
                MostWeek = dtInWeeksPair.Value;
            }
            if (dtInWeeksPair.Value < LeastWeek)
            {
                LeastWeek = dtInWeeksPair.Value;
            }
            sum += dtInWeeksPair.Value;
        }
        AveragePerWeek = sum / DetentionInWeeks.Count;

        EstimateInEndOfSemester = AveragePerWeek * 20;
    }

    private static bool IsSameWeek(DateTime date1, DateTime date2)
    {
        var calendar = CultureInfo.CurrentCulture.Calendar;
        var d1Week = calendar.GetWeekOfYear(date1, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        var d2Week = calendar.GetWeekOfYear(date2, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        return d1Week == d2Week && date1.Year == date2.Year;
    }

    /// <summary>
    ///  This is a estimate of what week is the date given in the semester.
    ///  This may be not accurate.
    /// </summary>
    /// <param name="date">Given date</param>
    /// <returns></returns>
    public static int GetWeekOfSemester(DateTime date)
    {
        // if date is greater than September, or smaller than Febulary
        if (date.Month > 9 || date.Month < 2) // 1st semester
        {
            // Get the first Moday of September
            var septemberFirst = new DateTime(date.Year, 9, 1);
            var daysUntilMonday = ((int)DayOfWeek.Monday - (int)septemberFirst.DayOfWeek + 7) % 7;
            var firstMondayOfSeptember = septemberFirst.AddDays(daysUntilMonday);
            return (date - firstMondayOfSeptember).Days / 7 + 1;
        }
        if (date.Month >= 2 && date.Month <= 8) // 2nd seemester
        {
            // cannot decide first day of semester, let the first day of semester to be 2/15 instead
            var feb15 = new DateTime(date.Year, 2, 15);
            return (date - feb15).Days / 7 + 1;
        }
        return -1;
    }

    public string GetStatisticString()
    {
        return
            (Account == "" ? "Query for: all detentions;\n" : $"Query for: {Account};\n") +
            $"Total: {Total};\n" +
            $"Done: {Done};\n" +
            $"Not done: {Undone};\n" +
            $"Overdue: {Overdue};\n" +
            $"Overdue into warning: {OverdueIntoWarning};\n" +
            $"Average per week: {AveragePerWeek};\n" +
            $"Estimate in end of semester: {EstimateInEndOfSemester};\n" +
            $"Most in a week: {MostWeek};\n" +
            $"Least in a week: {LeastWeek};\n" +
            $"Most account receiving detentions: {KeyValuePairToString(AccountsWithDetentions.OrderByDescending(kv => kv.Value).FirstOrDefault())};\n" +
            $"Most homeroom receiving detentions: {KeyValuePairToString(HomeroomsWithDetentions.OrderByDescending(kv => kv.Value).FirstOrDefault())};\n" +
            $"Most department sending detentions: {KeyValuePairToString(DetentionsFromDepartments.OrderByDescending(kv => kv.Value).FirstOrDefault())};\n" +
            $"Least department sending detentions: {KeyValuePairToString(DetentionsFromDepartments.OrderBy(kv => kv.Value).FirstOrDefault())};\n" +
            $"Detentions with most times: {KeyValuePairToString(TotalTimes.OrderByDescending(kv => kv.Key).FirstOrDefault())};\n" +
            $"Most sent detention type: {KeyValuePairToString(TypeOfDetentions.OrderByDescending(kv => kv.Value).FirstOrDefault())};";
    }

    private static string KeyValuePairToString<T, T2>(KeyValuePair<T, T2> keyValuePair)
    {
        return $"{keyValuePair.Key}: {keyValuePair.Value}";
    }
}
