using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static DetentionSystem.Classes.DetentionAPI;

namespace DetentionSystem.Classes;

public static class DetentionAPI
{
    // This class is used to store the filter values by regex
    public struct Filter
    {
        public string? Homeroom
        {
            get; set;
        }
        // Those two are not using regex becus they specific a date range
        public string? StartingDate // Format yyyyMMdd
        {
            get; set;
        }
        public string? EndingDate // Format yyyyMMdd
        {
            get; set;
        }
        // End
        public string? Type
        {
            get; set;
        }
        public string? BatchRemark
        {
            get; set;
        }
        public string? UploadDept
        {
            get; set;
        }
        public string? TotalTimes
        {
            get; set;
        }
        public string? DoneTimes
        {
            get; set;
        }
        public string? UndoneTimes
        {
            get; set;
        }
    }

    public static Detention[] GetDetentions(string[] ids, Filter filters, Action<int> setOverallProgressMax, Action addOverallProgress, Action<int> setCurrentProgressMax, Action addCurrentProgress)
    {
        List<Detention> dts = [];
        setOverallProgressMax.Invoke(ids.Length);
        var startingDate = filters.StartingDate ?? "";
        var endingDate = filters.EndingDate ?? "";
        var global_args = $"&strKeyWord1={startingDate}&strKeyWord2={endingDate}&strBatchRemark=&strDetentionType=";
        foreach (var id in ids)
        {
            if (!Program.KCISAPI.GetAPI($"/DSAI/Detention/Detention_List?strKeyWord0={id}" + global_args, out var json))
            {
                MessageBox.Show($"Internet error occurred when getting {id}, cannot get data!\nCheck your internet connection and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return [];
            }
            // Not gonna use the shitty api that does not support regex to filter, we hv our own
            dts.AddRange(LoadDetentionsFromJson(json, filters, setCurrentProgressMax, addCurrentProgress));
            addOverallProgress();
        }
        return [.. dts];
    }

    public static Detention[] LoadDetentionsFromJson(string json, Filter filters, Action<int> setCurrentProgressMax, Action addCurrentProgress)
    {
        List<Detention> dts = [];
        var detentions = Detention.JsonToDetentions(json);
        setCurrentProgressMax.Invoke(detentions.Length);
        foreach (var dt in detentions)
        {
            addCurrentProgress.Invoke();
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
