using System.Windows.Forms.DataVisualization.Charting;
using DetentionSystem.Classes;
using DetentionSystem.Forms;
using static DetentionSystem.Classes.DetentionAPI;
using static DetentionSystem.QueryControl;

namespace DetentionSystem.Controls;
public partial class ChartControl : UserControl
{
    public List<DetentionStat> Stat = [];

    public ChartControl(DetentionStat stat)
    {
        InitializeComponent();

        Stat.Add(stat);

        cb_colorPalette.SelectedIndex = 11; // Bright Pastel
        cb_chartType.SelectedIndex = 0; // Colume
        cb_data.SelectedIndex = 0; // ID
    }

    private void chart1_Click(object sender, EventArgs e)
    {
        new DetailForm(chart1).ShowDialog();
    }

    private void cb_colorPalette_SelectedIndexChanged(object sender, EventArgs e)
    {
        chart1.Palette = (ChartColorPalette)(cb_colorPalette.SelectedIndex + 1);
    }

    private void cb_chartType_SelectedIndexChanged(object sender, EventArgs e)
    {
        foreach (var series in chart1.Series)
        {
            series.ChartType = GetChartType();
        }
        UpdateTitle();
    }

    private SeriesChartType GetChartType()
    {
        return cb_chartType.SelectedIndex switch
        {
            // Colume
            0 => SeriesChartType.Column,
            // Pie
            1 => SeriesChartType.Pie,
            // Line
            2 => SeriesChartType.Line,
            // Bar
            3 => SeriesChartType.Bar,
            _ => SeriesChartType.Column,
        };
    }

    private void UpdateTitle()
    {
        chart1.Titles[0].Text = $"{cb_chartType.Text} Chart of Detentions by {cb_data.Text}";
    }

    private void cb_data_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateChart();
    }

    private void UpdateChart()
    {
        chart1.Series.Clear();
        UpdateTitle();
        for (var i = 0; i < Stat.Count; i++)
        {
            var series = new Series();
            var stat = Stat[i];
            series.Name = stat.Account == "" ? "All" : stat.Account;
            series.ChartType = GetChartType();

            var data = cb_data.SelectedIndex;

            if (series.ChartType == SeriesChartType.Pie)
            {
                series.ToolTip = "#VALX: #VAL";
                series.Points.Clear();

                switch (data)
                {
                    case 0: // ID
                        foreach (var detention in stat!.AccountsWithDetentions)
                        {
                            series.Points.AddXY(detention.Key, detention.Value);
                        }
                        break;
                    case 1: // Homeroom
                        foreach (var homeroom in stat!.HomeroomsWithDetentions)
                        {
                            series.Points.AddXY(homeroom.Key, homeroom.Value);
                        }
                        break;
                    case 2: // Type
                        foreach (var type in stat!.TypeOfDetentions)
                        {
                            series.Points.AddXY(type.Key, type.Value);
                        }
                        break;
                    case 3: // Week
                        foreach (var time in stat!.DetentionInWeeks)
                        {
                            series.Points.AddXY(time.Key, time.Value);
                        }
                        break;
                    case 4: // Done & Not Done
                        series.Points.AddXY("Done", stat!.Done);
                        series.Points.AddXY("Undone", stat!.Undone);
                        break;
                    case 5: // Department
                        foreach (var department in stat!.DetentionsFromDepartments)
                        {
                            series.Points.AddXY(department.Key, department.Value);
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                series.IsXValueIndexed = true;
                switch (data)
                {
                    case 0: // ID
                        foreach (var detention in stat.AccountsWithDetentions)
                        {
                            series.Points.Add(GetChartDataPoint(detention.Key, detention.Value));
                        }
                        break;
                    case 1: // Homeroom
                        foreach (var homeroom in stat.HomeroomsWithDetentions)
                        {
                            series.Points.Add(GetChartDataPoint(homeroom.Key, homeroom.Value));
                        }
                        break;
                    case 2: // Type
                        foreach (var type in stat.TypeOfDetentions)
                        {
                            series.Points.Add(GetChartDataPoint(type.Key, type.Value));
                        }
                        break;
                    case 3: // Week
                        foreach (var time in stat.DetentionInWeeks)
                        {
                            series.Points.Add(GetChartDataPoint(time.Key.ToString(), time.Value));
                        }
                        break;
                    case 4: // Done & Not Done
                        series.Points.Add(GetChartDataPoint("Done", stat.Done));
                        series.Points.Add(GetChartDataPoint("Undone", stat.Undone));
                        break;
                    case 5: // Department
                        foreach (var department in stat.DetentionsFromDepartments)
                        {
                            series.Points.Add(GetChartDataPoint(department.Key, department.Value));
                        }
                        break;
                    default:
                        break;
                }
            }

            chart1.Series.Add(series);
        }
    }

    private DataPoint GetChartDataPoint(string x, int y)
    {
        var dp = new DataPoint
        {
            AxisLabel = x,
            YValues = [y],
            ToolTip = "#AXISLABEL: #VAL"
        };
        if (cbx_labelValue.Checked)
            dp.Label = y.ToString();
        return dp;
    }

    private void cbx_labelValue_CheckedChanged(object sender, EventArgs e)
    {
        UpdateChart();
    }

    private void btn_addComp_Click(object sender, EventArgs e)
    {
        // TODO: Add addcomp code
        /*var query = new QueryControl();
        query.OnQuery += OnQuery;
        new DetailForm(query).ShowDialog();*/
    }

    /*private void OnQuery(object? sender, QueryEventArgs e)
    {
        AsyncQueryStart(e.Ids, e.Filters, e.Query);
    }

    public async void AsyncQueryStart(string[] ids, Filter filter, string query)
    {
        try
        {
            await Task.Run(() => Query(ids, filter, query));

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
        }
    }


    private void Query(string[] ids, Filter filter, string query)
    {
        try
        {
            var dts = GetDetentions(ids, filter, (v) => { }, (v) => { }, (v) => { }, (v) => { });
            var stat = new DetentionStat(query, dts);
            Stat.Add(stat);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"{ex.InnerException} Error Occurred when querying: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }*/
}
