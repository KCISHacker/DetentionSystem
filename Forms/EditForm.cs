using DetentionSystem.Classes;

namespace DetentionSystem.Forms;
public partial class EditForm : Form
{
    public Detention Detention;

    public EditForm(Detention detention)
    {
        InitializeComponent();

        Detention = detention;
        propertyGrid1.SelectedObject = Detention;
    }

    private void btn_ok_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
    }

    private void btn_cancel_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        MessageBox.Show(
            "To set a property, find the corresponding row in the grid above, set as a value you like, and click 'OK'\n" +
            "There will be descriptions or tips for some properties at the buttom of the grid for you to understand what it does\n" +
            "Please be noted that some properties that is marked as gray are read-only, that means you cannot change then", "Help",
            MessageBoxButtons.OK, MessageBoxIcon.Information
            );
    }
}
