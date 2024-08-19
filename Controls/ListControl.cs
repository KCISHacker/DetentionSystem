using System.Text.Json;
using DetentionSystem.Classes;

namespace DetentionSystem;
public partial class ListControl : UserControl
{
    public ListControl()
    {
        InitializeComponent();
    }

    private void AddDetention(Detention detention)
    {
        var item = new ListViewItem(detention.DetentionID);
        item.SubItems.Add(detention.AccountID);
        item.SubItems.Add(detention.Cname);
        item.SubItems.Add(detention.Ename);
        item.SubItems.Add(detention.Homeroom);
        item.SubItems.Add(detention.DetentionDate?.ToString("yyyy-MM-dd"));
        item.SubItems.Add(detention.DetentionType);
        item.SubItems.Add(detention.DetentionContent);
        item.SubItems.Add(detention.DetentionTimes?.ToString());
        item.SubItems.Add(detention.DoTimes.ToString());
        item.SubItems.Add(detention.UndoTimes.ToString());
        item.SubItems.Add(detention.UploadDept);
        item.SubItems.Add(detention.Status);
        item.SubItems.Add(detention.BatchNo);
        item.SubItems.Add(detention.BatchRemark);
        item.SubItems.Add(detention.Uploader);
        item.SubItems.Add(detention.CreateTime?.ToString("yyyy-MM-dd HH:mm:ss.fff"));
        item.SubItems.Add(detention.IP);

        listView1.Items.Add(item);
    }

    public List<Detention> Detentions = new();

    public void ClearDetentions()
    {
        listView1.Items.Clear();
        lb_select.Text = "None of 0 selected";
        rtb_json.Text = "[]";
    }


    public void LoadDetentions(Detention[] detentions)
    {
        ClearDetentions();
        foreach (var detention in detentions)
        {
            AddDetention(detention);
        }
        UpdateCountLabel();
        Detentions = detentions.ToList();
        UpdateJsonTextBox();
    }

    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateCountLabel();
    }

    private void UpdateCountLabel()
    {
        var selected = listView1.SelectedItems.Count;
        var total = listView1.Items.Count;
        lb_select.Text = string.Format(
            "{0} of {1} selected",
             selected == 0 ? "None" : (selected == total ? "All" : selected),
             total
             );
    }

    private void UpdateJsonTextBox()
    {
        rtb_json.Text = Detention.DetentionsToJson([.. Detentions]);
    }

    public void SaveJsonFile()
    {
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            try
            {
                // Save rtb_json.Text as chosen file
                // Delete first if exists
                if (File.Exists(saveFileDialog1.FileName))
                    File.Delete(saveFileDialog1.FileName);
                File.WriteAllText(saveFileDialog1.FileName, rtb_json.Text);
            }
            catch (Exception ex)
            {
                // Handle the exception here
                Console.WriteLine("An error occurred while saving the file: " + ex.Message);
            }
        }
    }

    private void btn_hide_Click(object sender, EventArgs e)
    {
        RemoveIndiceFromListView(listView1.SelectedIndices.Cast<int>().ToList());
    }

    private void RemoveIndiceFromListView(List<int> indices)
    {
        indices.Sort();
        for (var i = indices.Count - 1; i >= 0; i--)
        {
            listView1.Items.RemoveAt(indices[i]);
        }
    }

    private void btn_saveJson_Click(object sender, EventArgs e)
    {
        SaveJsonFile();
    }
}
