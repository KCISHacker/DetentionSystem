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
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
        tableLayoutPanel1.Controls.Add(listView1, 0, 0);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 1;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.Size = new Size(394, 314);
        tableLayoutPanel1.TabIndex = 0;
        // 
        // listView1
        // 
        listView1.Dock = DockStyle.Fill;
        listView1.Location = new Point(3, 3);
        listView1.Name = "listView1";
        listView1.Size = new Size(230, 308);
        listView1.TabIndex = 1;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = View.Details;
        // 
        // ListControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tableLayoutPanel1);
        Name = "ListControl";
        Size = new Size(394, 314);
        tableLayoutPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel tableLayoutPanel1;
    private ListView listView1;
}
