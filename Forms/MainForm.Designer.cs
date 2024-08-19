namespace DetentionSystem;

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
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        saveAsJsonToolStripMenuItem = new ToolStripMenuItem();
        loadJSONToolStripMenuItem = new ToolStripMenuItem();
        downloadAsExcelelToolStripMenuItem = new ToolStripMenuItem();
        viewToolStripMenuItem = new ToolStripMenuItem();
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
        queryControl1 = new QueryControl();
        rtb_stat = new RichTextBox();
        tableLayoutPanel3 = new TableLayoutPanel();
        btn_clear = new Button();
        listControl1 = new ListControl();
        openFileDialog1 = new OpenFileDialog();
        menuStrip1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        tableLayoutPanel3.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, optionsToolStripMenuItem, actionToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Padding = new Padding(7, 3, 0, 3);
        menuStrip1.Size = new Size(809, 30);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveAsJsonToolStripMenuItem, loadJSONToolStripMenuItem, downloadAsExcelelToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(46, 24);
        fileToolStripMenuItem.Text = "&File";
        // 
        // saveAsJsonToolStripMenuItem
        // 
        saveAsJsonToolStripMenuItem.Name = "saveAsJsonToolStripMenuItem";
        saveAsJsonToolStripMenuItem.Size = new Size(260, 26);
        saveAsJsonToolStripMenuItem.Text = "Save As JSON";
        // 
        // loadJSONToolStripMenuItem
        // 
        loadJSONToolStripMenuItem.Name = "loadJSONToolStripMenuItem";
        loadJSONToolStripMenuItem.Size = new Size(260, 26);
        loadJSONToolStripMenuItem.Text = "Load JSON";
        loadJSONToolStripMenuItem.Click += loadJSONToolStripMenuItem_Click;
        // 
        // downloadAsExcelelToolStripMenuItem
        // 
        downloadAsExcelelToolStripMenuItem.Name = "downloadAsExcelelToolStripMenuItem";
        downloadAsExcelelToolStripMenuItem.Size = new Size(260, 26);
        downloadAsExcelelToolStripMenuItem.Text = "Download As Excel (.xlsx)";
        // 
        // viewToolStripMenuItem
        // 
        viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        viewToolStripMenuItem.Size = new Size(55, 24);
        viewToolStripMenuItem.Text = "&View";
        // 
        // optionsToolStripMenuItem
        // 
        optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { filterToolStripMenuItem, moreToolStripMenuItem });
        optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        optionsToolStripMenuItem.Size = new Size(75, 24);
        optionsToolStripMenuItem.Text = "&Options";
        // 
        // filterToolStripMenuItem
        // 
        filterToolStripMenuItem.Name = "filterToolStripMenuItem";
        filterToolStripMenuItem.Size = new Size(127, 26);
        filterToolStripMenuItem.Text = "&Filter";
        filterToolStripMenuItem.Click += filterToolStripMenuItem_Click;
        // 
        // moreToolStripMenuItem
        // 
        moreToolStripMenuItem.Name = "moreToolStripMenuItem";
        moreToolStripMenuItem.Size = new Size(127, 26);
        moreToolStripMenuItem.Text = "&More";
        moreToolStripMenuItem.Click += moreToolStripMenuItem_Click;
        // 
        // actionToolStripMenuItem
        // 
        actionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { queryToolStripMenuItem, cancelToolStripMenuItem, cleanToolStripMenuItem });
        actionToolStripMenuItem.Name = "actionToolStripMenuItem";
        actionToolStripMenuItem.Size = new Size(66, 24);
        actionToolStripMenuItem.Text = "&Action";
        // 
        // queryToolStripMenuItem
        // 
        queryToolStripMenuItem.Name = "queryToolStripMenuItem";
        queryToolStripMenuItem.Size = new Size(136, 26);
        queryToolStripMenuItem.Text = "&Query";
        queryToolStripMenuItem.Click += queryToolStripMenuItem_Click;
        // 
        // cancelToolStripMenuItem
        // 
        cancelToolStripMenuItem.Enabled = false;
        cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
        cancelToolStripMenuItem.Size = new Size(136, 26);
        cancelToolStripMenuItem.Text = "C&ancel";
        cancelToolStripMenuItem.Click += cancelToolStripMenuItem_Click;
        // 
        // cleanToolStripMenuItem
        // 
        cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
        cleanToolStripMenuItem.Size = new Size(136, 26);
        cleanToolStripMenuItem.Text = "&Clean";
        // 
        // loadingBarControl1
        // 
        loadingBarControl1.CurrentProgress = 0;
        loadingBarControl1.Dock = DockStyle.Fill;
        loadingBarControl1.info_text = "Doing Jobs";
        loadingBarControl1.Location = new Point(0, 30);
        loadingBarControl1.Margin = new Padding(3, 4, 3, 4);
        loadingBarControl1.MaxCurrentProgress = 100;
        loadingBarControl1.MaxOverallProgress = 100;
        loadingBarControl1.Name = "loadingBarControl1";
        loadingBarControl1.OverallProgress = 0;
        loadingBarControl1.Size = new Size(809, 429);
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
        tableLayoutPanel1.Location = new Point(0, 30);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new Size(809, 429);
        tableLayoutPanel1.TabIndex = 2;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(queryControl1, 0, 0);
        tableLayoutPanel2.Controls.Add(rtb_stat, 0, 2);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 3;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
        tableLayoutPanel2.Size = new Size(398, 423);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // queryControl1
        // 
        queryControl1.Dock = DockStyle.Fill;
        queryControl1.Location = new Point(3, 4);
        queryControl1.Margin = new Padding(3, 4, 3, 4);
        queryControl1.Name = "queryControl1";
        queryControl1.Size = new Size(392, 76);
        queryControl1.TabIndex = 0;
        queryControl1.OnQuery += queryControl1_Query;
        // 
        // rtb_stat
        // 
        rtb_stat.Dock = DockStyle.Fill;
        rtb_stat.Location = new Point(3, 256);
        rtb_stat.Name = "rtb_stat";
        rtb_stat.ReadOnly = true;
        rtb_stat.Size = new Size(392, 164);
        rtb_stat.TabIndex = 1;
        rtb_stat.Text = "";
        // 
        // tableLayoutPanel3
        // 
        tableLayoutPanel3.ColumnCount = 1;
        tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel3.Controls.Add(btn_clear, 0, 1);
        tableLayoutPanel3.Controls.Add(listControl1, 0, 0);
        tableLayoutPanel3.Dock = DockStyle.Fill;
        tableLayoutPanel3.Location = new Point(407, 3);
        tableLayoutPanel3.Name = "tableLayoutPanel3";
        tableLayoutPanel3.RowCount = 2;
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
        tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel3.Size = new Size(399, 423);
        tableLayoutPanel3.TabIndex = 1;
        // 
        // btn_clear
        // 
        btn_clear.Dock = DockStyle.Fill;
        btn_clear.Location = new Point(3, 383);
        btn_clear.Name = "btn_clear";
        btn_clear.Size = new Size(393, 37);
        btn_clear.TabIndex = 0;
        btn_clear.Text = "Clear";
        btn_clear.UseVisualStyleBackColor = true;
        btn_clear.Click += btn_clear_Click;
        // 
        // listControl1
        // 
        listControl1.Dock = DockStyle.Fill;
        listControl1.Location = new Point(3, 4);
        listControl1.Margin = new Padding(3, 4, 3, 4);
        listControl1.Name = "listControl1";
        listControl1.Size = new Size(393, 372);
        listControl1.TabIndex = 1;
        // 
        // openFileDialog1
        // 
        openFileDialog1.CheckFileExists = false;
        openFileDialog1.CheckPathExists = false;
        openFileDialog1.FileName = "openFileDialog1";
        openFileDialog1.Filter = "JSON file|*.json";
        openFileDialog1.Title = "Load aSON file";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(809, 459);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(loadingBarControl1);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Margin = new Padding(3, 4, 3, 4);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Detention System";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel3.ResumeLayout(false);
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
}
