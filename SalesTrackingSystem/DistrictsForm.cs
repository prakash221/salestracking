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
    public partial class DistrictsForm : Form
    {
        IDistrictsService DistrictsService;
        public DistrictsForm()
        {
            InitializeComponent();
            DistrictsService = new DistrictService();
        }
        private bool validateData()
        {
            if (textBoxDistrictId.Text == "")
            {
                textBoxDistrictId.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter District ID", textBoxDistrictId, 2000);
                return true;
            }

            if (textBoxDistrictName.Text == "")
            {
                textBoxDistrictName.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter District Name", textBoxDistrictName, 2000);
                return true;
            }
              return false;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormControl("New");
            textBoxDistrictId.Text = Convert.ToString(DistrictsService.GetId());
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var model = new DistrictsModel()
            {

                DistrictId = Convert.ToInt32(textBoxDistrictId.Text),
                DistrictName = textBoxDistrictName.Text,
                };
            DistrictsService.save(model);
            MessageBox.Show("Save Successfully");
            displaydata();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormControl("Edit");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxDistrictId.Text.Length <= 0)
            {
                MessageBox.Show("Please select a data to Delete");
                return;
            }

            DialogResult a = MessageBox.Show("Are you Sure to delete the data", "Delete", MessageBoxButtons.YesNo);

            if (a == DialogResult.Yes)
            {
                DistrictsService.delete(Convert.ToInt32(textBoxDistrictId.Text));
                MessageBox.Show("Successfully Deleted");
                displaydata();
                FormControl("Reset");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            FormControl("Reset");
        }
        private void serialize()
        {
            for (int i = 1; i < DGVdataGridView.Rows.Count; i++)
            {
                DGVdataGridView.Rows[i].Cells["SNo"].Value = i + 1;
            }
         }
        private void displaydata()
        {
            DGVdataGridView.DataSource = DistrictsService.ListAllData();
        }

        private void DistrictsForm_Load(object sender, EventArgs e)
        {
            displaydata();
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
                        

                        //textbox and input clear
                        textBoxDistrictId.Clear();
                        textBoxDistrictName.Clear();

                        //Clearing read only  from input
                        textBoxDistrictId.ReadOnly = true;
                        textBoxDistrictName.ReadOnly = false;
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

                        //textbox and input clear
                        textBoxDistrictId.Clear();
                        textBoxDistrictName.Clear();

                        //Clearing read only  from input
                        textBoxDistrictId.ReadOnly = true;
                        textBoxDistrictName.ReadOnly = false;
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
                        
                        //textbox and input clear
                        textBoxDistrictId.Clear();
                        textBoxDistrictName.Clear();
                       
                        //Clearing read only  from input
                        textBoxDistrictId.ReadOnly = true;
                        textBoxDistrictName.ReadOnly = true;
                    }
                    break;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var model = new DistrictsModel()
            {
                DistrictId = Convert.ToInt32(textBoxDistrictId.Text),
                DistrictName = textBoxDistrictName.Text
            };
            DistrictsService.update(model);
            MessageBox.Show("Updated Successfully");
            FormControl("Reset");
        }
            private void DGVdataGridView_DoubleClick(object sender, EventArgs e)
        {
            textBoxDistrictId.Text = DGVdataGridView.CurrentRow.Cells["DistrictId"].Value.ToString();
            textBoxDistrictName.Text = DGVdataGridView.CurrentRow.Cells["DistrictName"].Value.ToString();
        }
    }
}
