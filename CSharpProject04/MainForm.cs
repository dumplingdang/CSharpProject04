using CSharpProject04Data.Business;
using CSharpProject04Data.Common;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSharpProject04
{
    public partial class MainForm : Form
    {
        private ProductViewModel productVM;
        private BindingSource productSource = new BindingSource();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                productVM = new ProductViewModel();
                setBindings();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void setBindings()
        {
            productSource.DataSource = productVM.Products;
            listBoxProduct.DataSource = productSource;

            listBoxProduct.DisplayMember = "Sku";

            textBoxQuantity.DataBindings.Add("Text", productVM, "DisplayProduct.Quantity", true, DataSourceUpdateMode.OnPropertyChanged);

            textBoxSku.DataBindings.Add("Text", productVM, "DisplayProduct.Sku", true, DataSourceUpdateMode.OnPropertyChanged);

            textBoxDescription.DataBindings.Add("Text", productVM, "DisplayProduct.Description", true, DataSourceUpdateMode.OnPropertyChanged);

            textBoxPrice.DataBindings.Add("Text", productVM, "DisplayProduct.Price", true, DataSourceUpdateMode.OnPropertyChanged);

            textBoxExtended.DataBindings.Add("Text", productVM, "DisplayProduct.Extension", true, DataSourceUpdateMode.OnPropertyChanged);

            labelProductLegend.Text = String.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}\r\n{5}\r\n{6}\r\n{7}\r\n{8}\r\n{9}\r\n{10}\r\n{11}", "Sub Total:", "GST:", "PST:", "Grand Total:", "", "Average Price:", "Maximum Price:", "Minimum Price:", "", "Item Count:", "Taxable Count:", "Most Expensive Item:");

            labelDisplayData.DataBindings.Add("Text", productVM, "PrintLiteral", true, DataSourceUpdateMode.OnPropertyChanged);

            checkBoxTaxable.DataBindings.Add("Checked", productVM, "DisplayProduct.Taxable", true, DataSourceUpdateMode.OnPropertyChanged);

            labelTotalProductResult.DataBindings.Add("Text", productVM, "TotalProducts", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void listBoxInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = Math.Max(0, listBoxProduct.SelectedIndex);
            Product product = productVM.Products[selectedIndex];
            productVM.DisplayProduct = product;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = productVM.DisplayProduct;
                int selectedIndex = listBoxProduct.SelectedIndex;
                if (!ProductValidation.Validate(product))
                {
                    errorProvider.SetError(buttonSave, ProductValidation.ErrorMessage);
                }
                else
                {
                    productVM.Products[selectedIndex] = product;
                    string literal = productVM.PrintLiteral;
                    labelDisplayData.DataBindings.Clear();
                    labelDisplayData.DataBindings.Add("Text", productVM, "PrintLiteral", true, DataSourceUpdateMode.OnPropertyChanged);
                    refreshListBox();
                    errorProvider.SetError(buttonSave, string.Empty);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Processing Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void refreshListBox()
        {
            listBoxProduct.DataSource = productVM.Products;
        }
    }
}
