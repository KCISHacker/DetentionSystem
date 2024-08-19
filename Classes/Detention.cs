using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace DetentionSystem.Classes;

public class Detention : IEquatable<Detention?>
{
    public static Detention[] LoadDetentionsFromJson(string json)
    {
        List<Detention> detentions = [];

        // Deserialize the JSON string into a JsonDocument
        var jsonDocument = JsonDocument.Parse(json);

        // Get the root element of the JSON document
        var root = jsonDocument.RootElement;

        // Iterate over each JSON object in the root element
        foreach (var detentionElement in root.EnumerateArray())
        {
            // Extract the values from the JSON object

            // Who tf named those???
            // Need improvement in english naming...
            var detentionID = detentionElement.GetProperty("DetentionID").GetString();
            var accountID = detentionElement.GetProperty("AccountID").GetString();
            var cname = detentionElement.GetProperty("Cname").GetString();
            var ename = detentionElement.GetProperty("Ename").GetString();
            var homeroom = detentionElement.GetProperty("Homeroom").GetString();
            var dtDate = detentionElement.GetProperty("DetentionDate").GetString() ?? "";
            DateTime? detentionDate = DateTime.ParseExact(dtDate, "yyyy-MM-dd", null);
            var detentionType = detentionElement.GetProperty("DetentionType").GetString();
            var detentionContent = detentionElement.GetProperty("DetentionContent").GetString();
            int.TryParse(detentionElement.GetProperty("DetentionTimes").GetString(), out var detentionTimes);
            var doTimes = detentionElement.GetProperty("DoTimes").GetInt32();
            var undoTimes = detentionElement.GetProperty("UndoTimes").GetInt32();
            var uploadDept = detentionElement.GetProperty("UploadDept").GetString();
            var status = detentionElement.GetProperty("Status").GetString();
            var batchNo = detentionElement.GetProperty("BatchNo").GetString();
            var batchRemark = detentionElement.GetProperty("BatchRemark").GetString();
            var uploader = detentionElement.GetProperty("Uploader").GetString();
            var upTime = detentionElement.GetProperty("CreateTime").GetString() ?? "";
            DateTime? createTime = DateTime.Parse(upTime);
            var iP = detentionElement.GetProperty("IP").GetString();

            // Create a new Detention object with the extracted values
            var detention = new Detention(detentionID, accountID, cname, ename, homeroom, detentionDate, detentionType, detentionContent, detentionTimes, doTimes, undoTimes, uploadDept, status, batchNo, batchRemark, uploader, createTime, iP);

            // Add the Detention object to the list
            detentions.Add(detention);
        }

        // Convert the list to an array and return it
        return [.. detentions];
    }

    public static string DetentionsToJson(Detention[] detentions)
    {
        // Create a new JSON array
        var root = new JsonArray();

        // Iterate over each Detention object in the array
        foreach (var detention in detentions)
        {
            // Create a new JSON object
            var detentionElement = new JsonObject
            {
                ["DetentionID"] = detention.DetentionID,
                ["AccountID"] = detention.AccountID,
                ["Cname"] = detention.Cname,
                ["Ename"] = detention.Ename,
                ["Homeroom"] = detention.Homeroom,
                ["DetentionDate"] = detention.DetentionDate?.ToString("yyyy-MM-dd"),
                ["DetentionType"] = detention.DetentionType,
                ["DetentionContent"] = detention.DetentionContent,
                ["DetentionTimes"] = detention.DetentionTimes.ToString(),
                ["DoTimes"] = detention.DoTimes,
                ["UndoTimes"] = detention.UndoTimes,
                ["UploadDept"] = detention.UploadDept,
                ["Status"] = detention.Status,
                ["BatchNo"] = detention.BatchNo,
                ["BatchRemark"] = detention.BatchRemark,
                ["Uploader"] = detention.Uploader,
                ["CreateTime"] = detention.CreateTime?.ToString("yyyy-MM-ddTHH:mm:ss.fff"),
                ["IP"] = detention.IP
            };

            // Add the JSON object to the JSON array
            root.Add(detentionElement);
        }

        // Serialize the JSON array to a string and return it
        return root.ToString();
    }

