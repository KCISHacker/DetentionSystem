using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace DetentionSystem.Classes;

public static class DetentionAPI
{
    // This class is used to store the filter values by regex
    public struct Filter
    {
        [DisplayName("Hoomroom"), Category("Account")]
        [Description("Hoomroom of who the detentions were sent to. " +
            "For example: '9A' ; '708'.")]
        public string? Homeroom
        {
            get; set;
        }
        // Those two are not using regex becus they specific a date range
        [DisplayName("Starting Date"), Category("Date && Time")]
        [Description("The startin date of a range of time that detentions were sent. " +
            "This is a date or time, use date&time format like 'Feb 20 2024' or '2/20/2024'." +
            "This is not in regular expression.")]
        public DateTime? StartingDate
        {
            get; set;
        }
        [DisplayName("Ending Date"), Category("Date && Time")]
        [Description("The ending date of a range of time that detentions were sent. " +
            "This is a date or time, use date&time format like 'Feb 20 2024' or '2/20/2024'." +
            "This is not in regular expression.")]
        public DateTime? EndingDate
        {
            get; set;
        }
        // End
        [DisplayName("Type"), Category("Detention")]
        [Description("Type of detentions. " +
            "For example: '课堂表现违规' ; '在校言语违规'")]
        public string? Type
        {
            get; set;
        }
        [DisplayName("Week Mark"), Category("Date & Time")]
        [Description("Week mark of the detentions. " +
            "For example: 'week18' ; 'week19需服务'. " +
            "Warning: Combined week mark may appear: week8和week9")]
        public string? BatchRemark
        {
            get; set;
        }
        [DisplayName("Upload Department"), Category("Account")]
        [Description("Department that sent the detentions. " +
            "For example: '德育组' ; '班主任'.")]
        public string? UploadDept
        {
            get; set;
        }
        [DisplayName("Total Times"), Category("Detention")]
        [Description("How many detentions were sent in this sinle datum. " +
            "This is an integer.")]
        public string? TotalTimes
        {
            get; set;
        }
        [DisplayName("Done Times"), Category("Detention")]
        [Description("How many detentions were done in this sinle datum. " +
            "This is an integer.")]
        public string? DoneTimes
        {
            get; set;
        }
        [DisplayName("Not Done Times"), Category("Detention")]
        [Description("How many detentions were not done in this sinle datum. " +
            "This is an integer.")]
        public string? UndoneTimes
        {
            get; set;
        }
    }

    public static Detention[] GetDetentions(string[] ids, Filter filters, Action<int> setOverallProgressMax, Action<int> setOverallProgress, Action<int> setCurrentProgressMax, Action<int> setCurrentProgress)
    {
        List<Detention> dts = [];
        setOverallProgressMax.Invoke(ids.Length);
        var overallProgress = 0;
        var startingDate = filters.StartingDate?.ToString("yyyyMMdd") ?? "";
        var endingDate = filters.EndingDate?.ToString("yyyyMMdd") ?? "";
        var global_args = $"&strKeyWord1={startingDate}&strKeyWord2={endingDate}&strBatchRemark=&strDetentionType=";
        foreach (var id in ids)
        {
            if (!Program.KCISAPI.GetAPI($"/DSAI/Detention/Detention_List?strKeyWord0={id}" + global_args, out var json))
            {
                MessageBox.Show($"Internet error occurred when getting {id}, cannot get data!\nCheck your internet connection and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return [];
            }
            // Not gonna use the shitty api that does not support regex to filter, we hv our own
            dts.AddRange(LoadDetentionsFromJson(json, filters, setCurrentProgressMax, setCurrentProgress));
            overallProgress++;
            // Make setOverallProgress occurs every 10 queries
            if (overallProgress % 10 == 0)
                setOverallProgress.Invoke(overallProgress);
        }
        return [.. dts];
    }

    public static bool DeleteDetention(string detentioID)
    {
        if (!Program.KCISAPI.GetAPI($"/DSAI/Detention/Detention_Del?strCID={detentioID}", out var result))
        {
            MessageBox.Show($"Internet error occurred when getting {detentioID}, cannot get data!\nCheck your internet connection and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (result == "删除成功") // idk what but whatever u delete even it doesnt exist in the first place it always return this
        {
            return true;
        }
        MessageBox.Show($"Detention {detentioID} has not been deleted successfully!\nAPI returned: {result}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
    }

    public static bool UpdateDetention(Detention detention)
    {
        Dictionary<string, string> formData = new Dictionary<string, string>()
        {
            { "inp_PageMode", "Edit" },
            { "inp_SaveRemark", "" },
            { "inp_CID", detention.DetentionID ?? "" },
            { "inp_DetentionDate", detention.DetentionDate?.ToString("yyyy-MM-dd") ?? "" },
            { "inp_DetentionContent", detention.DetentionContent ?? "" },
            { "inp_DetentionTimes", detention.DetentionTimes?.ToString() ?? "" },
            { "inp_DoTimes", detention.DoTimes?.ToString() ?? "" },
            { "inp_UploadDept", detention.UploadDept ?? "" }
        };
        if (!Program.KCISAPI.PostAPI($"/DSAI/Detention/Detention_Save", formData, out var result))
        {
            MessageBox.Show($"Internet error occurred when getting {detention.DetentionID}, cannot get data!\nCheck your internet connection and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        if (result == "储存成功") return true;
        MessageBox.Show($"Detention {detention.DetentionID ?? ""} has not been edited successfully!\nAPI returned: {result}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
    }

        public static Detention[] LoadDetentionsFromJson(string json, Filter filters, Action<int> setCurrentProgressMax, Action<int> setCurrentProgress)
    {
        List<Detention> dts = [];
        var detentions = Detention.JsonToDetentions(json);
        setCurrentProgressMax.Invoke(detentions.Length);
        var currentProgress = 0;
        foreach (var dt in detentions)
        {
            currentProgress++;
            if (currentProgress % 20 == 0)
                setCurrentProgress.Invoke(currentProgress);
            if (FilterOrNot(dt.Homeroom, filters.Homeroom))
                continue;
            if (FilterOrNot(dt.DetentionType, filters.Type))
                continue;
            if (FilterOrNot(dt.BatchRemark, filters.BatchRemark))
                continue;
            if (FilterOrNot(dt.UploadDept, filters.UploadDept))
                continue;
            if (FilterOrNot(dt.DetentionTimes?.ToString(), filters.TotalTimes))
                continue;
            if (FilterOrNot(dt.DoTimes?.ToString(), filters.DoneTimes))
                continue;
            if (FilterOrNot(dt.UndoTimes?.ToString(), filters.UndoneTimes))
                continue;
            dts.Add(dt);
        }
        return [.. dts];
    }

    private static bool FilterOrNot(string? value, string? filter)
    {
        if (filter == null || filter.Trim() == "")
            return false;
        if (value == null) return true;
        return !Regex.IsMatch(value, filter);
    }
}
