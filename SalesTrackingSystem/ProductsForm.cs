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
using Service.IService;
using Service.Service;
namespace SalesTrackingSystem
{
    public partial class ProductsForm : Form
    {
        IProductsService productsService;
        public ProductsForm()
        {
            InitializeComponent();
            productsService = new ProductsService();
        }

        private bool validateData()
        {
            if (textBoxProductId.Text == "")
            {
                textBoxProductId.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Product ID", textBoxProductId, 2000);
                return true;
            }

            if (textBoxProductName.Text == "")
            {
                textBoxProductName.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Product Name", textBoxProductName, 2000);
                return true;
            }

            if (textBoxProductDescription.Text == "")
            {
                textBoxProductDescription.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Product Description", textBoxProductDescription, 2000);
                return true;
            }

            if (textBoxUnit.Text == "")
            {
                textBoxUnit.Focus();
                ToolTip t = new ToolTip();
                t.Show("Select Unit", textBoxUnit, 2000);
                return true;
            }

            if (textBoxProductCategoryId.Text == "")
            {
                textBoxProductCategoryId.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Product Category Id", textBoxProductCategoryId, 2000);
                return true;
            }

            if (textBoxUnitRate.Text == "")
            {
                textBoxUnitRate.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Unit Rate", textBoxUnitRate, 2000);
                return true;
            }

            if (textBoxPackRate.Text == "")
            {
                textBoxPackRate.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Pack Rate", textBoxPackRate, 2000);
                return true;
            }

            if (textBoxPackSize.Text == "")
            {
                textBoxPackSize.Focus();
                ToolTip t = new ToolTip();
                t.Show("Enter Pack Size", textBoxPackSize, 2000);
                return true;
            }
            return false;
        }
        private void buttonNew_Click(object sender, EventArgs e)
        {
            FormControl("New");
            textBoxProductId.Text = Convert.ToString(productsService.GetId());
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void displaydata()
        {
            DGVdataGridView.DataSource = productsService.ListAllData();
        }

        private void serialize()
        {
            for (int i = 1; i < DGVdataGridView.Rows.Count; i++)
            {
                DGVdataGridView.Rows[i].Cells["SNo"].Value = i + 1;
            }

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var model = new ProductsModel()
            {

                ProductId = Convert.ToInt32(textBoxProductId.Text),
                ProductName = textBoxProductName.Text,
                ProductDescription = textBoxProductDescription.Text,
                Unit = Convert.ToInt32(textBoxUnit.Text),
                ProductCategoryId = Convert.ToInt32(textBoxProductCategoryId.Text),
                UnitRate = Convert.ToInt32(textBoxUnitRate.Text),
                PackRate = Convert.ToInt32(textBoxPackRate.Text),
                PackSize = Convert.ToInt32(textBoxPackSize.Text),
            };
            productsService.Save(model);
            MessageBox.Show("Save Successfully");
            displaydata();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var model = new ProductsModel()
            {

                ProductId = Convert.ToInt32(textBoxProductId.Text),
                ProductName = textBoxProductName.Text,
                ProductDescription = textBoxProductDescription.Text,
                Unit = Convert.ToInt32(textBoxUnit.Text),
                ProductCategoryId = Convert.ToInt32(textBoxProductCategoryId.Text),
                UnitRate = Convert.ToInt32(textBoxUnitRate.Text),
                PackRate = Convert.ToInt32(textBoxPackRate.Text),
                PackSize = Convert.ToInt32(textBoxPackSize.Text),
            };
            productsService.Update(model);
            MessageBox.Show("Save Successfully");
            displaydata();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (textBoxProductId.Text.Length <= 0)
            {
                MessageBox.Show("Please select a data to Delete");
                return;
            }

            DialogResult a = MessageBox.Show("Are you Sure to delete the data", "Delete", MessageBoxButtons.YesNo);

            if (a == DialogResult.Yes)
            {
                productsService.Delete(Convert.ToInt32(textBoxProductId.Text));
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
                        textBoxProductId.Clear();
                        textBoxProductName.Clear();
                        textBoxProductDescription.Clear();
                        textBoxUnit.Clear();
                        textBoxProductCategoryId.Clear();
                        textBoxUnitRate.Clear();
                        textBoxPackRate.Clear();
                        textBoxPackSize.Clear();

                        //Clearing read only  from input
                        textBoxProductId.ReadOnly = true;
                        textBoxProductName.ReadOnly = false;
                        textBoxProductDescription.ReadOnly = false;
                        textBoxUnit.ReadOnly = false;
                        textBoxProductCategoryId.ReadOnly = false;
                        textBoxUnitRate.ReadOnly = false;
                        textBoxPackRate.ReadOnly = false;
                        textBoxPackSize.ReadOnly = false;

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
                        textBoxProductId.Clear();
                        textBoxProductName.Clear();
                        textBoxProductDescription.Clear();
                        textBoxUnit.Clear();
                        textBoxProductCategoryId.Clear();
                        textBoxUnitRate.Clear();
                        textBoxPackRate.Clear();
                        textBoxPackSize.Clear();

                        //Clearing read only  from input
                        textBoxProductId.ReadOnly = true;
                        textBoxProductName.ReadOnly = false;
                        textBoxProductDescription.ReadOnly = false;
                        textBoxUnit.ReadOnly = false;
                        textBoxProductCategoryId.ReadOnly = false;
                        textBoxUnitRate.ReadOnly = false;
                        textBoxPackRate.ReadOnly = false;
                        textBoxPackSize.ReadOnly = false;
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
                        textBoxProductId.Clear();
                        textBoxProductName.Clear();
                        textBoxProductDescription.Clear();
                        textBoxUnit.Clear();
                        textBoxProductCategoryId.Clear();
                        textBoxUnitRate.Clear();
                        textBoxPackSize.Clear();

                        //Clearing read only  from input
                        textBoxProductId.ReadOnly = true;
                        textBoxProductName.ReadOnly = true;
                        textBoxProductDescription.ReadOnly = true;
                        textBoxUnit.ReadOnly = true;
                        textBoxProductCategoryId.ReadOnly = true;
                        textBoxUnitRate.ReadOnly = true;
                        textBoxPackRate.ReadOnly = true;
                        textBoxPackSize.ReadOnly = true;

                    }
                    break;
            }
        }

        private void DGVdataGridView_DoubleClick(object sender, EventArgs e)
        {
            textBoxProductId.Text = DGVdataGridView.CurrentRow.Cells["ProductId"].Value.ToString();
            textBoxProductName.Text = DGVdataGridView.CurrentRow.Cells["ProductName"].Value.ToString();
            textBoxProductDescription.Text = DGVdataGridView.CurrentRow.Cells["ProductDescription"].Value.ToString();
            textBoxUnit.Text = DGVdataGridView.CurrentRow.Cells["Unit"].Value.ToString();
            textBoxProductCategoryId.Text = DGVdataGridView.CurrentRow.Cells["ProductCategoryId"].Value.ToString();
            textBoxUnitRate.Text = DGVdataGridView.CurrentRow.Cells["UnitRate"].Value.ToString();
            textBoxPackRate.Text = DGVdataGridView.CurrentRow.Cells["PackRate"].Value.ToString();
            textBoxPackSize.Text = DGVdataGridView.CurrentRow.Cells["PackSize"].Value.ToString(); 
        }
    }
}
