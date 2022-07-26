
namespace CSharpProject04
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxProduct = new System.Windows.Forms.ListBox();
            this.labelProductList = new System.Windows.Forms.Label();
            this.labelTotalProduct = new System.Windows.Forms.Label();
            this.labelTotalProductResult = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelSku = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelExtended = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxExtended = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxSku = new System.Windows.Forms.TextBox();
            this.checkBoxTaxable = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelProductLegend = new System.Windows.Forms.Label();
            this.labelDisplayData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxProduct
            // 
            this.listBoxProduct.FormattingEnabled = true;
            this.listBoxProduct.Location = new System.Drawing.Point(21, 48);
            this.listBoxProduct.Name = "listBoxProduct";
            this.listBoxProduct.Size = new System.Drawing.Size(161, 251);
            this.listBoxProduct.TabIndex = 0;
            this.listBoxProduct.SelectedIndexChanged += new System.EventHandler(this.listBoxInvoice_SelectedIndexChanged);
            // 
            // labelProductList
            // 
            this.labelProductList.AutoSize = true;
            this.labelProductList.Location = new System.Drawing.Point(21, 22);
            this.labelProductList.Name = "labelProductList";
            this.labelProductList.Size = new System.Drawing.Size(47, 13);
            this.labelProductList.TabIndex = 1;
            this.labelProductList.Text = "Product:";
            // 
            // labelTotalProduct
            // 
            this.labelTotalProduct.AutoSize = true;
            this.labelTotalProduct.Location = new System.Drawing.Point(21, 317);
            this.labelTotalProduct.Name = "labelTotalProduct";
            this.labelTotalProduct.Size = new System.Drawing.Size(79, 13);
            this.labelTotalProduct.TabIndex = 2;
            this.labelTotalProduct.Text = "Total Products:";
            // 
            // labelTotalProductResult
            // 
            this.labelTotalProductResult.AutoSize = true;
            this.labelTotalProductResult.Location = new System.Drawing.Point(106, 317);
            this.labelTotalProductResult.Name = "labelTotalProductResult";
            this.labelTotalProductResult.Size = new System.Drawing.Size(114, 13);
            this.labelTotalProductResult.TabIndex = 3;
            this.labelTotalProductResult.Text = "<DisplayTotalProduct>";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(231, 70);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(49, 13);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "Quantity:";
            // 
            // labelSku
            // 
            this.labelSku.AutoSize = true;
            this.labelSku.Location = new System.Drawing.Point(231, 108);
            this.labelSku.Name = "labelSku";
            this.labelSku.Size = new System.Drawing.Size(29, 13);
            this.labelSku.TabIndex = 6;
            this.labelSku.Text = "Sku:";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(231, 146);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "Description:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(231, 184);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(34, 13);
            this.labelPrice.TabIndex = 10;
            this.labelPrice.Text = "Price:";
            // 
            // labelExtended
            // 
            this.labelExtended.AutoSize = true;
            this.labelExtended.Location = new System.Drawing.Point(231, 222);
            this.labelExtended.Name = "labelExtended";
            this.labelExtended.Size = new System.Drawing.Size(55, 13);
            this.labelExtended.TabIndex = 12;
            this.labelExtended.Text = "Extended:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(318, 67);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 5;
            // 
            // textBoxExtended
            // 
            this.textBoxExtended.Enabled = false;
            this.textBoxExtended.Location = new System.Drawing.Point(318, 219);
            this.textBoxExtended.Name = "textBoxExtended";
            this.textBoxExtended.Size = new System.Drawing.Size(100, 20);
            this.textBoxExtended.TabIndex = 13;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(318, 181);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 11;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(318, 143);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(200, 20);
            this.textBoxDescription.TabIndex = 9;
            // 
            // textBoxSku
            // 
            this.textBoxSku.Location = new System.Drawing.Point(318, 105);
            this.textBoxSku.Name = "textBoxSku";
            this.textBoxSku.Size = new System.Drawing.Size(100, 20);
            this.textBoxSku.TabIndex = 7;
            // 
            // checkBoxTaxable
            // 
            this.checkBoxTaxable.AutoSize = true;
            this.checkBoxTaxable.Location = new System.Drawing.Point(234, 274);
            this.checkBoxTaxable.Name = "checkBoxTaxable";
            this.checkBoxTaxable.Size = new System.Drawing.Size(64, 17);
            this.checkBoxTaxable.TabIndex = 14;
            this.checkBoxTaxable.Text = "Taxable";
            this.checkBoxTaxable.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(443, 276);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 38;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // labelProductLegend
            // 
            this.labelProductLegend.Location = new System.Drawing.Point(596, 67);
            this.labelProductLegend.Name = "labelProductLegend";
            this.labelProductLegend.Size = new System.Drawing.Size(130, 188);
            this.labelProductLegend.TabIndex = 39;
            this.labelProductLegend.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n10\r\n11\r\n12";
            // 
            // labelDisplayData
            // 
            this.labelDisplayData.Location = new System.Drawing.Point(732, 67);
            this.labelDisplayData.Name = "labelDisplayData";
            this.labelDisplayData.Size = new System.Drawing.Size(100, 188);
            this.labelDisplayData.TabIndex = 40;
            this.labelDisplayData.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n10\r\n11\r\n12";
            this.labelDisplayData.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 381);
            this.Controls.Add(this.labelDisplayData);
            this.Controls.Add(this.labelProductLegend);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxTaxable);
            this.Controls.Add(this.textBoxSku);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxExtended);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelExtended);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelSku);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.labelTotalProductResult);
            this.Controls.Add(this.labelTotalProduct);
            this.Controls.Add(this.labelProductList);
            this.Controls.Add(this.listBoxProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(904, 420);
            this.Name = "MainForm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProduct;
        private System.Windows.Forms.Label labelProductList;
        private System.Windows.Forms.Label labelTotalProduct;
        private System.Windows.Forms.Label labelTotalProductResult;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelSku;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelExtended;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxExtended;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxSku;
        private System.Windows.Forms.CheckBox checkBoxTaxable;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelProductLegend;
        private System.Windows.Forms.Label labelDisplayData;
    }
}
