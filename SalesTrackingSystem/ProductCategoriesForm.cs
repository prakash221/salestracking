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
    public partial class ProductCategoriesForm : Form
    {
        IProductCategorieService ProductCategorieService;
        public ProductCategoriesForm()
        {
            InitializeComponent();
            ProductCategorieService = new ProductCategoriesService();
        }
        private bool validateData()
        {
            if (textBoxProductCateroryId.Text == "")
            {
                textBoxProductCateroryId.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Product Category ID", textBoxProductCateroryId, 2000);
                return true;
            }

            if (textBoxCategoryName.Text == "")
            {
                textBoxCategoryName.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Category Name", textBoxCategoryName, 2000);
                return true;
            }
            return false;
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormControl("New");
           textBoxProductCateroryId.Text = Convert.ToString(ProductCategorieService.GetId());
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var model = new ProductcategoriesModel()
            {

                ProductCategoryId = Convert.ToInt32(textBoxProductCateroryId.Text),
                CategoryName = textBoxCategoryName.Text,
            };
            ProductCategorieService.Save(model);
            MessageBox.Show("Save Successfully");
            displaydata();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormControl("Edit");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxProductCateroryId.Text.Length <= 0)
            {
                MessageBox.Show("Please select a data to Delete");
                return;
            }

            DialogResult a = MessageBox.Show("Are you Sure to delete the data", "Delete", MessageBoxButtons.YesNo);

            if (a == DialogResult.Yes)
            {
              //  ProductCategoriesService.delete(Convert.ToInt32(textBoxProductCateroryId.Text));
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
           // DGVdataGridView.DataSource = productCategoriesService.ListAllData();
        }

        private void ProductCategoriesForm_Load(object sender, EventArgs e)
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
                        buttonUpdate.Enabled = false;


                        //textbox and input clear
                        textBoxProductCateroryId.Clear();
                        textBoxCategoryName.Clear();

                        //Clearing read only  from input
                        textBoxProductCateroryId.ReadOnly = true;
                        textBoxCategoryName.ReadOnly = false;
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
                        textBoxProductCateroryId.Clear();
                        textBoxCategoryName.Clear();

                        //Clearing read only  from input
                        textBoxProductCateroryId.ReadOnly = true;
                        textBoxCategoryName.ReadOnly = false;
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
                        textBoxProductCateroryId.Clear();
                        textBoxCategoryName.Clear();

                        //Clearing read only  from input
                        textBoxProductCateroryId.ReadOnly = true;
                        textBoxCategoryName.ReadOnly = true;
                    }
                    break;
            }
        }

        private void DGVdataGridView_DoubleClick(object sender, EventArgs e)
        {
            textBoxProductCateroryId.Text = DGVdataGridView.CurrentRow.Cells["ProductCategoryId"].Value.ToString();
            textBoxCategoryName.Text = DGVdataGridView.CurrentRow.Cells["CategoryName"].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var model = new ProductcategoriesModel()
            {
                ProductCategoryId = Convert.ToInt32(textBoxProductCateroryId.Text),
                CategoryName = textBoxCategoryName.Text
            };
            ProductCategorieService.Update(model);
            MessageBox.Show("Updated Successfully");
            FormControl("Reset");
        }
    }
}
