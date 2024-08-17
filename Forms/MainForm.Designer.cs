namespace DetentionSystem;

partial class Form1
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
        viewToolStripMenuItem = new ToolStripMenuItem();
        optionsToolStripMenuItem = new ToolStripMenuItem();
        filterToolStripMenuItem = new ToolStripMenuItem();
        moreToolStripMenuItem = new ToolStripMenuItem();
        actionToolStripMenuItem = new ToolStripMenuItem();
        queryToolStripMenuItem = new ToolStripMenuItem();
        cleanToolStripMenuItem = new ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, optionsToolStripMenuItem, actionToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(800, 24);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(37, 20);
        fileToolStripMenuItem.Text = "&File";
        // 
        // viewToolStripMenuItem
        // 
        viewToolStripMenuItem.Name = "viewToolStripMenuItem";
        viewToolStripMenuItem.Size = new Size(44, 20);
        viewToolStripMenuItem.Text = "&View";
        // 
        // optionsToolStripMenuItem
        // 
        optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { filterToolStripMenuItem, moreToolStripMenuItem });
        optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        optionsToolStripMenuItem.Size = new Size(61, 20);
        optionsToolStripMenuItem.Text = "&Options";
        // 
        // filterToolStripMenuItem
        // 
        filterToolStripMenuItem.Name = "filterToolStripMenuItem";
        filterToolStripMenuItem.Size = new Size(180, 22);
        filterToolStripMenuItem.Text = "&Filter";
        // 
        // moreToolStripMenuItem
        // 
        moreToolStripMenuItem.Name = "moreToolStripMenuItem";
        moreToolStripMenuItem.Size = new Size(180, 22);
        moreToolStripMenuItem.Text = "&More";
        moreToolStripMenuItem.Click += moreToolStripMenuItem_Click;
        // 
        // actionToolStripMenuItem
        // 
        actionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { queryToolStripMenuItem, cleanToolStripMenuItem });
        actionToolStripMenuItem.Name = "actionToolStripMenuItem";
        actionToolStripMenuItem.Size = new Size(54, 20);
        actionToolStripMenuItem.Text = "&Action";
        // 
        // queryToolStripMenuItem
        // 
        queryToolStripMenuItem.Name = "queryToolStripMenuItem";
        queryToolStripMenuItem.Size = new Size(106, 22);
        queryToolStripMenuItem.Text = "&Query";
        // 
        // cleanToolStripMenuItem
        // 
        cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
        cleanToolStripMenuItem.Size = new Size(106, 22);
        cleanToolStripMenuItem.Text = "&Clean";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Detention System";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
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
}
