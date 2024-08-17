namespace DetentionSystem;

partial class LoadingBarControl
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        tableLayoutPanel1 = new TableLayoutPanel();
        info = new Label();
        progressBar1 = new ProgressBar();
        progressBar2 = new ProgressBar();
        progressbar1_description = new Label();
        progressbar2_description = new Label();
        checkbox_details = new CheckBox();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(info, 0, 0);
        tableLayoutPanel1.Controls.Add(progressBar1, 0, 1);
        tableLayoutPanel1.Controls.Add(progressBar2, 0, 2);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0F));
        tableLayoutPanel1.Size = new Size(700, 390);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // info
        // 
        info.Dock = DockStyle.Fill;
        info.Location = new Point(3, 0);
        info.Name = "info";
        info.Size = new Size(694, 390);
        info.TabIndex = 0;
        info.Text = "Doing Job";
        info.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // progressBar1
        // 
        progressBar1.Dock = DockStyle.Fill;
        progressBar1.Location = new Point(3, 393);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new Size(694, 1);
        progressBar1.TabIndex = 0;
        // 
        // progressBar2
        // 
        progressBar2.Dock = DockStyle.Fill;
        progressBar2.Location = new Point(3, 393);
        progressBar2.Name = "progressBar2";
        progressBar2.Size = new Size(694, 1);
        progressBar2.TabIndex = 0;
        // 
        // progressbar1_description
        // 
        progressbar1_description.AutoSize = true;
        progressbar1_description.Location = new Point(0, 0);
        progressbar1_description.Name = "progressbar1_description";
        progressbar1_description.Size = new Size(124, 15);
        progressbar1_description.TabIndex = 1;
        progressbar1_description.Text = "Overall: 0 / 100 - 100%";
        // 
        // progressbar2_description
        // 
        progressbar2_description.AutoSize = true;
        progressbar2_description.Location = new Point(0, 0);
        progressbar2_description.Name = "progressbar2_description";
        progressbar2_description.Size = new Size(127, 15);
        progressbar2_description.TabIndex = 2;
        progressbar2_description.Text = "Current: 0 / 100 - 100%";
        // 
        // checkbox_details
        // 
        checkbox_details.AutoSize = true;
        checkbox_details.Location = new Point(8, 8);
        checkbox_details.Name = "checkbox_details";
        checkbox_details.Size = new Size(56, 19);
        checkbox_details.TabIndex = 3;
        checkbox_details.Text = "Detail";
        checkbox_details.UseVisualStyleBackColor = true;
        checkbox_details.CheckedChanged += checkbox_details_CheckedChanged;
        // 
        // LoadingBar
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(checkbox_details);
        Controls.Add(progressbar2_description);
        Controls.Add(progressbar1_description);
        Controls.Add(tableLayoutPanel1);
        Name = "LoadingBar";
        Size = new Size(700, 390);
        SizeChanged += LoadingBar_SizeChanged;
        tableLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private TableLayoutPanel tableLayoutPanel1;
    private Label info;
    private ProgressBar progressBar1;
    private ProgressBar progressBar2;
    private Label progressbar1_description;
    private Label progressbar2_description;
    private CheckBox checkbox_details;
}
