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
    public partial class ModuleDetailForm : Form
    {
        IModuleDetailService ModuleDetailService;
        public ModuleDetailForm()  
        {
            InitializeComponent();
            ModuleDetailService = new ModuleDetailService();
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormControl("New");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var model = new ModuleDetailModel()
            {

                ModuleId = Convert.ToInt32(textBoxModuleId.Text),
                ModuleName = textBoxModuleName.Text,
                Controller = textBoxController.Text,
                Action =textBoxAction.Text,
                
            };
            ModuleDetailService.Save(model);
            MessageBox.Show("Save Successfully");
            displaydata();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormControl("Edit");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxModuleId.Text.Length <= 0)
            {
                MessageBox.Show("Please select a data to Delete");
                return;
            }

            DialogResult a = MessageBox.Show("Are you Sure to delete the data", "Delete", MessageBoxButtons.YesNo);

            if (a == DialogResult.Yes)
            {
                ModuleDetailService.Delete(Convert.ToInt32(textBoxModuleId.Text));
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
        private bool validateData()
        {
            if (textBoxModuleId.Text == "")
            {
                textBoxModuleId.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Module Detail ID", textBoxModuleId, 2000);
                return true;
            }

            if (textBoxModuleName.Text == "")
            {
                textBoxModuleName.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Module Name", textBoxModuleName, 2000);
                return true;
            }

            if (textBoxController.Text == "")
            {
                textBoxController.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Controller", textBoxController, 2000);
                return true;
            }
          
           if (textBoxAction.Text == "")
            {
                textBoxAction.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Action", textBoxAction, 2000);
                return true;
            }
            return false;
        }
        private void displaydata()
        {
            DGVdataGridView.DataSource = ModuleDetailService.ListAllData();
        }
        private void ModuleDetailForm_Load(object sender, EventArgs e)
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
                        textBoxModuleId.Clear();
                        textBoxModuleName.Clear();
                        textBoxController.Clear();
                        textBoxAction.Clear();
                        
                        //Clearing read only  from input
                        textBoxModuleId.ReadOnly = true;
                        textBoxModuleName.ReadOnly = false;
                        textBoxController.ReadOnly = false;
                        textBoxAction.ReadOnly = false;
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
                        textBoxModuleId.Clear();
                        textBoxModuleName.Clear();
                        textBoxController.Clear();
                        textBoxAction.Clear();
                        
                        //Clearing read only  from input
                        textBoxModuleId.ReadOnly = true;
                        textBoxModuleName.ReadOnly = false;
                        textBoxController.ReadOnly = false;
                        textBoxAction.ReadOnly = false;
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
                        textBoxModuleId.Clear();
                        textBoxModuleName.Clear();
                        textBoxController.Clear();
                        textBoxAction.Clear();
                       
                        //Clearing read only  from input
                        textBoxModuleId.ReadOnly = true;
                        textBoxModuleName.ReadOnly = true;
                        textBoxController.ReadOnly = true;
                        textBoxAction.ReadOnly = true;
                    }
                    break;
            }
        }

        private void DGVdataGridView_DoubleClick(object sender, EventArgs e)
        {
            textBoxModuleId.Text = DGVdataGridView.CurrentRow.Cells["ModuleId"].Value.ToString();
            textBoxModuleName.Text = DGVdataGridView.CurrentRow.Cells["ModuleName"].Value.ToString();
            textBoxController.Text = DGVdataGridView.CurrentRow.Cells["Controller"].Value.ToString();
            textBoxAction.Text = DGVdataGridView.CurrentRow.Cells["Action"].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var model = new ModuleDetailModel()
            {

                ModuleId = Convert.ToInt32(textBoxModuleId.Text),
                ModuleName = textBoxModuleName.Text,
                Controller = textBoxController.Text,
                Action = textBoxAction.Text,

            };
            ModuleDetailService.Update(model);
            MessageBox.Show("Update Successfully");
            displaydata();
        }
    }
}
