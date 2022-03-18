using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.Service;
using Service.IService;
using Model;

namespace SalesTrackingSystem
{
    public partial class DistributorsForm : Form
    {
        IDistibutorsService DistibutorsService;
        IDistrictsService DistrictsService;
        public DistributorsForm()
        {
            InitializeComponent();
            DistibutorsService = new DistributorService();
            DistrictsService = new DistrictService();
        }
        private void getDataOnCombo()
        {
            var data = DistrictsService.ListAllData();
            comboBoxDistrict.DataSource = data;
            comboBoxDistrict.ValueMember = "DistrictId";
            comboBoxDistrict.DisplayMember = "DistrictName";
        }
        private void DistributorsForm_Load(object sender, EventArgs e)
        {
            displaydata();
        }
        private void displaydata()
        {
            DGVdataGridView.DataSource = DistibutorsService.ListAllData();
            getDataOnCombo();
            
        }
        private bool validateData()
        {
            if (textBoxDistributorId.Text == "")
            {
                textBoxDistributorId.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Distribtor ID", textBoxDistributorId, 2000);
                return true;
            }

            if (textBoxDistributorName.Text == "")
            {
                textBoxDistributorName.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Distributor Name", textBoxDistributorName, 2000);
                return true;
            }

            if (textBoxState.Text == "")
            {
                textBoxState.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter State", textBoxState, 2000);
                return true;
            }

            if (comboBoxDistrict.Text == "")
            {
                comboBoxDistrict.Focus();
                ToolTip t = new ToolTip();
                t.Show("Select District", comboBoxDistrict, 2000);
                return true;
            }

            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Email", textBoxEmail, 2000);
                return true;
            }

            if (textBoxAddress.Text == "")
            {
                textBoxAddress.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Address", textBoxAddress, 2000);
                return true;
            }

            if (textBoxPhone.Text == "")
            {
                textBoxPhone.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Phone", textBoxPhone, 2000);
                return true;
            }

