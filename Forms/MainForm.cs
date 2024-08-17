namespace DetentionSystem;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void moreToolStripMenuItem_Click(object sender, EventArgs e) => new SettingsForm().ShowDialog();
}
