﻿namespace DetentionSystem.Forms;

partial class EditForm
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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
        propertyGrid1 = new PropertyGrid();
        tableLayoutPanel1 = new TableLayoutPanel();
        tableLayoutPanel2 = new TableLayoutPanel();
        btn_ok = new Button();
        btn_cancel = new Button();
        linkLabel1 = new LinkLabel();
        tableLayoutPanel1.SuspendLayout();
        tableLayoutPanel2.SuspendLayout();
        SuspendLayout();
        // 
        // propertyGrid1
        // 
        propertyGrid1.Dock = DockStyle.Fill;
        propertyGrid1.Location = new Point(4, 4);
        propertyGrid1.Margin = new Padding(4);
        propertyGrid1.Name = "propertyGrid1";
        propertyGrid1.Size = new Size(613, 360);
        propertyGrid1.TabIndex = 0;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 1;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Controls.Add(propertyGrid1, 0, 0);
        tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Margin = new Padding(4);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
        tableLayoutPanel1.Size = new Size(621, 430);
        tableLayoutPanel1.TabIndex = 1;
        // 
        // tableLayoutPanel2
        // 
        tableLayoutPanel2.ColumnCount = 3;
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
        tableLayoutPanel2.Controls.Add(btn_ok, 0, 0);
        tableLayoutPanel2.Controls.Add(btn_cancel, 1, 0);
        tableLayoutPanel2.Controls.Add(linkLabel1, 2, 0);
        tableLayoutPanel2.Dock = DockStyle.Fill;
        tableLayoutPanel2.Location = new Point(4, 372);
        tableLayoutPanel2.Margin = new Padding(4);
        tableLayoutPanel2.Name = "tableLayoutPanel2";
        tableLayoutPanel2.RowCount = 1;
        tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel2.Size = new Size(613, 54);
        tableLayoutPanel2.TabIndex = 1;
        // 
        // btn_ok
        // 
        btn_ok.Dock = DockStyle.Fill;
        btn_ok.Location = new Point(4, 4);
        btn_ok.Margin = new Padding(4);
        btn_ok.Name = "btn_ok";
        btn_ok.Size = new Size(196, 46);
        btn_ok.TabIndex = 0;
        btn_ok.Text = "OK";
        btn_ok.UseVisualStyleBackColor = true;
        btn_ok.Click += btn_ok_Click;
        // 
        // btn_cancel
        // 
        btn_cancel.Dock = DockStyle.Fill;
        btn_cancel.Location = new Point(208, 4);
        btn_cancel.Margin = new Padding(4);
        btn_cancel.Name = "btn_cancel";
        btn_cancel.Size = new Size(196, 46);
        btn_cancel.TabIndex = 1;
        btn_cancel.Text = "Cancel";
        btn_cancel.UseVisualStyleBackColor = true;
        btn_cancel.Click += btn_cancel_Click;
        // 
        // linkLabel1
        // 
        linkLabel1.Dock = DockStyle.Fill;
        linkLabel1.Location = new Point(412, 0);
        linkLabel1.Margin = new Padding(4, 0, 4, 0);
        linkLabel1.Name = "linkLabel1";
        linkLabel1.Size = new Size(197, 54);
        linkLabel1.TabIndex = 2;
        linkLabel1.TabStop = true;
        linkLabel1.Text = "Help! WTF is this???";
        linkLabel1.TextAlign = ContentAlignment.MiddleCenter;
        linkLabel1.LinkClicked += linkLabel1_LinkClicked;
        // 
        // EditForm
        // 
        AcceptButton = btn_ok;
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        CancelButton = btn_cancel;
        ClientSize = new Size(621, 430);
        Controls.Add(tableLayoutPanel1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4);
        Name = "EditForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Edit";
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private PropertyGrid propertyGrid1;
    private TableLayoutPanel tableLayoutPanel1;
    private TableLayoutPanel tableLayoutPanel2;
    private Button btn_ok;
    private Button btn_cancel;
    private LinkLabel linkLabel1;
}