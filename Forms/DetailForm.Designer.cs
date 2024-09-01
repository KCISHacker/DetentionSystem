namespace DetentionSystem.Forms;

partial class DetailForm
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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailForm));
        SuspendLayout();
        // 
        // DetailForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(628, 384);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(4, 4, 4, 4);
        Name = "DetailForm";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterParent;
        Text = "Detail";
        FormClosing += DetailForm_FormClosing;
        ResumeLayout(false);
    }

    #endregion
}