    public Detention()
    {
    }

    public Detention(string detentionID)
    {
        DetentionID = detentionID;
    }

    public Detention(string? detentionID, string? accountID, string? cname, string? ename, string? homeroom, DateTime? detentionDate, string? detentionType, string? detentionContent, int? detentionTimes, int? doTimes, int? undoTimes, string? uploadDept, string? status, string? batchNo, string? batchRemark, string? uploader, DateTime? createTime, string? iP)
    {
        DetentionID = detentionID;
        AccountID = accountID;
        Cname = cname;
        Ename = ename;
        Homeroom = homeroom;
        DetentionDate = detentionDate;
        DetentionType = detentionType;
        DetentionContent = detentionContent;
        DetentionTimes = detentionTimes;
        DoTimes = doTimes;
        UndoTimes = undoTimes;
        UploadDept = uploadDept;
        Status = status;
        BatchNo = batchNo;
        BatchRemark = batchRemark;
        Uploader = uploader;
        CreateTime = createTime;
        IP = iP;
    }

    public string? DetentionID
    {
        get; set;
    }
    public string? AccountID
    {
        get; set;
    }
    public string? Cname
    {
        get; set;
    }
    public string? Ename
    {
        get; set;
    }
    public string? Homeroom
    {
        get; set;
    }
    public DateTime? DetentionDate
    {
        get; set;
    }
    public string? DetentionType
    {
        get; set;
    }
    public string? DetentionContent
    {
        get; set;
    }
    public int? DetentionTimes
    {
        get; set;
    }
    public int? DoTimes
    {
        get; set;
    }
    public int? UndoTimes
    {
        get; set;
    }
    public string? UploadDept
    {
        get; set;
    }
    public string? Status
    {
        get; set;
    }
    public string? BatchNo
    {
        get; set;
    }
    public string? BatchRemark
    {
        get; set;
    }
    public string? Uploader
    {
        get; set;
    }
    public DateTime? CreateTime
    {
        get; set;
    }
    public string? IP
    {
        get; set;
    }

    public static explicit operator Detention(string input)
    {
        return new Detention(input);
    }

    public override string ToString()
    {
        return DetentionID ?? "";
    }

    public override bool Equals(object? obj) => Equals(obj as Detention);
    public bool Equals(Detention? other) => other is not null && DetentionID == other.DetentionID && AccountID == other.AccountID && Cname == other.Cname && Ename == other.Ename && Homeroom == other.Homeroom && DetentionDate == other.DetentionDate && DetentionType == other.DetentionType && DetentionContent == other.DetentionContent && DetentionTimes == other.DetentionTimes && DoTimes == other.DoTimes && UndoTimes == other.UndoTimes && UploadDept == other.UploadDept && Status == other.Status && BatchNo == other.BatchNo && BatchRemark == other.BatchRemark && Uploader == other.Uploader && CreateTime == other.CreateTime && IP == other.IP;

    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(DetentionID);
        hash.Add(AccountID);
        hash.Add(Cname);
        hash.Add(Ename);
        hash.Add(Homeroom);
        hash.Add(DetentionDate);
        hash.Add(DetentionType);
        hash.Add(DetentionContent);
        hash.Add(DetentionTimes);
        hash.Add(DoTimes);
        hash.Add(UndoTimes);
        hash.Add(UploadDept);
        hash.Add(Status);
        hash.Add(BatchNo);
        hash.Add(BatchRemark);
        hash.Add(Uploader);
        hash.Add(CreateTime);
        hash.Add(IP);
        return hash.ToHashCode();
    }

    public static bool operator ==(Detention left, Detention right)
    {
        return EqualityComparer<Detention>.Default.Equals(left, right);
    }

    public static bool operator !=(Detention left, Detention right)
    {
        return !(left == right);
    }
}
