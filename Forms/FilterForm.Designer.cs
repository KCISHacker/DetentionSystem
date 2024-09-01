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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterForm));
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        btn_apply = new Button();
        help = new LinkLabel();
        btn_discard = new Button();
        btn_clear = new Button();
        propertyGrid1 = new PropertyGrid();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
        tableLayoutPanel1.Controls.Add(propertyGrid1, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Margin = new Padding(4);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
        tableLayoutPanel1.Size = new Size(550, 422);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 4;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 190F));
        tableLayoutPanel2.Controls.Add(btn_apply, 0, 0);
        tableLayoutPanel2.Controls.Add(help, 3, 0);
        tableLayoutPanel2.Controls.Add(btn_discard, 1, 0);
        tableLayoutPanel2.Controls.Add(btn_clear, 2, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(4, 364);
        tableLayoutPanel2.Margin = new Padding(4);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(542, 54);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // btn_apply
        // 
        btn_apply.Dock = DockStyle.Fill;
        btn_apply.Location = new Point(4, 4);
        btn_apply.Margin = new Padding(4);
        btn_apply.Name = "btn_apply";
        btn_apply.Size = new Size(109, 46);
        btn_apply.TabIndex = 0;
        btn_apply.Text = "Apply";
        btn_apply.UseVisualStyleBackColor = true;
        btn_apply.Click += btn_apply_Click;
        // 
        // help
        // 
        help.AutoSize = true;
        help.Dock = DockStyle.Fill;
        help.Location = new Point(355, 0);
        help.Margin = new Padding(4, 0, 4, 0);
        help.Name = "help";
        help.Size = new Size(183, 54);
        help.TabIndex = 1;
        help.TabStop = true;
        help.Text = "Help! WTF is this???";
        help.TextAlign = ContentAlignment.MiddleCenter;
        help.LinkClicked += help_LinkClicked;
        // 
        // btn_discard
        // 
        btn_discard.Dock = DockStyle.Fill;
        btn_discard.Location = new Point(121, 4);
        btn_discard.Margin = new Padding(4);
        btn_discard.Name = "btn_discard";
        btn_discard.Size = new Size(109, 46);
        btn_discard.TabIndex = 2;
        btn_discard.Text = "Discard";
        btn_discard.UseVisualStyleBackColor = true;
        btn_discard.Click += btn_discard_Click;
        // 
        // btn_clear
        // 
        btn_clear.Dock = DockStyle.Fill;
        btn_clear.Location = new Point(238, 4);
        btn_clear.Margin = new Padding(4);
        btn_clear.Name = "btn_clear";
        btn_clear.Size = new Size(109, 46);
        btn_clear.TabIndex = 3;
        btn_clear.Text = "Clear";
        btn_clear.UseVisualStyleBackColor = true;
        btn_clear.Click += btn_clear_Click;
        // 
        // propertyGrid1
        // 
        propertyGrid1.Dock = DockStyle.Fill;
        propertyGrid1.Location = new Point(4, 4);
        propertyGrid1.Margin = new Padding(4);
        propertyGrid1.Name = "propertyGrid1";
        propertyGrid1.Size = new Size(542, 352);
        propertyGrid1.TabIndex = 2;
        // 
        // FilterForm
        // 
        AcceptButton = btn_apply;
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btn_discard;
        ClientSize = new Size(550, 422);
        Controls.Add(tableLayoutPanel1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        Name = "FilterForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Filter Settings";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        tableLayoutPanel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private Button btn_apply;
    private LinkLabel help;
    private Button btn_discard;
    private Button btn_clear;
    private PropertyGrid propertyGrid1;
}