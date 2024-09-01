using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DetentionSystem.Classes;
using static DetentionSystem.Classes.DetentionAPI;

namespace DetentionSystem.Forms;
public partial class AddCompForm : Form
{
    public AddCompForm()
    {
        InitializeComponent();

        loadingBarControl1.BringToFront();
    }

    private void queryControl1_OnQuery(object sender, QueryControl.QueryEventArgs e)
    {
        AsyncQueryStart(e.Ids, e.Filters, e.Query);

    }

    public async void AsyncQueryStart(string[] ids, Filter filter, string query)
    {
        /*queryTaskCancellationTokenSource?.Cancel();
        queryTaskCancellationTokenSource = new CancellationTokenSource();
        var cancellationToken = queryTaskCancellationTokenSource.Token;
*/
        try
        {
            QueryAction(true, query);

            await Task.Run(() => Query(ids, filter, query));

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
            //queryTaskCancellationTokenSource.Cancel();
        }
        QueryAction(false, query);
        //queryTaskCancellationTokenSource = null;
    }

    private void QueryAction(bool prepare, string query)
    {
        if (prepare)
        {
            var query_ = query == "" ? "All" : query;
            loadingBarControl1.info_text = $"Getting Detentions of {query_}...";
        }

        queryControl1.Enabled = prepare;
    }

    private void Query(string[] ids, Filter filter, string query)
    {
        var dts = GetDetentions(ids, filter,
            value => Invoke(() => loadingBarControl1.MaxOverallProgress = value),
            (value) => Invoke(() => loadingBarControl1.OverallProgress = value),
            value => Invoke(() => loadingBarControl1.MaxCurrentProgress = value),
            (value) =>
            {
                Invoke((MethodInvoker)(() => loadingBarControl1.CurrentProgress = value));
                //cancellationToken.ThrowIfCancellationRequested();
            }
            );

    }

    public DetentionStat Stat
    {
        get; set;
    }
}
