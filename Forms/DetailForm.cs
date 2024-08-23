using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetentionSystem.Forms;
public partial class DetailForm : Form
{
    public DetailForm(Control control)
    {
        InitializeComponent();

        ControlOwner = control.Parent;

        Control = control;
        ControlDockStyle = control.Dock;
        control.Dock = DockStyle.Fill;
        Controls.Add(control);
    }

    private readonly Control Control;
    private readonly Control? ControlOwner;
    private readonly DockStyle ControlDockStyle;

    private void DetailForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        Control.Dock = ControlDockStyle;
        ControlOwner?.Controls.Add(Control);
    }
}
