using DetentionSystem.Classes;
using DetentionSystem.Controls;
using DetentionSystem.Forms;
using static DetentionSystem.Classes.DetentionAPI;

namespace DetentionSystem;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        loadingBarControl1.BringToFront();
    }

    private void queryControl1_Query(object sender, QueryControl.QueryEventArgs e)
    {
        AsyncQueryStart(e.Ids, e.Filters, e.Query);
        btn_chart.Enabled = true;
    }


    public CancellationTokenSource? queryTaskCancellationTokenSource;
    public async void AsyncQueryStart(string[] ids, Filter filter, string query)
    {
        queryTaskCancellationTokenSource?.Cancel();
        queryTaskCancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = queryTaskCancellationTokenSource.Token;

        try
        {
            QueryAction(true, query);

            await Task.Run(() => Query(cancellationToken, ids, filter, query), cancellationToken);

            QueryAction(false, query);

            return;
        }
        catch (OperationCanceledException)
        {
            // Job cancelled
            MessageBox.Show("Querying terminated by user!", "Stopped", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.InnerException} Error occurred when querying: {ex.Message}\n\n" +
                $"Probable solution:\n" +
                $"- Check API avaliability: navigate to Top Strip > Options > More > Check Avaliability\n" +
                $"- Check Internet connection\n" +
                $"- Retry other time\n" +
                $"- Update to the latest version of Detention System: https://github.com/KCISHacker/DetentionSystem", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            queryTaskCancellationTokenSource.Cancel();
        }
        QueryAction(false, query);
        queryTaskCancellationTokenSource = null;
    }

    private void Query(CancellationToken cancellationToken, string[] ids, Filter filter, string query)
    {
        var dts = GetDetentions(ids, filter,
            value => Invoke(() => loadingBarControl1.MaxOverallProgress = value),
            (value) => Invoke(() => loadingBarControl1.OverallProgress = value),
            value => Invoke(() => loadingBarControl1.MaxCurrentProgress = value),
            (value) =>
            {
                Invoke((MethodInvoker)(() => loadingBarControl1.CurrentProgress = value));
                cancellationToken.ThrowIfCancellationRequested();
            }
            );
        Statistic(cancellationToken, dts, query);
    }

    private void Query(CancellationToken cancellationToken, string json, Filter filter, string query)
    {
        var dts = LoadDetentionsFromJson(json, filter,
            value => Invoke(() => loadingBarControl1.MaxCurrentProgress = value),
            (value) =>
            {
                Invoke(() => loadingBarControl1.CurrentProgress = value);
                cancellationToken.ThrowIfCancellationRequested();
            }
            );
        Statistic(cancellationToken, dts, query);
    }

    private void QueryAction(bool prepare, string query)
    {
        if (prepare)
        {
            var query_ = query == "" ? "All" : query;
            loadingBarControl1.info_text = $"Getting Detentions of {query_}...";
        }

        fileToolStripMenuItem.Enabled = viewToolStripMenuItem.Enabled =
            filterToolStripMenuItem.Enabled = optionsToolStripMenuItem.Enabled = queryToolStripMenuItem.Enabled =
            cleanToolStripMenuItem.Enabled = queryControl1.Enabled =
            listControl1.Enabled = rtb_stat.Enabled = !prepare;
        loadingBarControl1.Visible = cancelToolStripMenuItem.Enabled = prepare;
    }

    private void filterToolStripMenuItem_Click(object sender, EventArgs e)
    {
        queryControl1.OpenFilterSettings();
    }

    private void moreToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new SettingsForm().ShowDialog();
    }

    private void btn_clear_Click(object sender, EventArgs e)
    {
        listControl1.ClearDetentions();
        rtb_stat.Text = "";
        btn_chart.Enabled = false;
        chartControl1!.Stat = [];
    }

    private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
    {
        queryTaskCancellationTokenSource?.Cancel();
        queryTaskCancellationTokenSource = null;
    }

    private void queryToolStripMenuItem_Click(object sender, EventArgs e)
    {
        queryControl1.Query();
    }

    private void loadJSONToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            try
            {
                // Read from chosen file
                var json = File.ReadAllText(openFileDialog1.FileName);
                AsyncQueryStart(json, queryControl1.Filter, "JSON");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred when reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public async void AsyncQueryStart(string json, Filter filter, string query)
    {
        queryTaskCancellationTokenSource?.Cancel();
        queryTaskCancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = queryTaskCancellationTokenSource.Token;

        try
        {
            QueryAction(true, query);

            await Task.Run(() => Query(cancellationToken, json, filter, query), cancellationToken);

            QueryAction(false, query);

            return;
        }
        catch (OperationCanceledException)
        {
            // Job cancelled
            MessageBox.Show("Querying terminated by user!", "Stopped", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.InnerException} Error Occurred when querying: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            queryTaskCancellationTokenSource.Cancel();
        }
        QueryAction(false, query);
        queryTaskCancellationTokenSource = null;
    }

    public void Statistic(CancellationToken cancellationToken, Detention[] detentions, string query)
    {
        cancellationToken.ThrowIfCancellationRequested();
        Invoke(() => loadingBarControl1.info_text = $"Statisticizing Detention...");
        var stat = new DetentionStat(query, detentions);
        chartControl1 = new(stat);
        Invoke(() =>
        {
            rtb_stat.Text = stat.GetStatisticString();
            loadingBarControl1.info_text = $"Loading Detentions to List...";
            listControl1.LoadDetentions(detentions);
        });
    }

    private void rtb_stat_DoubleClick(object sender, EventArgs e)
    {
        new DetailForm(rtb_stat).ShowDialog();
    }

    private void statisticInfoToolStripMenuItem_Click(object sender, EventArgs e)
    {
        new DetailForm(rtb_stat).ShowDialog();
    }

    private void listToolStripMenuItem_Click(object sender, EventArgs e)
    {
        listControl1.ShowListDetail();
    }

    private void jsonToolStripMenuItem_Click(object sender, EventArgs e)
    {
        listControl1.ShowJsonDetail();
    }

    private void btn_chart_Click(object sender, EventArgs e)
    {
        if (chartControl1 != null)
            new DetailForm(chartControl1).ShowDialog();
    }

    private ChartControl? chartControl1;
}
