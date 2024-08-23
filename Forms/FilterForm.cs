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
public partial class FilterForm : Form
{
    public DetentionAPI.Filter Filter;

    public FilterForm(DetentionAPI.Filter filter)
    {
        InitializeComponent();

        Filter = filter;

        propertyGrid1.SelectedObject = Filter;

        /*if (filter.Homeroom != null)
        {
            tb_homeroom.Text = filter.Homeroom;
        }
        if (filter.StartingDate != null)
        {
            dt_startDate.Value = DateTime.ParseExact(filter.StartingDate, "yyyyMMdd", null);
        }
        if (filter.EndingDate != null)
        {
            dt_endDate.Value = DateTime.ParseExact(filter.EndingDate, "yyyyMMdd", null);
        }
        if (filter.Type != null)
        {
            tb_type.Text = filter.Type;
        }
        if (filter.BatchRemark != null)
        {
            tb_batchremark.Text = filter.BatchRemark;
        }
        if (filter.UploadDept != null)
        {
            tb_uploaddept.Text = filter.UploadDept;
        }
        if (filter.TotalTimes != null)
        {
            tb_times.Text = filter.TotalTimes;
        }
        if (filter.DoneTimes != null)
        {
            tb_donetimes.Text = filter.DoneTimes;
        }
        if (filter.UndoneTimes != null)
        {
            tb_undonetimes.Text = filter.UndoneTimes;
        }*/
    }

    private void btn_discard_Click(object sender, EventArgs e)
    {
        // Write a messagebox to confirm to discard and close the form
        if (MessageBox.Show("Are you sure you want to discard the changes?", "Discard", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            DialogResult = DialogResult.Cancel;
        }
    }

    private void btn_apply_Click(object sender, EventArgs e)
    {
        /*Filter = new DetentionAPI.Filter
        {
            // Apply filters
            Homeroom = tb_homeroom.Text,
            StartingDate = chb_date.Checked ? dt_startDate.Value.ToString("yyyyMMdd") : null,
            EndingDate = chb_date.Checked ? dt_endDate.Value.ToString("yyyyMMdd") : null,
            Type = tb_type.Text,
            BatchRemark = tb_batchremark.Text,
            UploadDept = tb_uploaddept.Text,
            TotalTimes = tb_times.Text,
            DoneTimes = tb_donetimes.Text,
            UndoneTimes = tb_undonetimes.Text
        };*/
        DialogResult = DialogResult.OK;
    }

    private void help_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        MessageBox.Show("To use this, you need to know how to use 'Regular expression' (if you don't know then just do some search on Wikipeida)\n" +
            "There would be several rows in the property view, which labeled what to be filtered\n" +
            "each of them have a text box, where you are going to enter the regular expression to filter\n" +
            "There would be descriptions or tips under the property view, which you can learn what does the filter does\n\n" +
            "For example, putting '9.*?' in the Homeroom filter filters detentions from homeroom that does not start with 9", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btn_clear_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("Are you sure you want to clear all filters?", "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            Filter = new();
        }
    }
}
