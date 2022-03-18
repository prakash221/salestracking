using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Service.Service;
using Service.IService;
namespace SalesTrackingSystem
{
    public partial class ProfileDetailForm : Form
    {
        IProfileDetailService ProfileDetailService;
        public ProfileDetailForm()
        {
            InitializeComponent();
            ProfileDetailService = new ProfileDetailService();
        }

        private bool validateData()
        {
            if (textBoxProfileDetailId.Text == "")
            {
                textBoxProfileDetailId.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Profile Detail ID", textBoxProfileDetailId, 2000);
                return true;
            }

            if (textBoxProfileId.Text == "")
            {
                textBoxProfileId.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Profile ID ", textBoxProfileId, 2000);
                return true;
            }
            return false;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }

        private void DGVdataGridView_DoubleClick(object sender, EventArgs e)
        {

        }
        private void serialize()
        {
            for (int i = 1; i < DGVdataGridView.Rows.Count; i++)
            {
                DGVdataGridView.Rows[i].Cells["SNo"].Value = i + 1;
            }

        }
        private void ProfileDetailForm_Load(object sender, EventArgs e)
        {
            displaydata();
        }
        private void displaydata()
        {
            DGVdataGridView.DataSource = ProfileDetailService.ListAllData();
        }
    }
}
