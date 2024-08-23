namespace DetentionSystem.Controls;

partial class ChartControl
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
        var chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
        var legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
        var title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
        tableLayoutPanel1 = new TableLayoutPanel();
        chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
        tableLayoutPanel2 = new TableLayoutPanel();
        cb_colorPalette = new ComboBox();
        cb_chartType = new ComboBox();
        label1 = new Label();
        label2 = new Label();
        tableLayoutPanel3 = new TableLayoutPanel();
        label3 = new Label();
        cb_data = new ComboBox();
        cbx_labelValue = new CheckBox();
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
        tableLayoutPanel1.Margin = new Padding(4);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 4;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tableLayoutPanel1.Size = new Size(630, 384);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // chart1
        // 
        chartArea1.Name = "ChartArea1";
        chart1.ChartAreas.Add(chartArea1);
        chart1.Dock = DockStyle.Fill;
        legend1.Name = "Legend";
        chart1.Legends.Add(legend1);
        chart1.Location = new Point(4, 49);
        chart1.Margin = new Padding(4);
        chart1.Name = "chart1";
        chart1.Size = new Size(622, 236);
        chart1.TabIndex = 0;
        chart1.Text = "Statistic";
        title1.Name = "Title1";
        title1.Text = "Colume Chart of Detentions by ID";
        chart1.Titles.Add(title1);
        chart1.Click += chart1_Click;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 4;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 112F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 138F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel2.Controls.Add(cb_colorPalette, 3, 0);
        tableLayoutPanel2.Controls.Add(cb_chartType, 1, 0);
        tableLayoutPanel2.Controls.Add(label1, 0, 0);
        tableLayoutPanel2.Controls.Add(label2, 2, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(4, 293);
        tableLayoutPanel2.Margin = new Padding(4);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(622, 37);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // cb_colorPalette
        // 
        cb_colorPalette.Dock = DockStyle.Fill;
        cb_colorPalette.DropDownStyle = ComboBoxStyle.DropDownList;
        cb_colorPalette.FormattingEnabled = true;
        cb_colorPalette.Items.AddRange(new object[] { "Bright", "Grayscale", "Excel", "Light", "Pastel", "Earth Tones", "Semi Transparent", "Berry", "Chocolate", "Fire", "Sea Green", "Light Pastel" });
        cb_colorPalette.Location = new Point(440, 4);
        cb_colorPalette.Margin = new Padding(4);
        cb_colorPalette.Name = "cb_colorPalette";
        cb_colorPalette.Size = new Size(178, 33);
        cb_colorPalette.TabIndex = 4;
        cb_colorPalette.SelectedIndexChanged += cb_colorPalette_SelectedIndexChanged;
        // 
        // cb_chartType
        // 
        cb_chartType.Dock = DockStyle.Fill;
        cb_chartType.DropDownStyle = ComboBoxStyle.DropDownList;
        cb_chartType.FormattingEnabled = true;
        cb_chartType.Items.AddRange(new object[] { "Column", "Pie", "Line", "Bar" });
        cb_chartType.Location = new Point(116, 4);
        cb_chartType.Margin = new Padding(4);
        cb_chartType.Name = "cb_chartType";
        cb_chartType.Size = new Size(178, 33);
        cb_chartType.TabIndex = 3;
        cb_chartType.SelectedIndexChanged += cb_chartType_SelectedIndexChanged;
        // 
        // label1
        // 
        label1.Dock = DockStyle.Fill;
        label1.Location = new Point(4, 0);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(104, 37);
        label1.TabIndex = 0;
        label1.Text = "Chart Type:";
        label1.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label2
        // 
        label2.Dock = DockStyle.Fill;
        label2.Location = new Point(302, 0);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(130, 37);
        label2.TabIndex = 1;
        label2.Text = "Color Palette:";
        label2.TextAlign = ContentAlignment.MiddleRight;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 3;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 345F));
        tableLayoutPanel3.Controls.Add(label3, 0, 0);
        tableLayoutPanel3.Controls.Add(cb_data, 1, 0);
        tableLayoutPanel3.Controls.Add(cbx_labelValue, 2, 0);
        tableLayoutPanel3.Dock = DockStyle.Fill;
        tableLayoutPanel3.Location = new Point(4, 4);
        tableLayoutPanel3.Margin = new Padding(4);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 1;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel3.Size = new Size(622, 37);
        tableLayoutPanel3.TabIndex = 2;
        // 
        // label3
        // 
        label3.Dock = DockStyle.Fill;
        label3.Location = new Point(4, 0);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(80, 37);
        label3.TabIndex = 1;
        label3.Text = "Data of:";
        label3.TextAlign = ContentAlignment.MiddleRight;
        // 
        // cb_data
        // 
        cb_data.Dock = DockStyle.Fill;
        cb_data.DropDownStyle = ComboBoxStyle.DropDownList;
        cb_data.FormattingEnabled = true;
        cb_data.Items.AddRange(new object[] { "ID", "Homeroom", "Type", "Week", "Done & Not Done", "Upload Department" });
        cb_data.Location = new Point(92, 4);
        cb_data.Margin = new Padding(4);
        cb_data.Name = "cb_data";
        cb_data.Size = new Size(181, 33);
        cb_data.TabIndex = 2;
        cb_data.SelectedIndexChanged += cb_data_SelectedIndexChanged;
        // 
        // cbx_labelValue
        // 
        cbx_labelValue.AutoSize = true;
        cbx_labelValue.Dock = DockStyle.Fill;
        cbx_labelValue.Location = new Point(280, 3);
        cbx_labelValue.Name = "cbx_labelValue";
        cbx_labelValue.Size = new Size(339, 31);
        cbx_labelValue.TabIndex = 3;
        cbx_labelValue.Text = "Label Value (May cause extreme mess)";
        cbx_labelValue.UseVisualStyleBackColor = true;
        cbx_labelValue.CheckedChanged += cbx_labelValue_CheckedChanged;
        // 
        // btn_addComp
        // 
        btn_addComp.Dock = DockStyle.Fill;
        btn_addComp.Enabled = false;
        btn_addComp.Location = new Point(4, 338);
        btn_addComp.Margin = new Padding(4);
        btn_addComp.Name = "btn_addComp";
        btn_addComp.Size = new Size(622, 42);
        btn_addComp.TabIndex = 3;
        btn_addComp.Text = "Add Comparison (Still in develop)";
        btn_addComp.UseVisualStyleBackColor = true;
        btn_addComp.Click += btn_addComp_Click;
        // 
        // ChartControl
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tableLayoutPanel1);
        Name = "ChartControl";
        Size = new Size(630, 384);
        tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        tableLayoutPanel3.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private TableLayoutPanel tableLayoutPanel2;
    private ComboBox cb_colorPalette;
    private ComboBox cb_chartType;
    private Label label1;
    private Label label2;
    private TableLayoutPanel tableLayoutPanel3;
    private Label label3;
    private ComboBox cb_data;
    private Button btn_addComp;
    private CheckBox cbx_labelValue;
}
