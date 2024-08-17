using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DetentionSystemCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DetentionSystem;
public partial class SettingsForm : Form
{
    public SettingsForm()
    {
        InitializeComponent();

        tb_api.Text = KCISAPI.base_uri.ToString();
        tb_acc.Text = Program.KCISAPI.account;

        richTextBox1.SelectAll();
        richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        SelectText("THIS SOFTWARE IS FOR LEARNING REFERENCE ONLY, RATHER THAN ABUSING, OR YOU WILL TAKE THE RISK!");
        richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline | FontStyle.Italic);
        richTextBox1.SelectionColor = Color.Red;
        var systemColor = ColorTranslator.FromHtml("#009fa8");
        SelectText("KCISHackers");
        richTextBox1.SelectionColor = systemColor;
        SelectText("KCIS Detention System");
        richTextBox1.SelectionColor = systemColor;
        richTextBox1.DeselectAll();
    }

    private void SelectText(string text)
    {
        var start = richTextBox1.Find(text, RichTextBoxFinds.WholeWord);
        richTextBox1.Select(start, text.Length);
    }

    Uri api = KCISAPI.base_uri;

    private void tb_api_Leave(object sender, EventArgs e)
    {
        if (Uri.TryCreate(tb_api.Text, UriKind.Absolute, out var uri))
        {
            //KCISAPI.base_uri = uri;
            api = uri;
            return;
        }
        MessageBox.Show("Not an valid URI!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        tb_api.Text = KCISAPI.base_uri.ToString();
    }

    private void btn_ping_api_Click(object sender, EventArgs e)
    {
        if (KCISAPI.GetRequest(api, new System.Net.CookieContainer(), out _))
        {
            MessageBox.Show("API is online!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        MessageBox.Show("API is offline!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void btn_check_Click(object sender, EventArgs e)
    {
        if (KCISAPI.TestAPI(tb_acc.Text, api))
        {
            MessageBox.Show("Test passed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        MessageBox.Show("Test failed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }

    private void btn_apply_Click(object sender, EventArgs e)
    {
        KCISAPI.base_uri = api;
        Program.KCISAPI.account = tb_acc.Text;
        Close();
    }
}
