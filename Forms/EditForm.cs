using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
}
