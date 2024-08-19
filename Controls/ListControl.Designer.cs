namespace DetentionSystem;

partial class ListControl
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
        listView1 = new ListView();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        columnHeader3 = new ColumnHeader();
        columnHeader4 = new ColumnHeader();
        columnHeader5 = new ColumnHeader();
        columnHeader6 = new ColumnHeader();
        columnHeader7 = new ColumnHeader();
        columnHeader8 = new ColumnHeader();
        columnHeader9 = new ColumnHeader();
        columnHeader10 = new ColumnHeader();
        columnHeader11 = new ColumnHeader();
        columnHeader12 = new ColumnHeader();
        columnHeader13 = new ColumnHeader();
        columnHeader14 = new ColumnHeader();
        columnHeader15 = new ColumnHeader();
        columnHeader16 = new ColumnHeader();
        columnHeader17 = new ColumnHeader();
        columnHeader18 = new ColumnHeader();
        tableLayoutPanel2 = new TableLayoutPanel();
        lb_select = new Label();
        btn_edit = new Button();
        btn_delete = new Button();
        btn_hide = new Button();
        btn_saveJson = new Button();
        rtb_json = new RichTextBox();
        saveFileDialog1 = new SaveFileDialog();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
        tableLayoutPanel1.Controls.Add(listView1, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(450, 419);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14, columnHeader15, columnHeader16, columnHeader17, columnHeader18 });
        listView1.Dock = DockStyle.Fill;
        listView1.Location = new Point(3, 4);
        listView1.Margin = new Padding(3, 4, 3, 4);
        listView1.Name = "listView1";
        listView1.Size = new Size(264, 411);
        listView1.TabIndex = 1;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = View.Details;
        listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "Id";
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "Account";
        // 
        // columnHeader3
        // 
        columnHeader3.Text = "Chinese Name";
        // 
        // columnHeader4
        // 
        columnHeader4.Text = "English Name";
        // 
        // columnHeader5
        // 
        columnHeader5.Text = "Homeroom";
        // 
        // columnHeader6
        // 
        columnHeader6.Text = "Date Given";
        // 
        // columnHeader7
        // 
        columnHeader7.Text = "Type";
        // 
        // columnHeader8
        // 
        columnHeader8.Text = "Content";
        // 
        // columnHeader9
        // 
        columnHeader9.Text = "Times";
        // 
        // columnHeader10
        // 
        columnHeader10.Text = "Done Times";
        // 
        // columnHeader11
        // 
        columnHeader11.Text = "Undone Times";
        // 
        // columnHeader12
        // 
        columnHeader12.Text = "Upload Dept";
        // 
        // columnHeader13
        // 
        columnHeader13.Text = "Status";
        // 
        // columnHeader14
        // 
        columnHeader14.Text = "Batch No";
        // 
        // columnHeader15
        // 
        columnHeader15.Text = "Batch";
        // 
        // columnHeader16
        // 
        columnHeader16.Text = "Uploader";
        // 
        // columnHeader17
        // 
        columnHeader17.Text = "Create Time";
        // 
        // columnHeader18
        // 
        columnHeader18.Text = "Uploader IP";
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(lb_select, 0, 0);
        tableLayoutPanel2.Controls.Add(btn_edit, 0, 1);
        tableLayoutPanel2.Controls.Add(btn_delete, 0, 2);
        tableLayoutPanel2.Controls.Add(btn_hide, 0, 3);
        tableLayoutPanel2.Controls.Add(btn_saveJson, 0, 5);
        tableLayoutPanel2.Controls.Add(rtb_json, 0, 4);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(273, 3);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 6;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        tableLayoutPanel2.Size = new Size(174, 413);
        tableLayoutPanel2.TabIndex = 2;
        // 
        // lb_select
        // 
        lb_select.Dock = DockStyle.Fill;
        lb_select.Location = new Point(3, 0);
        lb_select.Name = "lb_select";
        lb_select.Size = new Size(168, 40);
        lb_select.TabIndex = 0;
        lb_select.Text = "None of 0 selected";
        lb_select.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btn_edit
        // 
        btn_edit.Dock = DockStyle.Fill;
        btn_edit.Location = new Point(5, 45);
        btn_edit.Margin = new Padding(5);
        btn_edit.Name = "btn_edit";
        btn_edit.Size = new Size(164, 45);
        btn_edit.TabIndex = 1;
        btn_edit.Text = "button1";
        btn_edit.UseVisualStyleBackColor = true;
        // 
        // btn_delete
        // 
        btn_delete.Dock = DockStyle.Fill;
        btn_delete.Location = new Point(5, 100);
        btn_delete.Margin = new Padding(5);
        btn_delete.Name = "btn_delete";
        btn_delete.Size = new Size(164, 45);
        btn_delete.TabIndex = 2;
        btn_delete.Text = "button1";
        btn_delete.UseVisualStyleBackColor = true;
        // 
        // btn_hide
        // 
        btn_hide.Dock = DockStyle.Fill;
        btn_hide.Location = new Point(5, 155);
        btn_hide.Margin = new Padding(5);
        btn_hide.Name = "btn_hide";
        btn_hide.Size = new Size(164, 45);
        btn_hide.TabIndex = 3;
        btn_hide.Text = "HIde From LIst";
        btn_hide.UseVisualStyleBackColor = true;
        btn_hide.Click += btn_hide_Click;
        // 
        // btn_saveJson
        // 
        btn_saveJson.Dock = DockStyle.Fill;
        btn_saveJson.Location = new Point(5, 359);
        btn_saveJson.Margin = new Padding(5);
        btn_saveJson.Name = "btn_saveJson";
        btn_saveJson.Size = new Size(164, 49);
        btn_saveJson.TabIndex = 4;
        btn_saveJson.Text = "Save As JSON";
        btn_saveJson.UseVisualStyleBackColor = true;
        btn_saveJson.Click += btn_saveJson_Click;
        // 
        // rtb_json
        // 
        rtb_json.Dock = DockStyle.Fill;
        rtb_json.Location = new Point(3, 208);
        rtb_json.Name = "rtb_json";
        rtb_json.ReadOnly = true;
        rtb_json.Size = new Size(168, 143);
        rtb_json.TabIndex = 5;
        rtb_json.Text = "[]";
        // 
        // saveFileDialog1
        // 
        saveFileDialog1.CheckWriteAccess = false;
        saveFileDialog1.Filter = "JSON file|*.json";
        saveFileDialog1.Title = "Save as JSON File";
        // 
        // ListControl
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tableLayoutPanel1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "ListControl";
        Size = new Size(450, 419);
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private ListView listView1;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
    private ColumnHeader columnHeader5;
    private ColumnHeader columnHeader6;
    private ColumnHeader columnHeader7;
    private ColumnHeader columnHeader8;
    private ColumnHeader columnHeader9;
    private ColumnHeader columnHeader10;
    private ColumnHeader columnHeader11;
    private ColumnHeader columnHeader12;
    private ColumnHeader columnHeader13;
    private ColumnHeader columnHeader14;
    private ColumnHeader columnHeader15;
    private ColumnHeader columnHeader16;
    private ColumnHeader columnHeader17;
    private ColumnHeader columnHeader18;
    private TableLayoutPanel tableLayoutPanel2;
    private Label lb_select;
    private Button btn_edit;
    private Button btn_delete;
    private Button btn_hide;
    private Button btn_saveJson;
    private RichTextBox rtb_json;
    private SaveFileDialog saveFileDialog1;
}
