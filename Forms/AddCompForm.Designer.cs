namespace DetentionSystem.Forms;

partial class AddCompForm
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
        queryControl1 = new QueryControl();
        loadingBarControl1 = new LoadingBarControl();
        SuspendLayout();
        // 
        // queryControl1
        // 
        queryControl1.Dock = DockStyle.Fill;
        queryControl1.Location = new Point(0, 0);
        queryControl1.Margin = new Padding(4, 5, 4, 5);
        queryControl1.Name = "queryControl1";
        queryControl1.Size = new Size(497, 105);
        queryControl1.TabIndex = 0;
        queryControl1.OnQuery += queryControl1_OnQuery;
        // 
        // loadingBarControl1
        // 
        loadingBarControl1.CurrentProgress = 0;
        loadingBarControl1.Dock = DockStyle.Fill;
        loadingBarControl1.HideMoreSection = true;
        loadingBarControl1.info_text = "Doing Jobs";
        loadingBarControl1.Location = new Point(0, 0);
        loadingBarControl1.Margin = new Padding(4, 5, 4, 5);
        loadingBarControl1.MaxCurrentProgress = 100;
        loadingBarControl1.MaxOverallProgress = 100;
        loadingBarControl1.Name = "loadingBarControl1";
        loadingBarControl1.OverallProgress = 0;
        loadingBarControl1.Size = new Size(497, 105);
        loadingBarControl1.TabIndex = 1;
        // 
        // AddCompForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(497, 105);
        Controls.Add(queryControl1);
        Controls.Add(loadingBarControl1);
        FormBorderStyle = FormBorderStyle.Fixed3D;
        Name = "AddCompForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Add Comparsion";
        ResumeLayout(false);
    }

    #endregion

    private QueryControl queryControl1;
    private LoadingBarControl loadingBarControl1;
}