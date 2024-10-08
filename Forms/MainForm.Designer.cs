﻿namespace DetentionSystem;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        saveAsJsonToolStripMenuItem = new ToolStripMenuItem();
        loadJSONToolStripMenuItem = new ToolStripMenuItem();
        downloadAsExcelelToolStripMenuItem = new ToolStripMenuItem();
        viewToolStripMenuItem = new ToolStripMenuItem();
        detailToolStripMenuItem = new ToolStripMenuItem();
        statisticInfoToolStripMenuItem = new ToolStripMenuItem();
        listToolStripMenuItem = new ToolStripMenuItem();
        jsonToolStripMenuItem = new ToolStripMenuItem();
        chartToolStripMenuItem = new ToolStripMenuItem();
        optionsToolStripMenuItem = new ToolStripMenuItem();
        filterToolStripMenuItem = new ToolStripMenuItem();
        moreToolStripMenuItem = new ToolStripMenuItem();
        actionToolStripMenuItem = new ToolStripMenuItem();
        queryToolStripMenuItem = new ToolStripMenuItem();
        cancelToolStripMenuItem = new ToolStripMenuItem();
        cleanToolStripMenuItem = new ToolStripMenuItem();
        loadingBarControl1 = new LoadingBarControl();
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        groupBox2 = new GroupBox();
        queryControl1 = new QueryControl();
        groupBox3 = new GroupBox();
        tableLayoutPanel4 = new TableLayoutPanel();
        rtb_stat = new RichTextBox();
        btn_chart = new Button();
        tableLayoutPanel3 = new TableLayoutPanel();
        btn_clear = new Button();
        groupBox1 = new GroupBox();
        listControl1 = new ListControl();
        openFileDialog1 = new OpenFileDialog();
        backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        menuStrip1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        tableLayoutPanel4.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, optionsToolStripMenuItem, actionToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(9, 4, 0, 4);
        menuStrip1.Size = new Size(921, 37);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveAsJsonToolStripMenuItem, loadJSONToolStripMenuItem, downloadAsExcelelToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(54, 29);
        fileToolStripMenuItem.Text = "&File";
        // 
        // saveAsJsonToolStripMenuItem
        // 
        saveAsJsonToolStripMenuItem.Name = "saveAsJsonToolStripMenuItem";
        saveAsJsonToolStripMenuItem.Size = new Size(311, 34);
        saveAsJsonToolStripMenuItem.Text = "Save As JSON";
        // 
        // loadJSONToolStripMenuItem
        // 
        loadJSONToolStripMenuItem.Name = "loadJSONToolStripMenuItem";
        loadJSONToolStripMenuItem.Size = new Size(311, 34);
        loadJSONToolStripMenuItem.Text = "Load JSON";
        loadJSONToolStripMenuItem.Click += loadJSONToolStripMenuItem_Click;
        // 
        // downloadAsExcelelToolStripMenuItem
        // 
        downloadAsExcelelToolStripMenuItem.Name = "downloadAsExcelelToolStripMenuItem";
        downloadAsExcelelToolStripMenuItem.Size = new Size(311, 34);
        downloadAsExcelelToolStripMenuItem.Text = "Download As Excel (.xlsx)";
        // 
        // viewToolStripMenuItem
        // 
        viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { detailToolStripMenuItem, chartToolStripMenuItem });
        viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        viewToolStripMenuItem.Size = new Size(65, 29);
        viewToolStripMenuItem.Text = "&View";
        // 
        // detailToolStripMenuItem
        // 
        detailToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { statisticInfoToolStripMenuItem, listToolStripMenuItem, jsonToolStripMenuItem });
        detailToolStripMenuItem.Name = "detailToolStripMenuItem";
        detailToolStripMenuItem.Size = new Size(159, 34);
        detailToolStripMenuItem.Text = "&Detail";
        // 
        // statisticInfoToolStripMenuItem
        // 
        statisticInfoToolStripMenuItem.Name = "statisticInfoToolStripMenuItem";
        statisticInfoToolStripMenuItem.Size = new Size(211, 34);
        statisticInfoToolStripMenuItem.Text = "&Statistic Info";
        statisticInfoToolStripMenuItem.Click += statisticInfoToolStripMenuItem_Click;
        // 
        // listToolStripMenuItem
        // 
        listToolStripMenuItem.Name = "listToolStripMenuItem";
        listToolStripMenuItem.Size = new Size(211, 34);
        listToolStripMenuItem.Text = "&List";
        listToolStripMenuItem.Click += listToolStripMenuItem_Click;
        // 
        // jsonToolStripMenuItem
        // 
        jsonToolStripMenuItem.Name = "jsonToolStripMenuItem";
        jsonToolStripMenuItem.Size = new Size(211, 34);
        jsonToolStripMenuItem.Text = "&Json";
        jsonToolStripMenuItem.Click += jsonToolStripMenuItem_Click;
        // 
        // chartToolStripMenuItem
        // 
        chartToolStripMenuItem.Name = "chartToolStripMenuItem";
        chartToolStripMenuItem.Size = new Size(159, 34);
        chartToolStripMenuItem.Text = "&Chart";
        // 
        // optionsToolStripMenuItem
        // 
        optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { filterToolStripMenuItem, moreToolStripMenuItem });
        optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        optionsToolStripMenuItem.Size = new Size(92, 29);
        optionsToolStripMenuItem.Text = "&Options";
        // 
        // filterToolStripMenuItem
        // 
        filterToolStripMenuItem.Name = "filterToolStripMenuItem";
        filterToolStripMenuItem.Size = new Size(156, 34);
        filterToolStripMenuItem.Text = "&Filter";
        filterToolStripMenuItem.Click += filterToolStripMenuItem_Click;
        // 
        // moreToolStripMenuItem
        // 
        moreToolStripMenuItem.Name = "moreToolStripMenuItem";
        moreToolStripMenuItem.Size = new Size(156, 34);
        moreToolStripMenuItem.Text = "&More";
        moreToolStripMenuItem.Click += moreToolStripMenuItem_Click;
        // 
        // actionToolStripMenuItem
        // 
        actionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { queryToolStripMenuItem, cancelToolStripMenuItem, cleanToolStripMenuItem });
        actionToolStripMenuItem.Name = "actionToolStripMenuItem";
        actionToolStripMenuItem.Size = new Size(79, 29);
        actionToolStripMenuItem.Text = "&Action";
        // 
        // queryToolStripMenuItem
        // 
        queryToolStripMenuItem.Name = "queryToolStripMenuItem";
        queryToolStripMenuItem.Size = new Size(165, 34);
        queryToolStripMenuItem.Text = "&Query";
        queryToolStripMenuItem.Click += queryToolStripMenuItem_Click;
        // 
        // cancelToolStripMenuItem
        // 
        cancelToolStripMenuItem.Enabled = false;
        cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
        cancelToolStripMenuItem.Size = new Size(165, 34);
        cancelToolStripMenuItem.Text = "C&ancel";
        cancelToolStripMenuItem.Click += cancelToolStripMenuItem_Click;
        // 
        // cleanToolStripMenuItem
        // 
        cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
        cleanToolStripMenuItem.Size = new Size(165, 34);
        cleanToolStripMenuItem.Text = "&Clean";
        // 
        // loadingBarControl1
        // 
        loadingBarControl1.CurrentProgress = 0;
        loadingBarControl1.Dock = DockStyle.Fill;
        loadingBarControl1.HideMoreSection = true;
        loadingBarControl1.info_text = "Doing Jobs";
        loadingBarControl1.Location = new Point(0, 37);
        loadingBarControl1.Margin = new Padding(4, 5, 4, 5);
        loadingBarControl1.MaxCurrentProgress = 100;
        loadingBarControl1.MaxOverallProgress = 100;
        loadingBarControl1.Name = "loadingBarControl1";
        loadingBarControl1.OverallProgress = 0;
        loadingBarControl1.Size = new Size(921, 520);
        loadingBarControl1.TabIndex = 1;
        loadingBarControl1.Visible = false;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 37);
        tableLayoutPanel1.Margin = new Padding(4);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new Size(921, 520);
        tableLayoutPanel1.TabIndex = 2;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(groupBox2, 0, 0);
        tableLayoutPanel2.Controls.Add(groupBox3, 0, 1);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(4, 4);
        tableLayoutPanel2.Margin = new Padding(4);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 2;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(452, 512);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(queryControl1);
        groupBox2.Dock = DockStyle.Fill;
        groupBox2.Location = new Point(4, 4);
        groupBox2.Margin = new Padding(4);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(4);
        groupBox2.Size = new Size(444, 142);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "Query";
        // 
        // queryControl1
        // 
        queryControl1.Dock = DockStyle.Fill;
        queryControl1.Location = new Point(4, 28);
        queryControl1.Margin = new Padding(4, 5, 4, 5);
        queryControl1.Name = "queryControl1";
        queryControl1.Size = new Size(436, 110);
        queryControl1.TabIndex = 0;
        queryControl1.OnQuery += queryControl1_Query;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(tableLayoutPanel4);
        groupBox3.Dock = DockStyle.Fill;
        groupBox3.Location = new Point(4, 154);
        groupBox3.Margin = new Padding(4);
        groupBox3.Name = "groupBox3";
        groupBox3.Padding = new Padding(4);
        groupBox3.Size = new Size(444, 354);
        groupBox3.TabIndex = 3;
        groupBox3.TabStop = false;
        groupBox3.Text = "Statistic";
        // 
        // tableLayoutPanel4
        // 
        tableLayoutPanel4.ColumnCount = 1;
        tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel4.Controls.Add(rtb_stat, 0, 1);
        tableLayoutPanel4.Controls.Add(btn_chart, 0, 0);
        tableLayoutPanel4.Dock = DockStyle.Fill;
        tableLayoutPanel4.Location = new Point(4, 28);
        tableLayoutPanel4.Margin = new Padding(4);
        tableLayoutPanel4.Name = "tableLayoutPanel4";
        tableLayoutPanel4.RowCount = 2;
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
        tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel4.Size = new Size(436, 322);
        tableLayoutPanel4.TabIndex = 0;
        // 
        // rtb_stat
        // 
        rtb_stat.Dock = DockStyle.Fill;
        rtb_stat.Location = new Point(4, 64);
        rtb_stat.Margin = new Padding(4);
        rtb_stat.Name = "rtb_stat";
        rtb_stat.ReadOnly = true;
        rtb_stat.Size = new Size(428, 254);
        rtb_stat.TabIndex = 1;
        rtb_stat.Text = "";
        rtb_stat.DoubleClick += rtb_stat_DoubleClick;
        // 
        // btn_chart
        // 
        btn_chart.Dock = DockStyle.Fill;
        btn_chart.Enabled = false;
        btn_chart.Location = new Point(3, 3);
        btn_chart.Name = "btn_chart";
        btn_chart.Size = new Size(430, 54);
        btn_chart.TabIndex = 2;
        btn_chart.Text = "Show Chart";
        btn_chart.UseVisualStyleBackColor = true;
        btn_chart.Click += btn_chart_Click;
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel3.Controls.Add(btn_clear, 0, 1);
        tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
        tableLayoutPanel3.Dock = DockStyle.Fill;
        tableLayoutPanel3.Location = new Point(464, 4);
        tableLayoutPanel3.Margin = new Padding(4);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
        tableLayoutPanel3.Size = new Size(453, 512);
        tableLayoutPanel3.TabIndex = 1;
        // 
        // btn_clear
        // 
        btn_clear.Dock = DockStyle.Fill;
        btn_clear.Location = new Point(4, 466);
        btn_clear.Margin = new Padding(4);
        btn_clear.Name = "btn_clear";
        btn_clear.Size = new Size(445, 42);
        btn_clear.TabIndex = 0;
        btn_clear.Text = "Clear";
        btn_clear.UseVisualStyleBackColor = true;
        btn_clear.Click += btn_clear_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(listControl1);
        groupBox1.Dock = DockStyle.Fill;
        groupBox1.Location = new Point(4, 4);
        groupBox1.Margin = new Padding(4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(4);
        groupBox1.Size = new Size(445, 454);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "List";
        // 
        // listControl1
        // 
        listControl1.Dock = DockStyle.Fill;
        listControl1.Location = new Point(4, 28);
        listControl1.Margin = new Padding(4, 5, 4, 5);
        listControl1.Name = "listControl1";
        listControl1.Size = new Size(437, 422);
        listControl1.TabIndex = 1;
        // 
        // openFileDialog1
        // 
        openFileDialog1.CheckFileExists = false;
        openFileDialog1.CheckPathExists = false;
        openFileDialog1.Filter = "JSON file|*.json";
        openFileDialog1.Title = "Load aSON file";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(921, 557);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(loadingBarControl1);
        Controls.Add(menuStrip1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MainMenuStrip = menuStrip1;
        Margin = new Padding(4, 5, 4, 5);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Detention System";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        tableLayoutPanel4.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem viewToolStripMenuItem;
    private ToolStripMenuItem optionsToolStripMenuItem;
    private ToolStripMenuItem filterToolStripMenuItem;
    private ToolStripMenuItem moreToolStripMenuItem;
    private ToolStripMenuItem actionToolStripMenuItem;
    private ToolStripMenuItem queryToolStripMenuItem;
    private ToolStripMenuItem cleanToolStripMenuItem;
    private LoadingBarControl loadingBarControl1;
    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private QueryControl queryControl1;
    private TableLayoutPanel tableLayoutPanel3;
    private Button btn_clear;
    private ListControl listControl1;
    private ToolStripMenuItem saveAsJsonToolStripMenuItem;
    private ToolStripMenuItem loadJSONToolStripMenuItem;
    private ToolStripMenuItem downloadAsExcelelToolStripMenuItem;
    private RichTextBox rtb_stat;
    private ToolStripMenuItem cancelToolStripMenuItem;
    private OpenFileDialog openFileDialog1;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private GroupBox groupBox3;
    private TableLayoutPanel tableLayoutPanel4;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private Button btn_chart;
    private ToolStripMenuItem detailToolStripMenuItem;
    private ToolStripMenuItem statisticInfoToolStripMenuItem;
    private ToolStripMenuItem listToolStripMenuItem;
    private ToolStripMenuItem jsonToolStripMenuItem;
    private ToolStripMenuItem chartToolStripMenuItem;
}
