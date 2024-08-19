namespace DetentionSystem;

partial class SettingsForm
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
        tableLayoutPanel1 = new TableLayoutPanel();
        groupBox2 = new GroupBox();
        richTextBox1 = new RichTextBox();
        groupBox1 = new GroupBox();
        tableLayoutPanel2 = new TableLayoutPanel();
        label1 = new Label();
        label2 = new Label();
        tb_api = new TextBox();
        tb_acc = new TextBox();
        btn_ping_api = new Button();
        btn_check = new Button();
        btn_apply = new Button();
        tableLayoutPanel1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.Controls.Add(groupBox2, 1, 0);
        tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(502, 295);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(richTextBox1);
        groupBox2.Dock = DockStyle.Fill;
        groupBox2.Location = new Point(254, 4);
        groupBox2.Margin = new Padding(3, 4, 3, 4);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(3, 4, 3, 4);
        groupBox2.Size = new Size(245, 287);
        groupBox2.TabIndex = 0;
        groupBox2.TabStop = false;
        groupBox2.Text = "About";
        // 
        // richTextBox1
        // 
        richTextBox1.Dock = DockStyle.Fill;
        richTextBox1.Location = new Point(3, 24);
        richTextBox1.Margin = new Padding(3, 4, 3, 4);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.ReadOnly = true;
        richTextBox1.Size = new Size(239, 259);
        richTextBox1.TabIndex = 0;
        richTextBox1.Text = "KCIS Detention System\nCreated By KCISHackers\nTHIS SOFTWARE IS FOR LEARNING REFERENCE ONLY, RATHER THAN ABUSING, OR YOU WILL TAKE THE RISK!\nStar on GitHub: https://github.com/KCISHacker/DetentionSystem";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(tableLayoutPanel2);
        groupBox1.Dock = DockStyle.Fill;
        groupBox1.Location = new Point(3, 4);
        groupBox1.Margin = new Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 4, 3, 4);
        groupBox1.Size = new Size(245, 287);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "API Options";
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 1;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Controls.Add(label1, 0, 0);
        tableLayoutPanel2.Controls.Add(label2, 0, 2);
        tableLayoutPanel2.Controls.Add(tb_api, 0, 1);
        tableLayoutPanel2.Controls.Add(tb_acc, 0, 3);
        tableLayoutPanel2.Controls.Add(btn_ping_api, 0, 4);
        tableLayoutPanel2.Controls.Add(btn_check, 0, 5);
        tableLayoutPanel2.Controls.Add(btn_apply, 0, 6);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(3, 24);
        tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 7;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.803922F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7058821F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.803922F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7058821F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.6862745F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.6862745F));
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6078434F));
        tableLayoutPanel2.Size = new Size(239, 259);
        tableLayoutPanel2.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Dock = DockStyle.Fill;
        label1.Location = new Point(3, 0);
        label1.Name = "label1";
        label1.Size = new Size(233, 25);
        label1.TabIndex = 0;
        label1.Text = "XueWu API:";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Dock = DockStyle.Fill;
        label2.Location = new Point(3, 63);
        label2.Name = "label2";
        label2.Size = new Size(233, 25);
        label2.TabIndex = 1;
        label2.Text = "Use account:";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // tb_api
        // 
        tb_api.Dock = DockStyle.Fill;
        tb_api.Location = new Point(3, 29);
        tb_api.Margin = new Padding(3, 4, 3, 4);
        tb_api.Name = "tb_api";
        tb_api.Size = new Size(233, 27);
        tb_api.TabIndex = 2;
        tb_api.Leave += tb_api_Leave;
        // 
        // tb_acc
        // 
        tb_acc.Dock = DockStyle.Fill;
        tb_acc.Location = new Point(3, 92);
        tb_acc.Margin = new Padding(3, 4, 3, 4);
        tb_acc.Name = "tb_acc";
        tb_acc.Size = new Size(233, 27);
        tb_acc.TabIndex = 3;
        // 
        // btn_ping_api
        // 
        btn_ping_api.Dock = DockStyle.Fill;
        btn_ping_api.Location = new Point(3, 130);
        btn_ping_api.Margin = new Padding(3, 4, 3, 4);
        btn_ping_api.Name = "btn_ping_api";
        btn_ping_api.Size = new Size(233, 32);
        btn_ping_api.TabIndex = 4;
        btn_ping_api.Text = "Ping API";
        btn_ping_api.UseVisualStyleBackColor = true;
        btn_ping_api.Click += btn_ping_api_Click;
        // 
        // btn_check
        // 
        btn_check.Dock = DockStyle.Fill;
        btn_check.Location = new Point(3, 170);
        btn_check.Margin = new Padding(3, 4, 3, 4);
        btn_check.Name = "btn_check";
        btn_check.Size = new Size(233, 32);
        btn_check.TabIndex = 5;
        btn_check.Text = "Test Avaliability";
        btn_check.UseVisualStyleBackColor = true;
        btn_check.Click += btn_check_Click;
        // 
        // btn_apply
        // 
        btn_apply.Dock = DockStyle.Fill;
        btn_apply.Location = new Point(3, 210);
        btn_apply.Margin = new Padding(3, 4, 3, 4);
        btn_apply.Name = "btn_apply";
        btn_apply.Size = new Size(233, 45);
        btn_apply.TabIndex = 6;
        btn_apply.Text = "Apply";
        btn_apply.UseVisualStyleBackColor = true;
        btn_apply.Click += btn_apply_Click;
        // 
        // SettingsForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(502, 295);
        Controls.Add(tableLayoutPanel1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "SettingsForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Settings";
        tableLayoutPanel1.ResumeLayout(false);
        groupBox2.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private GroupBox groupBox2;
    private GroupBox groupBox1;
    private RichTextBox richTextBox1;
    private TableLayoutPanel tableLayoutPanel2;
    private Label label1;
    private Label label2;
    private TextBox tb_api;
    private TextBox tb_acc;
    private Button btn_ping_api;
    private Button btn_check;
    private Button btn_apply;
}