            if (textBoxMobileNumber.Text == "")
            {
                textBoxMobileNumber.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Mobile Number", textBoxMobileNumber, 2000);
                return true;
            }
            return false;
        }


        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormControl("New");
            textBoxDistributorId.Text = Convert.ToString(DistibutorsService.GetId());
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var model = new DistributorsModel()
            {

                DistributorId = Convert.ToInt32(textBoxDistributorId.Text),
                DistributorName = textBoxDistributorName.Text,
                Address = textBoxAddress.Text,
                DistrictId = Convert.ToInt32(comboBoxDistrict.SelectedValue),
                Email = textBoxEmail.Text,
                MobileNo = Convert.ToInt32(textBoxMobileNumber.Text),
                Phone = Convert.ToInt32(textBoxPhone.Text),
                State = textBoxState.Text,
            };
            DistibutorsService.Save(model);
            MessageBox.Show("Save Successfully");
            displaydata();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var model = new DistributorsModel()
            {
                DistributorId = Convert.ToInt32(textBoxDistributorId.Text),
                DistributorName = textBoxDistributorName.Text,
                Address = textBoxAddress.Text,
                DistrictId = Convert.ToInt32(comboBoxDistrict.SelectedValue),
                Email = textBoxEmail.Text,
                MobileNo = Convert.ToInt32(textBoxMobileNumber.Text),
                Phone = Convert.ToInt32(textBoxPhone.Text),
                State = textBoxState.Text
            };
            DistibutorsService.Update(model);
            MessageBox.Show("Updated Successfully");
            FormControl("Reset");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxDistributorId.Text.Length <= 0)
            {
                MessageBox.Show("Please select a data to Delete");
                return;
            }

            DialogResult a = MessageBox.Show("Are you Sure to delete the data", "Delete", MessageBoxButtons.YesNo);

            if (a == DialogResult.Yes)
            {
                DistibutorsService.Delete(Convert.ToInt32(textBoxDistributorId.Text));
                MessageBox.Show("Successfully Deleted");
                displaydata();
                FormControl("Reset");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormControl("Edit");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            FormControl("Reset");
        }
        private void FormControl(string mode)
        {
            switch (mode)
            {
                case "New":
                    {
                        //butoon enabling and  disabling 
                        buttonDelete.Enabled = false;
                        buttonEdit.Enabled = true;
                        buttonReset.Enabled = true;
                        buttonSave.Enabled = true;
                        buttonUpdate.Enabled = false;

                        //textbox and input clear
                        textBoxDistributorId.Clear();
                        textBoxDistributorName.Clear();
                        textBoxAddress.Clear();
                        textBoxMobileNumber.Clear();
                        textBoxPhone.Clear();
                        textBoxState.Clear();
                        textBoxEmail.Clear();

                        //Clearing read only  from input
                        textBoxDistributorId.ReadOnly = true;
                        textBoxDistributorName.ReadOnly = false;
                        textBoxAddress.ReadOnly = false;
                        textBoxMobileNumber.ReadOnly = false;
                        textBoxPhone.ReadOnly = false;
                        textBoxState.ReadOnly = false;
                        textBoxEmail.ReadOnly = false;

                    }
                    break;
                case "Edit":
                    {
                        //butoon enabling and  disabling 
                        buttonNew.Enabled = true;
                        buttonDelete.Enabled = false;
                        buttonEdit.Enabled = false;
                        buttonReset.Enabled = true;
                        buttonSave.Enabled = false;
                        buttonUpdate.Enabled = true;

                        //textbox and input clear
                        textBoxDistributorId.Clear();
                        textBoxDistributorName.Clear();
                        textBoxAddress.Clear();
                        textBoxMobileNumber.Clear();
                        textBoxPhone.Clear();
                        textBoxState.Clear();
                        textBoxEmail.Clear();

                        //Clearing read only  from input
                        textBoxDistributorId.ReadOnly = true;
                        textBoxDistributorName.ReadOnly = false;
                        textBoxAddress.ReadOnly = false;
                        textBoxMobileNumber.ReadOnly = false;
                        textBoxPhone.ReadOnly = false;
                        textBoxState.ReadOnly = false;
                        textBoxEmail.ReadOnly = false;
                    }
                    break;
                case "Reset":
                    {
                        //butoon enabling and  disabling 
                        buttonNew.Enabled = true;
                        buttonDelete.Enabled = false;
                        buttonEdit.Enabled = true;
                        buttonReset.Enabled = true;
                        buttonSave.Enabled = false;
                        buttonUpdate.Enabled = false;

                        //textbox and input clear
                        textBoxDistributorId.Clear();
                        textBoxDistributorName.Clear();
                        textBoxAddress.Clear();
                        textBoxMobileNumber.Clear();
                        textBoxPhone.Clear();
                        textBoxState.Clear();
                        textBoxEmail.Clear();

                        //Clearing read only  from input
                        textBoxDistributorId.ReadOnly = true;
                        textBoxDistributorName.ReadOnly = true;
                        textBoxAddress.ReadOnly = true;
                        textBoxMobileNumber.ReadOnly = true;
                        textBoxPhone.ReadOnly = true;
                        textBoxState.ReadOnly = true;
                        textBoxEmail.ReadOnly = true;


                    }
                    break;
            }
        }
        private void serialize()
        {
            for (int i = 1; i < DGVdataGridView.Rows.Count; i++)
            {
                DGVdataGridView.Rows[i].Cells["SNo"].Value = i + 1;
            }

        }

        private void DGVdataGridView_DoubleClick(object sender, EventArgs e)
        {
            textBoxDistributorId.Text = DGVdataGridView.CurrentRow.Cells["DistributorId"].Value.ToString();
            textBoxDistributorName.Text = DGVdataGridView.CurrentRow.Cells["DistributorName"].Value.ToString();
            textBoxState.Text = DGVdataGridView.CurrentRow.Cells["State"].Value.ToString();
            textBoxAddress.Text = DGVdataGridView.CurrentRow.Cells["Address"].Value.ToString();
            textBoxEmail.Text = DGVdataGridView.CurrentRow.Cells["Email"].Value.ToString();
            textBoxPhone.Text = DGVdataGridView.CurrentRow.Cells["Phone"].Value.ToString();
            textBoxMobileNumber.Text = DGVdataGridView.CurrentRow.Cells["MobileNo"].Value.ToString();
            comboBoxDistrict.SelectedValue = DGVdataGridView.CurrentRow.Cells["DistrictId"].Value.ToString();
            comboBoxDistrict.SelectedText = DGVdataGridView.CurrentRow.Cells["DistrictName"].Value.ToString();
        }
    }
}
