namespace DetentionSystem.Forms;

partial class ChartForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        var chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        var legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        var series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
        tableLayoutPanel1 = new TableLayoutPanel();
        chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
        tableLayoutPanel2 = new TableLayoutPanel();
        cb_colorPattern = new ComboBox();
        cb_chartType = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        tableLayoutPanel3 = new TableLayoutPanel();
        label3 = new Label();
        cb_data = new ComboBox();
        btn_addComp = new Button();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(chart1, 0, 1);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
        tableLayoutPanel1.Controls.Add(btn_addComp, 0, 3);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel1.Size = new Size(476, 314);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // chart1
        // 
        chartArea5.Name = "ChartArea1";
        chart1.ChartAreas.Add(chartArea5);
        chart1.Dock = DockStyle.Fill;
        legend5.Name = "Legend1";
        chart1.Legends.Add(legend5);
        chart1.Location = new Point(3, 38);
        chart1.Name = "chart1";
        series5.ChartArea = "ChartArea1";
        series5.Legend = "Legend1";
        series5.Name = "Series1";
        chart1.Series.Add(series5);
        chart1.Size = new Size(470, 198);
        chart1.TabIndex = 0;
        chart1.Text = "chart1";
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 4;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.Controls.Add(cb_colorPattern, 3, 0);
        tableLayoutPanel2.Controls.Add(cb_chartType, 1, 0);
        tableLayoutPanel2.Controls.Add(label1, 0, 0);
        tableLayoutPanel2.Controls.Add(label2, 2, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 242);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(470, 29);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // cb_colorPattern
        // 
        cb_colorPattern.Dock = DockStyle.Fill;
        cb_colorPattern.FormattingEnabled = true;
        cb_colorPattern.Location = new Point(338, 3);
        cb_colorPattern.Name = "cb_colorPattern";
        cb_colorPattern.Size = new Size(129, 28);
        cb_colorPattern.TabIndex = 4;
        // 
        // cb_chartType
        // 
        cb_chartType.Dock = DockStyle.Fill;
        cb_chartType.FormattingEnabled = true;
        cb_chartType.Location = new Point(93, 3);
        cb_chartType.Name = "cb_chartType";
        cb_chartType.Size = new Size(129, 28);
        cb_chartType.TabIndex = 3;
        // 
        // label1
        // 
        label1.Dock = DockStyle.Fill;
        label1.Location = new Point(3, 0);
        label1.Name = "label1";
        label1.Size = new Size(84, 29);
        label1.TabIndex = 0;
        label1.Text = "Chart Type:";
        label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        label2.Dock = DockStyle.Fill;
        label2.Location = new Point(228, 0);
        label2.Name = "label2";
        label2.Size = new Size(104, 29);
        label2.TabIndex = 1;
        label2.Text = "Color Pattern:";
        label2.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 2;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel3.Controls.Add(label3, 0, 0);
        tableLayoutPanel3.Controls.Add(cb_data, 1, 0);
        tableLayoutPanel3.Dock = DockStyle.Fill;
        tableLayoutPanel3.Location = new Point(3, 3);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel3.Size = new Size(470, 29);
        tableLayoutPanel3.TabIndex = 2;
        // 
        // label3
        // 
        label3.Dock = DockStyle.Fill;
        label3.Location = new Point(3, 0);
        label3.Name = "label3";
        label3.Size = new Size(64, 29);
        label3.TabIndex = 1;
        label3.Text = "Data of:";
        label3.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cb_data
        // 
        cb_data.Dock = DockStyle.Fill;
        cb_data.FormattingEnabled = true;
        cb_data.Location = new Point(73, 3);
        cb_data.Name = "cb_data";
        cb_data.Size = new Size(394, 28);
        cb_data.TabIndex = 2;
        // 
        // btn_addComp
        // 
        btn_addComp.Dock = DockStyle.Fill;
        btn_addComp.Location = new Point(3, 277);
        btn_addComp.Name = "btn_addComp";
        btn_addComp.Size = new Size(470, 34);
        btn_addComp.TabIndex = 3;
        btn_addComp.Text = "Add Comparison";
        btn_addComp.UseVisualStyleBackColor = true;
        // 
        // ChartForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(476, 314);
        Controls.Add(tableLayoutPanel1);
        Name = "ChartForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Chart";
        tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private TableLayoutPanel tableLayoutPanel2;
    private Label label1;
    private Label label2;
    private TableLayoutPanel tableLayoutPanel3;
    private Label label3;
    private Button btn_addComp;
    private ComboBox cb_data;
    private ComboBox cb_colorPattern;
    private ComboBox cb_chartType;
}