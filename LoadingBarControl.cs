using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetentionSystem;
public partial class LoadingBarControl : UserControl
{
    public LoadingBarControl()
    {
        InitializeComponent();
        progressbar1_description.Parent = progressBar1;
        progressbar2_description.Parent = progressBar2;
        UpdateLabelSize();
    }

    private void LoadingBar_SizeChanged(object sender, EventArgs e)
    {
        UpdateLabelSize();
    }

    private void UpdateLabelSize()
    {
        if (Width == 0) return;
        info.Font = new Font(info.Font.FontFamily,
            (int)Math.Floor(Math.Max(Width, Height * 0.7) / info.Text.Length), GraphicsUnit.Pixel);
        if (progressBar1.Height < 3) return;
        progressbar1_description.Font = progressbar2_description.Font =
            new Font(progressbar1_description.Font.FontFamily,
                (int)(progressBar1.Height * 0.4), GraphicsUnit.Pixel);
    }

    private void checkbox_details_CheckedChanged(object sender, EventArgs e)
    {
        if (checkbox_details.Checked)
        {
            tableLayoutPanel1.RowStyles[1].Height = tableLayoutPanel1.RowStyles[2].Height = 20;
            UpdateLabelSize();
            return;
        }
        tableLayoutPanel1.RowStyles[1].Height = tableLayoutPanel1.RowStyles[2].Height = 0;
    }

    public int overall_progress
    {
        get => progressBar1.Value;
        set
        {
            if (!checkbox_details.Checked || value > max_overall_progress|| value < 0) return;
            progressBar1.Value = value;
            progressbar1_description.Text = $"Overall: {value} / {max_overall_progress} - {value / max_overall_progress}%";
        }
    }

    public int max_overall_progress
    {
        get => progressBar1.Maximum;
        set => progressBar1.Maximum = value;
    }

    public int current_progress
    {
        get => progressBar2.Value;
        set
        {
            if (!checkbox_details.Checked || value > max_current_progress || value < 0) return;
            progressBar2.Value = value;
            progressbar2_description.Text = $"Current: {value} / {max_current_progress} - {value / max_current_progress}%";
        }
    }

    public int max_current_progress
    {
        get => progressBar2.Maximum;
        set => progressBar2.Maximum = value;
    }

    public string info_text
    {
        get => info.Text;
        set => info.Text = value;
    }
}
