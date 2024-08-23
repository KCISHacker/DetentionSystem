using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace DetentionSystem.Classes;

public class Detention : IEquatable<Detention?>
{
    public static Detention[] JsonToDetentions(string json)
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
            detentionElement.GetProperty("UndoTimes").GetInt32();
            var uploadDept = detentionElement.GetProperty("UploadDept").GetString();
            var status = detentionElement.GetProperty("Status").GetString();
            var batchNo = detentionElement.GetProperty("BatchNo").GetString();
            var batchRemark = detentionElement.GetProperty("BatchRemark").GetString();
            var uploader = detentionElement.GetProperty("Uploader").GetString();
            var upTime = detentionElement.GetProperty("CreateTime").GetString() ?? "";
            DateTime? createTime = DateTime.Parse(upTime);
            var iP = detentionElement.GetProperty("IP").GetString();

            // Create a new Detention object with the extracted values
            var detention = new Detention(detentionID, accountID, cname, ename, homeroom, detentionDate, detentionType, detentionContent, detentionTimes, doTimes, uploadDept, status, batchNo, batchRemark, uploader, createTime, iP);

            // Add the Detention object to the list
            detentions.Add(detention);
        }

        // Convert the list to an array and return it
        return [.. detentions];
    }

    public static JsonObject DetentionToJsonObject(Detention detention)
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

        return detentionElement;
    }

    public static string DetentionToJson(Detention detention)
    {
        return DetentionToJsonObject(detention).ToString();
    }

    public static string DetentionsToJson(Detention[] detentions)
    {
        // Create a new JSON array
        var root = new JsonArray();

        // Iterate over each Detention object in the array
        foreach (var detention in detentions)
        {
            // Add the JSON object to the JSON array
            root.Add(DetentionToJsonObject(detention));
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

    public Detention(string? detentionID, string? accountID, string? cname, string? ename, string? homeroom, DateTime? detentionDate, string? detentionType, string? detentionContent, int? detentionTimes, int? doTimes, string? uploadDept, string? status, string? batchNo, string? batchRemark, string? uploader, DateTime? createTime, string? iP)
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
        UploadDept = uploadDept;
        Status = status;
        BatchNo = batchNo;
        BatchRemark = batchRemark;
        Uploader = uploader;
        CreateTime = createTime;
        IP = iP;
    }

    [ReadOnly(true), Category("Detention")]
    [DisplayName("Detention ID")]
    public string? DetentionID
    {
        get; set;
    }
    [ReadOnly(true), Category("Account")]
    [DisplayName("Account")]
    public string? AccountID
    {
        get; set;
    }
    [ReadOnly(true), Category("Account")]
    [DisplayName("Chinese Name")]
    [Description("Chinese name of the account sent")]
    public string? Cname
    {
        get; set;
    }
    [ReadOnly(true), Category("Account")]
    [DisplayName("English Name")]
    [Description("English name of the account sent")]
    public string? Ename
    {
        get; set;
    }
    [ReadOnly(true), Category("Account")]
    [DisplayName("Homeroom")]
    [Description("Homeroom of the account sent")]
    public string? Homeroom
    {
        get; set;
    }
    [Category("Date & Time")]
    [DisplayName("Date Sent")]
    [Description("Time when the detentions were determined to be sent, different from 'Date Registered'")]
    public DateTime? DetentionDate
    {
        get; set;
    }
    [ReadOnly(true)]
    [Category("Detention")]
    [DisplayName("Type")]
    public string? DetentionType
    {
        get; set;
    }
    [Category("Detention")]
    [DisplayName("Content")]
    public string? DetentionContent
    {
        get; set;
    }
    [Category("Detention")]
    [DisplayName("Times")]
    public int? DetentionTimes
    {
        get; set;
    }
    [Category("Detention")]
    [DisplayName("Done Times")]
    public int? DoTimes
    {
        get; set;
    }
    [ReadOnly(true)]
    [Category("Detention")]
    [DisplayName("Not Done Times")]
    public int? UndoTimes
    {
        get => DetentionTimes - DoTimes;

        set => throw new NotImplementedException();
    }
    [Category("Account")]
    [DisplayName("Upload Department")]
    public string? UploadDept
    {
        get; set;
    }
    [ReadOnly(true)]
    [Description("Unkown property (may be a legacy property), seems to be the activation of the detentions")]
    public string? Status
    {
        get; set;
    }
    [ReadOnly(true)]
    [Description("A number of week the detentions were sent, aka the id of the batch that the detentions were proceed")]
    public string? BatchNo
    {
        get; set;
    }
    [ReadOnly(true)]
    [Category("Date & Time")]
    [DisplayName("Week Mark")]
    [Description("aka batch remark")]
    public string? BatchRemark
    {
        get; set;
    }
    [ReadOnly(true)]
    [Category("Account")]
    [DisplayName("Uploader")]
    public string? Uploader
    {
        get; set;
    }
    [ReadOnly(true)]
    [Category("Date & Time")]
    [DisplayName("Time Uploaded")]
    [Description("Time when the detentions were registered, different from 'Date Sent'")]
    public DateTime? CreateTime
    {
        get; set;
    }
    [ReadOnly(true)]
    [Category("Account")]
    [DisplayName("Uploader IP")]
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
        return $"Detentiion ID: {DetentionID}" +
            $"\nAccount: {AccountID}" +
            $"\nChinese Name: {Cname}" +
            $"\nEnglish Name: {Ename}" +
            $"\nHomeroom: {Homeroom}" +
            $"\nSent Date: {DetentionDate}" +
            $"\nDetention Type: {DetentionType}" +
            $"\nDetention Content: {DetentionContent}" +
            $"\nTotal Times: {DetentionTimes}" +
            $"\nDone Times: {DoTimes}" +
            $"\nNot Done Time: {UndoTimes}" +
            $"\nUpload Department: {UploadDept}" +
            $"\nStatus: {Status}" +
            $"\nBatch No: {BatchNo}" +
            $"\nBatch Remark: {BatchRemark}" +
            $"\nUploader: {Uploader}" +
            $"\nUploaded Time: {CreateTime}" +
            $"\nUploader IP: {IP}";
    }

    public override bool Equals(object? obj) => Equals(obj as Detention);
    public bool Equals(Detention? other) => other is not null && DetentionID == other.DetentionID && AccountID == other.AccountID && Cname == other.Cname && Ename == other.Ename && Homeroom == other.Homeroom && DetentionDate == other.DetentionDate && DetentionType == other.DetentionType && DetentionContent == other.DetentionContent && DetentionTimes == other.DetentionTimes && DoTimes == other.DoTimes && UploadDept == other.UploadDept && Status == other.Status && BatchNo == other.BatchNo && BatchRemark == other.BatchRemark && Uploader == other.Uploader && CreateTime == other.CreateTime && IP == other.IP;

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
