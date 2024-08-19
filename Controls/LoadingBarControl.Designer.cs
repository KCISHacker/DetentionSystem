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
        checkbox_details = new CheckBox();
        progressbar1_description = new Label();
        progressbar2_description = new Label();
        info = new Label();
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        progressBar2 = new ProgressBar();
        tableLayoutPanel3 = new TableLayoutPanel();
        progressBar1 = new ProgressBar();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        SuspendLayout();
        // 
        // checkbox_details
        // 
        checkbox_details.AutoSize = true;
        checkbox_details.Location = new Point(9, 11);
        checkbox_details.Name = "checkbox_details";
        checkbox_details.Size = new Size(385, 24);
        checkbox_details.TabIndex = 3;
        checkbox_details.Text = "Detail (May slow down speed and cause extreme lag)";
        checkbox_details.UseVisualStyleBackColor = true;
        checkbox_details.CheckedChanged += checkbox_details_CheckedChanged;
        // 
        // progressbar1_description
        // 
        progressbar1_description.Dock = DockStyle.Fill;
        progressbar1_description.Location = new Point(3, 0);
        progressbar1_description.Name = "progressbar1_description";
        progressbar1_description.Size = new Size(152, 1);
        progressbar1_description.TabIndex = 4;
        progressbar1_description.Text = "Overall:\r\n0 / 100 - 0%";
        progressbar1_description.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // progressbar2_description
        // 
        progressbar2_description.Dock = DockStyle.Fill;
        progressbar2_description.Location = new Point(3, 0);
        progressbar2_description.Name = "progressbar2_description";
        progressbar2_description.Size = new Size(152, 1);
        progressbar2_description.TabIndex = 5;
        progressbar2_description.Text = "Current:\r\n0 / 100 - 0%";
        progressbar2_description.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // info
        // 
        info.Dock = DockStyle.Fill;
        info.Location = new Point(3, 5);
        info.Margin = new Padding(3, 5, 3, 5);
        info.Name = "info";
        info.Size = new Size(794, 510);
        info.TabIndex = 1;
        info.Text = "Doing Jobs";
        info.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
        tableLayoutPanel1.Controls.Add(info, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0F));
        tableLayoutPanel1.Size = new Size(800, 520);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 2;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
        tableLayoutPanel2.Controls.Add(progressbar2_description, 0, 0);
        tableLayoutPanel2.Controls.Add(progressBar2, 1, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 523);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(794, 1);
        tableLayoutPanel2.TabIndex = 4;
        // 
        // progressBar2
        // 
        progressBar2.Dock = DockStyle.Fill;
        progressBar2.Location = new Point(161, 3);
        progressBar2.Name = "progressBar2";
        progressBar2.Size = new Size(630, 1);
        progressBar2.TabIndex = 0;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 2;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
        tableLayoutPanel3.Controls.Add(progressbar1_description, 0, 0);
        tableLayoutPanel3.Controls.Add(progressBar1, 1, 0);
        tableLayoutPanel3.Dock = DockStyle.Fill;
        tableLayoutPanel3.Location = new Point(3, 523);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel3.Size = new Size(794, 1);
        tableLayoutPanel3.TabIndex = 3;
        // 
        // progressBar1
        // 
        progressBar1.Dock = DockStyle.Fill;
        progressBar1.Location = new Point(161, 3);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new Size(630, 1);
        progressBar1.TabIndex = 0;
        // 
        // LoadingBarControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(checkbox_details);
        Controls.Add(tableLayoutPanel1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "LoadingBarControl";
        Size = new Size(800, 520);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private CheckBox checkbox_details;
    private Label progressbar1_description;
    private Label progressbar2_description;
    private Label info;
    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel3;
    private TableLayoutPanel tableLayoutPanel2;
    private ProgressBar progressBar2;
    private ProgressBar progressBar1;
}
