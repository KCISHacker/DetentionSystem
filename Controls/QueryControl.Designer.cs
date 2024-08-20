namespace DetentionSystem;

partial class QueryControl
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
        btn_query = new Button();
        tableLayoutPanel2 = new TableLayoutPanel();
        linkLabel1 = new LinkLabel();
        btn_filters = new Button();
        tb_query = new TextBox();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(btn_query, 0, 1);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Size = new Size(423, 88);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // btn_query
        // 
        btn_query.Dock = DockStyle.Fill;
        btn_query.Location = new Point(3, 48);
        btn_query.Margin = new Padding(3, 4, 3, 4);
        btn_query.Name = "btn_query";
        btn_query.Size = new Size(417, 36);
        btn_query.TabIndex = 1;
        btn_query.Text = "&Query";
        btn_query.UseVisualStyleBackColor = true;
        btn_query.Click += btn_query_Click;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 3;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
        tableLayoutPanel2.Controls.Add(linkLabel1, 2, 0);
        tableLayoutPanel2.Controls.Add(btn_filters, 1, 0);
        tableLayoutPanel2.Controls.Add(tb_query, 0, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 4);
        tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(417, 36);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // linkLabel1
        // 
        linkLabel1.Dock = DockStyle.Fill;
        linkLabel1.Location = new Point(336, 0);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(78, 36);
        linkLabel1.TabIndex = 2;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Help!";
        linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // btn_filters
        // 
        btn_filters.Dock = DockStyle.Fill;
        btn_filters.Location = new Point(253, 0);
        btn_filters.Margin = new Padding(3, 0, 3, 0);
        btn_filters.Name = "btn_filters";
        btn_filters.Size = new Size(77, 36);
        btn_filters.TabIndex = 1;
        btn_filters.Text = "Filters";
        btn_filters.UseVisualStyleBackColor = true;
        btn_filters.Click += btn_filters_Click;
        // 
        // tb_query
        // 
        tb_query.Dock = DockStyle.Fill;
        tb_query.Location = new Point(3, 3);
        tb_query.Name = "tb_query";
        tb_query.Size = new Size(244, 27);
        tb_query.TabIndex = 0;
        tb_query.Enter += textBox1_Enter;
        // 
        // QueryControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tableLayoutPanel1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "QueryControl";
        Size = new Size(423, 88);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private Button btn_query;
    private TableLayoutPanel tableLayoutPanel2;
    private LinkLabel linkLabel1;
    private Button btn_filters;
    private TextBox tb_query;
}
