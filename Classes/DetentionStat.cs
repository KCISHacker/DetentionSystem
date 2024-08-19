using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DetentionSystem.Classes;
public class DetentionStat
{
    public readonly string Owner;
    public readonly int Total;
    public readonly int Done;
    public readonly int Undone;
    public readonly int Overdue;
    public readonly int OverdueIntoWarning;
    public readonly Dictionary<int, int> DetentionInWeeks;
    public readonly int AveragePerWeek;
    public readonly int EstimateInEndOfSemester;
    public readonly int MostWeek;
    public readonly int LeastWeek;

    public DetentionStat(string owner, Detention[] detentions)
    {
        Owner = owner;

        Total = detentions.Sum(d => d.DetentionTimes ?? 0);
        Done = detentions.Sum(d => d.DoTimes ?? 0);
        Undone = Total - Done;

        DetentionInWeeks = [];
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
        }

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

    private bool IsSameWeek(DateTime date1, DateTime date2)
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
    public int GetWeekOfSemester(DateTime date)
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
            (Owner == "" ? "All detentions;\n" : $"Query for: {Owner};\n") +
            $"Total: {Total};\n" +
            $"Done: {Done};\n" +
            $"Not done: {Undone};\n" +
            $"Overdue: {Overdue};\n" +
            $"Overdue into warning: {OverdueIntoWarning};\n" +
            $"Average per week: {AveragePerWeek};\n" +
            $"Estimate in end of semester: {EstimateInEndOfSemester};\n" +
            $"Most in a week: {MostWeek};\n" +
            $"Least in a week: {LeastWeek};";
    }
}
