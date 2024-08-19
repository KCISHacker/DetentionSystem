namespace DetentionSystem;
public partial class LoadingBarControl : UserControl
{
    public LoadingBarControl()
    {
        InitializeComponent();

        info.Font = new Font(info.Font.FontFamily, 50, info.Font.Style, GraphicsUnit.Pixel);
        progressbar1_description.Font = new Font(progressbar1_description.Font.FontFamily, 18, progressbar1_description.Font.Style, GraphicsUnit.Pixel);
        progressbar2_description.Font = new Font(progressbar2_description.Font.FontFamily, 18, progressbar2_description.Font.Style, GraphicsUnit.Pixel);
    }

    private void checkbox_details_CheckedChanged(object sender, EventArgs e)
    {
        if (checkbox_details.Checked)
        {
            tableLayoutPanel1.RowStyles[1].Height = tableLayoutPanel1.RowStyles[2].Height = 20;
            UpdateProgressBar1();
            UpdateProgressBar2();
            return;
        }
        tableLayoutPanel1.RowStyles[1].Height = tableLayoutPanel1.RowStyles[2].Height = 0;
    }

    public int OverallProgress
    {
        get => _overall_progress;
        set
        {
            _overall_progress = value;
            if (!checkbox_details.Checked || value > MaxOverallProgress || value < 0) return;
            UpdateProgressBar1();
        }
    }

    private int _overall_progress = 0;

    void UpdateProgressBar1()
    {
        progressbar1_description.Text =
            $"Overall:\n{progressBar1.Value = _overall_progress} / {MaxOverallProgress} - " +
            $"{(int)(100.0 * _overall_progress / MaxOverallProgress)}%";
    }

    void UpdateProgressBar2()
    {
        progressbar2_description.Text =
            $"Current:\n{progressBar2.Value = _current_progress} / {MaxCurrentProgress} - " +
            $"{(int)(100.0 * _current_progress / MaxCurrentProgress)}%";
    }

    public int MaxOverallProgress
    {
        get => progressBar1.Maximum;
        set
        {
            OverallProgress = 0;
            progressBar1.Maximum = value;
        }
    }

    public int CurrentProgress
    {
        get => _current_progress;
        set
        {
            _current_progress = value;
            if (!checkbox_details.Checked || value > MaxCurrentProgress || value < 0) return;
            UpdateProgressBar2();
        }
    }

    private int _current_progress = 0;

    public int MaxCurrentProgress
    {
        get => progressBar2.Maximum;
        set
        {
            CurrentProgress = 0;
            progressBar2.Maximum = value;
        }
    }

    public string info_text
    {
        get => info.Text;
        set => info.Text = value;
    }
}
