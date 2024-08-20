namespace DetentionSystem.Forms;

partial class FilterForm
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
        tab = new TabControl();
        tab_homeroom = new TabPage();
        label2 = new Label();
        tb_homeroom = new TextBox();
        tab_type = new TabPage();
        label3 = new Label();
        tb_type = new TextBox();
        tab_batchremark = new TabPage();
        label1 = new Label();
        tb_batchremark = new TextBox();
        tab_uploaddept = new TabPage();
        label4 = new Label();
        tb_uploaddept = new TextBox();
        tab_totaltimes = new TabPage();
        label5 = new Label();
        tb_times = new TextBox();
        tab_donetimes = new TabPage();
        label6 = new Label();
        tb_donetimes = new TextBox();
        tab_undonetimes = new TabPage();
        label7 = new Label();
        tb_undonetimes = new TextBox();
        tab_date = new TabPage();
        label9 = new Label();
        dt_endDate = new DateTimePicker();
        label8 = new Label();
        dt_startDate = new DateTimePicker();
        chb_date = new CheckBox();
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        btn_apply = new Button();
        help = new LinkLabel();
        btn_discard = new Button();
        btn_clear = new Button();
        tab.SuspendLayout();
        tab_homeroom.SuspendLayout();
        tab_type.SuspendLayout();
        tab_batchremark.SuspendLayout();
        tab_uploaddept.SuspendLayout();
        tab_totaltimes.SuspendLayout();
        tab_donetimes.SuspendLayout();
        tab_undonetimes.SuspendLayout();
        tab_date.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        SuspendLayout();
        // 
        // tab
        // 
        tab.Controls.Add(tab_homeroom);
        tab.Controls.Add(tab_type);
        tab.Controls.Add(tab_batchremark);
        tab.Controls.Add(tab_uploaddept);
        tab.Controls.Add(tab_totaltimes);
        tab.Controls.Add(tab_donetimes);
        tab.Controls.Add(tab_undonetimes);
        tab.Controls.Add(tab_date);
        tab.Dock = DockStyle.Fill;
        tab.Location = new Point(3, 3);
        tab.Name = "tab";
        tab.SelectedIndex = 0;
        tab.Size = new Size(486, 169);
        tab.TabIndex = 0;
        // 
        // tab_homeroom
        // 
        tab_homeroom.Controls.Add(label2);
        tab_homeroom.Controls.Add(tb_homeroom);
        tab_homeroom.Location = new Point(4, 29);
        tab_homeroom.Name = "tab_homeroom";
        tab_homeroom.Padding = new Padding(3);
        tab_homeroom.Size = new Size(478, 136);
        tab_homeroom.TabIndex = 0;
        tab_homeroom.Text = "Homeroom";
        tab_homeroom.UseVisualStyleBackColor = true;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Dock = DockStyle.Top;
        label2.Location = new Point(3, 30);
        label2.Name = "label2";
        label2.Size = new Size(285, 40);
        label2.TabIndex = 1;
        label2.Text = "Homeroom of the owner of the detention\r\nExample: 708 ; 9H";
        // 
        // tb_homeroom
        // 
        tb_homeroom.Dock = DockStyle.Top;
        tb_homeroom.Location = new Point(3, 3);
        tb_homeroom.Name = "tb_homeroom";
        tb_homeroom.Size = new Size(472, 27);
        tb_homeroom.TabIndex = 0;
        // 
        // tab_type
        // 
        tab_type.Controls.Add(label3);
        tab_type.Controls.Add(tb_type);
        tab_type.Location = new Point(4, 29);
        tab_type.Name = "tab_type";
        tab_type.Padding = new Padding(3);
        tab_type.Size = new Size(478, 136);
        tab_type.TabIndex = 1;
        tab_type.Text = "Type";
        tab_type.UseVisualStyleBackColor = true;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Dock = DockStyle.Top;
        label3.Location = new Point(3, 30);
        label3.Name = "label3";
        label3.Size = new Size(327, 60);
        label3.TabIndex = 1;
        label3.Text = "Type of the detention\r\nExample: 在校行为违规 ; 课堂表现违规\r\nWarning: This may be empty for some detention";
        // 
        // tb_type
        // 
        tb_type.Dock = DockStyle.Top;
        tb_type.Location = new Point(3, 3);
        tb_type.Name = "tb_type";
        tb_type.Size = new Size(472, 27);
        tb_type.TabIndex = 0;
        // 
        // tab_batchremark
        // 
        tab_batchremark.Controls.Add(label1);
        tab_batchremark.Controls.Add(tb_batchremark);
        tab_batchremark.Location = new Point(4, 29);
        tab_batchremark.Name = "tab_batchremark";
        tab_batchremark.Padding = new Padding(3);
        tab_batchremark.Size = new Size(478, 136);
        tab_batchremark.TabIndex = 2;
        tab_batchremark.Text = "Week";
        tab_batchremark.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Dock = DockStyle.Top;
        label1.Location = new Point(3, 30);
        label1.Name = "label1";
        label1.Size = new Size(386, 60);
        label1.TabIndex = 1;
        label1.Text = "Batch remark of the detention\r\nExample: week 1 ; week 2\r\nWarning: Combined weeks may appear: week 5 和 week6";
        // 
        // tb_batchremark
        // 
        tb_batchremark.Dock = DockStyle.Top;
        tb_batchremark.Location = new Point(3, 3);
        tb_batchremark.Name = "tb_batchremark";
        tb_batchremark.Size = new Size(472, 27);
        tb_batchremark.TabIndex = 0;
        // 
        // tab_uploaddept
        // 
        tab_uploaddept.Controls.Add(label4);
        tab_uploaddept.Controls.Add(tb_uploaddept);
        tab_uploaddept.Location = new Point(4, 29);
        tab_uploaddept.Name = "tab_uploaddept";
        tab_uploaddept.Padding = new Padding(3);
        tab_uploaddept.Size = new Size(478, 136);
        tab_uploaddept.TabIndex = 3;
        tab_uploaddept.Text = "Upload Dept.";
        tab_uploaddept.UseVisualStyleBackColor = true;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Dock = DockStyle.Top;
        label4.Location = new Point(3, 30);
        label4.Name = "label4";
        label4.Size = new Size(280, 40);
        label4.TabIndex = 1;
        label4.Text = "Department that uploaded the detention\r\nExample: 美高教务 ; 初中教务";
        // 
        // tb_uploaddept
        // 
        tb_uploaddept.Dock = DockStyle.Top;
        tb_uploaddept.Location = new Point(3, 3);
        tb_uploaddept.Name = "tb_uploaddept";
        tb_uploaddept.Size = new Size(472, 27);
        tb_uploaddept.TabIndex = 0;
        // 
        // tab_totaltimes
        // 
        tab_totaltimes.Controls.Add(label5);
        tab_totaltimes.Controls.Add(tb_times);
        tab_totaltimes.Location = new Point(4, 29);
        tab_totaltimes.Name = "tab_totaltimes";
        tab_totaltimes.Padding = new Padding(3);
        tab_totaltimes.Size = new Size(478, 136);
        tab_totaltimes.TabIndex = 4;
        tab_totaltimes.Text = "Times";
        tab_totaltimes.UseVisualStyleBackColor = true;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Dock = DockStyle.Top;
        label5.Location = new Point(3, 30);
        label5.Name = "label5";
        label5.Size = new Size(231, 40);
        label5.TabIndex = 3;
        label5.Text = "Total times given in the detention\r\nThis is a integer";
        // 
        // tb_times
        // 
        tb_times.Dock = DockStyle.Top;
        tb_times.Location = new Point(3, 3);
        tb_times.Name = "tb_times";
        tb_times.Size = new Size(472, 27);
        tb_times.TabIndex = 2;
        // 
        // tab_donetimes
        // 
        tab_donetimes.Controls.Add(label6);
        tab_donetimes.Controls.Add(tb_donetimes);
        tab_donetimes.Location = new Point(4, 29);
        tab_donetimes.Name = "tab_donetimes";
        tab_donetimes.Padding = new Padding(3);
        tab_donetimes.Size = new Size(478, 136);
        tab_donetimes.TabIndex = 5;
        tab_donetimes.Text = "Done Times";
        tab_donetimes.UseVisualStyleBackColor = true;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Dock = DockStyle.Top;
        label6.Location = new Point(3, 30);
        label6.Name = "label6";
        label6.Size = new Size(297, 40);
        label6.TabIndex = 1;
        label6.Text = "Times that have been done in the detention\r\nThis is a integer";
        // 
        // tb_donetimes
        // 
        tb_donetimes.Dock = DockStyle.Top;
        tb_donetimes.Location = new Point(3, 3);
        tb_donetimes.Name = "tb_donetimes";
        tb_donetimes.Size = new Size(472, 27);
        tb_donetimes.TabIndex = 0;
        // 
        // tab_undonetimes
        // 
        tab_undonetimes.Controls.Add(label7);
        tab_undonetimes.Controls.Add(tb_undonetimes);
        tab_undonetimes.Location = new Point(4, 29);
        tab_undonetimes.Name = "tab_undonetimes";
        tab_undonetimes.Padding = new Padding(3);
        tab_undonetimes.Size = new Size(478, 136);
        tab_undonetimes.TabIndex = 6;
        tab_undonetimes.Text = "Undone Times";
        tab_undonetimes.UseVisualStyleBackColor = true;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Dock = DockStyle.Top;
        label7.Location = new Point(3, 30);
        label7.Name = "label7";
        label7.Size = new Size(300, 40);
        label7.TabIndex = 1;
        label7.Text = "Times that haven't been done in a detention\r\nThis is a integer";
        // 
        // tb_undonetimes
        // 
        tb_undonetimes.Dock = DockStyle.Top;
        tb_undonetimes.Location = new Point(3, 3);
        tb_undonetimes.Name = "tb_undonetimes";
        tb_undonetimes.Size = new Size(472, 27);
        tb_undonetimes.TabIndex = 0;
        // 
        // tab_date
        // 
        tab_date.Controls.Add(label9);
        tab_date.Controls.Add(dt_endDate);
        tab_date.Controls.Add(label8);
        tab_date.Controls.Add(dt_startDate);
        tab_date.Controls.Add(chb_date);
        tab_date.Location = new Point(4, 29);
        tab_date.Name = "tab_date";
        tab_date.Padding = new Padding(3);
        tab_date.Size = new Size(478, 136);
        tab_date.TabIndex = 7;
        tab_date.Text = "Date";
        tab_date.UseVisualStyleBackColor = true;
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Dock = DockStyle.Top;
        label9.Location = new Point(3, 101);
        label9.Name = "label9";
        label9.Size = new Size(309, 20);
        label9.TabIndex = 4;
        label9.Text = "A rangge of time that detentioni is registered";
        // 
        // dt_endDate
        // 
        dt_endDate.Dock = DockStyle.Top;
        dt_endDate.Enabled = false;
        dt_endDate.Location = new Point(3, 74);
        dt_endDate.Name = "dt_endDate";
        dt_endDate.Size = new Size(472, 27);
        dt_endDate.TabIndex = 3;
        // 
        // label8
        // 
        label8.Dock = DockStyle.Top;
        label8.Enabled = false;
        label8.Location = new Point(3, 54);
        label8.Name = "label8";
        label8.Size = new Size(472, 20);
        label8.TabIndex = 2;
        label8.Text = "to";
        label8.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // dt_startDate
        // 
        dt_startDate.Dock = DockStyle.Top;
        dt_startDate.Enabled = false;
        dt_startDate.Location = new Point(3, 27);
        dt_startDate.Name = "dt_startDate";
        dt_startDate.Size = new Size(472, 27);
        dt_startDate.TabIndex = 1;
        // 
        // chb_date
        // 
        chb_date.AutoSize = true;
        chb_date.Dock = DockStyle.Top;
        chb_date.Location = new Point(3, 3);
        chb_date.Name = "chb_date";
        chb_date.Size = new Size(472, 24);
        chb_date.TabIndex = 0;
        chb_date.Text = "Enable date filter";
        chb_date.UseVisualStyleBackColor = true;
        chb_date.CheckedChanged += chb_date_CheckedChanged;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(tab, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        tableLayoutPanel1.Size = new Size(492, 219);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 4;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
        tableLayoutPanel2.Controls.Add(btn_apply, 0, 0);
        tableLayoutPanel2.Controls.Add(help, 3, 0);
        tableLayoutPanel2.Controls.Add(btn_discard, 1, 0);
        tableLayoutPanel2.Controls.Add(btn_clear, 2, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 178);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(486, 38);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // btn_apply
        // 
        btn_apply.Dock = DockStyle.Fill;
        btn_apply.Location = new Point(3, 3);
        btn_apply.Name = "btn_apply";
        btn_apply.Size = new Size(106, 32);
        btn_apply.TabIndex = 0;
        btn_apply.Text = "Apply";
        btn_apply.UseVisualStyleBackColor = true;
        btn_apply.Click += btn_apply_Click;
        // 
        // help
        // 
        help.AutoSize = true;
        help.Dock = DockStyle.Fill;
        help.Location = new Point(339, 0);
        help.Name = "help";
        help.Size = new Size(144, 38);
        help.TabIndex = 1;
        help.TabStop = true;
        help.Text = "Help! WTF is this???";
        help.TextAlign = ContentAlignment.MiddleCenter;
        help.LinkClicked += help_LinkClicked;
        // 
        // btn_discard
        // 
        btn_discard.Dock = DockStyle.Fill;
        btn_discard.Location = new Point(115, 3);
        btn_discard.Name = "btn_discard";
        btn_discard.Size = new Size(106, 32);
        btn_discard.TabIndex = 2;
        btn_discard.Text = "Discard";
        btn_discard.UseVisualStyleBackColor = true;
        btn_discard.Click += btn_discard_Click;
        // 
        // btn_clear
        // 
        btn_clear.Dock = DockStyle.Fill;
        btn_clear.Location = new Point(227, 3);
        btn_clear.Name = "btn_clear";
        btn_clear.Size = new Size(106, 32);
        btn_clear.TabIndex = 3;
        btn_clear.Text = "Clear";
        btn_clear.UseVisualStyleBackColor = true;
        btn_clear.Click += btn_clear_Click;
        // 
        // FilterForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(492, 219);
        Controls.Add(tableLayoutPanel1);
        Name = "FilterForm";
        ShowIcon = false;
        Text = "Filter Settings";
        tab.ResumeLayout(false);
        tab_homeroom.ResumeLayout(false);
        tab_homeroom.PerformLayout();
        tab_type.ResumeLayout(false);
        tab_type.PerformLayout();
        tab_batchremark.ResumeLayout(false);
        tab_batchremark.PerformLayout();
        tab_uploaddept.ResumeLayout(false);
        tab_uploaddept.PerformLayout();
        tab_totaltimes.ResumeLayout(false);
        tab_totaltimes.PerformLayout();
        tab_donetimes.ResumeLayout(false);
        tab_donetimes.PerformLayout();
        tab_undonetimes.ResumeLayout(false);
        tab_undonetimes.PerformLayout();
        tab_date.ResumeLayout(false);
        tab_date.PerformLayout();
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl tab;
    private TabPage tab_homeroom;
    private TabPage tab_type;
    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private Button btn_apply;
    private LinkLabel help;
    private Button btn_discard;
    private TextBox tb_homeroom;
    private TextBox tb_type;
    private TabPage tab_batchremark;
    private TabPage tab_uploaddept;
    private TabPage tab_totaltimes;
    private TabPage tab_donetimes;
    private TabPage tab_undonetimes;
    private TextBox tb_batchremark;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox tb_uploaddept;
    private Label label4;
    private TextBox tb_times;
    private Label label5;
    private TextBox tb_donetimes;
    private Label label6;
    private TextBox tb_undonetimes;
    private Label label7;
    private TabPage tab_date;
    private Button btn_clear;
    private CheckBox chb_date;
    private Label label9;
    private DateTimePicker dt_endDate;
    private Label label8;
    private DateTimePicker dt_startDate;
}