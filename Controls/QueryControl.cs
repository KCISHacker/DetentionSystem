using DetentionSystem.Classes;
using DetentionSystem.Forms;

namespace DetentionSystem;
public partial class QueryControl : UserControl
{
    public event EventHandler<QueryEventArgs>? OnQuery;

    public class QueryEventArgs : EventArgs
    {
        public string[] Ids;

        public DetentionAPI.Filter Filters;

        public string Query;

        public QueryEventArgs(string[] ids, DetentionAPI.Filter filters, string query) : base()
        {
            Ids = ids;
            Filters = filters;
            Query = query;
        }
    }

    public QueryControl()
    {
        InitializeComponent();
    }

    public DetentionAPI.Filter Filter = new();

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        MessageBox.Show(
            "Enter what you would like to query in the left text box\n" +
            "You can:\n" +
            "Enter a single ID : 12345\n" +
            "Enter an array of IDs : 12345,12346, 11451\n" +
            "Enter a range of IDs : 17000-17999\n" +
            "Enter mixed of arrays and ranges : 17000-17999, 12345\n" +
            "Enter nothing (query all)\n\n" +
            "Add a filter by clicking 'Filters'", "Help",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public string[] GetIds()
    {
        var origin = tb_query.Text.Replace('，', ',').Replace("——", "-").Trim();

        if (origin == "") return [""];

        List<string> res = [];
        var idArray = origin.Split(',', StringSplitOptions.RemoveEmptyEntries);
        for (var i = 0; i < idArray.Length; i++)
        {
            var item = idArray[i].Trim();

            var range = item.Split('-');
            if (range.Length == 1)
            {
                res.Add(idArray[i]);
                continue;
            }
            int start, end;
            if (range.Length == 2 && int.TryParse(range[0], out start) && int.TryParse(range[1], out end))
            {
                if (start > end)
                    (start, end) = (end, start);
                res.AddRange(Enumerable.Range(start, end - start + 1).Select(ele => ele.ToString()));
                continue;
            }
            throw new Exception(string.Format("Unexpected Query: {0}", idArray[i]));
        }
        return [.. res];
    }

    private void textBox1_Enter(object sender, EventArgs e)
    {
        // Thanks to https://stackoverflow.com/a/14695604/21019500
        TextBox TB = (TextBox)sender;
        var VisibleTime = 1000;  //in milliseconds
        ToolTip tt = new ToolTip();
        tt.Show("Click 'Help!' to learn how to query", TB, 0, tb_query.Height, VisibleTime);
    }

    private void btn_query_Click(object sender, EventArgs e)
    {
        Query();
    }
    private void btn_filters_Click(object sender, EventArgs e)
    {
        OpenFilterSettings();
    }
    public void OpenFilterSettings()
    {
        var filterForm = new FilterForm(Filter);
        if (filterForm.ShowDialog() == DialogResult.OK)
        {
            Filter = filterForm.Filter;
        }
    }

    public void Query() => OnQuery?.Invoke(this, new QueryEventArgs(GetIds(), Filter, tb_query.Text.Trim()));

    private void tb_query_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == '\r') Query();
    }
}
