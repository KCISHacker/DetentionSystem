using DetentionSystem.Classes;
using DetentionSystem.Forms;

namespace DetentionSystem;
public partial class ListControl : UserControl
{
    private readonly ListViewColumnSorter lvwColumnSorter;

    public ListControl()
    {
        InitializeComponent();

        lvwColumnSorter = new ListViewColumnSorter();
        listView1.ListViewItemSorter = lvwColumnSorter;
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

        item.Tag = detention;

        listView1.Items.Add(item);
    }

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
        // Detentions = detentions.ToList();
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

        if (listView1.SelectedItems.Count <= 0) btn_hide.Enabled = btn_edit.Enabled = btn_delete.Enabled = false;
        else if (listView1.SelectedItems.Count == 1) btn_hide.Enabled = btn_edit.Enabled = btn_delete.Enabled = true;
        else if (listView1.SelectedItems.Count > 1)
        {
            btn_edit.Enabled = false;
            btn_hide.Enabled = btn_delete.Enabled = true;
        }
    }

    private void UpdateJsonTextBox()
    {
        var detentions = listView1.Items.Cast<ListViewItem>()
            .Where(item => item.Tag is Detention)
            .Select(item => (item.Tag as Detention) ?? new Detention())
            .ToArray();

        rtb_json.Text = Detention.DetentionsToJson(detentions);
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
                MessageBox.Show("An error occurred while saving the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void btn_hide_Click(object sender, EventArgs e)
    {
        DeleteDetention(listView1.SelectedIndices.Cast<int>().ToList(), false);
    }

    private void DeleteDetention(List<int> indices, bool deleteFromCloud)
    {
        indices.Sort();
        foreach (var index in indices.OrderByDescending(i => i))
        {
            if (deleteFromCloud)
            {
                // DANGEROUS!!! DIRECTLY DELETE FROM CLOUD!!! THE ACTION CANNOT BE UNDONE

                if (DetentionAPI.DeleteDetention(listView1.Items[index].Text))
                {
                    MessageBox.Show("Done! Detention has been deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            /*// Meanwhile delete from Detentions by DetentionID == listView1.Items[indices[i]].Text
            var detentionID = listView1.Items[indices[i]].Text;
            Detentions.RemoveAll(d => d.DetentionID == detentionID);*/

            listView1.Items.RemoveAt(index);
        }

        UpdateJsonTextBox();
        UpdateCountLabel();

    }

    private void btn_saveJson_Click(object sender, EventArgs e)
    {
        SaveJsonFile();
    }

    private void rtb_json_DoubleClick(object sender, EventArgs e)
    {
        ShowJsonDetail();
    }

    private void listView1_DoubleClick(object sender, EventArgs e)
    {
        ShowListDetail();
    }

    private void btn_edit_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count != 1) return;
        var selectedItem = listView1.SelectedItems[0];
        if (selectedItem.Tag is Detention dt)
        {
            var editForm = new EditForm(dt);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                if (DetentionAPI.UpdateDetention(dt))
                {
                    selectedItem.Tag = dt;

                    selectedItem.SubItems[5].Text = dt.DetentionDate?.ToString("yyyy-MM-dd");
                    selectedItem.SubItems[7].Text = dt.DetentionContent ?? "";
                    selectedItem.SubItems[8].Text = dt.DetentionTimes?.ToString();
                    selectedItem.SubItems[9].Text = dt.DoTimes?.ToString();
                    selectedItem.SubItems[11].Text = dt.UploadDept;

                    UpdateJsonTextBox();
                }
            }
        }
    }

    private void btn_delete_Click(object sender, EventArgs e)
    {
        // Add delete warnin that this cannot be undone
        if (MessageBox.Show("Are you sure you want to delete the selected detentions?\n" +
            "This action cannot be undone!!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        {
            DeleteDetention(listView1.SelectedIndices.Cast<int>().ToList(), true);
        }
    }

    private void copyDetailToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count <= 0)
        {
            Clipboard.SetText(
                string.Join("\n\n", listView1.Items.Cast<ListViewItem>().Select(item => (item.Tag as Detention)?.ToString() ?? ""))
                );
            return;
        }
        if (listView1.SelectedItems.Count == 1 && listView1.SelectedItems[0].Tag is Detention dt)
        {
            Clipboard.SetText(dt.ToString());
            return;
        }
        // connect to a string
        Clipboard.SetText(
            string.Join("\n\n", listView1.SelectedItems.Cast<ListViewItem>().Select(item => (item.Tag as Detention)?.ToString() ?? ""))
            );
    }

    private void copyAsJsonToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (listView1.SelectedItems.Count <= 0)
        {
            Clipboard.SetText(rtb_json.Text);
            return;
        }
        if (listView1.SelectedItems.Count == 1 && listView1.SelectedItems[0].Tag is Detention dt)
        {
            Clipboard.SetText(Detention.DetentionToJson(dt));
            return;
        }

        Detention[] detentions = listView1.SelectedItems.Cast<ListViewItem>().Select(item => (item.Tag as Detention) ?? new Detention()).ToArray();
        Clipboard.SetText(Detention.DetentionsToJson(detentions));
    }

    public void ShowListDetail()
    {
        new DetailForm(listView1).ShowDialog();
    }

    public void ShowJsonDetail()
    {
        new DetailForm(rtb_json).ShowDialog();
    }

    private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
    {
        var listView = sender as ListView;
        if (e.Column == lvwColumnSorter.SortColumn)
            lvwColumnSorter.Order = (lvwColumnSorter.Order == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending;
        else
        {
            lvwColumnSorter.SortColumn = e.Column;
            lvwColumnSorter.Order = SortOrder.Ascending;
        }
        listView?.Sort();
    }
}
