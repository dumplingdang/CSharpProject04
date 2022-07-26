using CSharpProject04Data.Business;
using CSharpProject04Data.Common;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CSharpProject04
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public InvoiceDetailCollection Products { get; set; }
        public ProductViewModel()
        {
            Products = ProductValidation.GetProducts();
            DisplayProduct = new Product();
        }
        private Product displayProduct;
        public Product DisplayProduct
        {
            get
            {
                return displayProduct;
            }
            set
            {
                displayProduct = new Product
                {
                    DetailId = value.DetailId,
                    Quantity = value.Quantity,
                    Sku = value.Sku,
                    Description = value.Description,
                    Price = value.Price,
                    Taxable = value.Taxable
                };
                OnPropertyChanged();
            }
        }

        public decimal Price
        {
            get { return displayProduct.Price; }
            set
            {
                displayProduct.Price = value;
                OnPropertyChanged("DisplayProduct.Extension");
            }
        }
        public int Quantity
        {
            get { return displayProduct.Quantity; }
            set
            {
                displayProduct.Quantity = value;
                OnPropertyChanged("DisplayProduct.Extension");
            }
        }
        public decimal SubTotal { get { return Products.SubTotal; } }
        public decimal Gst { get { return Products.Gst; } }
        public decimal Pst { get { return Products.Pst; } }
        public decimal GrandTotal { get { return Products.GrandTotal; } }
        public decimal AvgPrice { get { return Products.AvgPrice; } }
        public decimal MaxPrice { get { return Products.MaxPrice; } }
        public decimal MinPrice { get { return Products.MinPrice; } }
        public int Count { get { return Products.Count; } }
        public int TaxableCount { get { return Products.TaxableCount; } }
        public int TotalProducts { get { return Products.TotalProducts; } }
        public string MostExpensiveItem { get { return Products.MostExpensiveItem; } }

        public string PrintLiteral
        {
            get
            {
                return string.Format("{0:#,##0.00}\r\n{1:#,##0.00}\r\n{2:#,##0.00}\r\n{3:#,##0.00}\r\n{4}\r\n{5:#,##0.00}\r\n{6:#,##0.00}\r\n{7:#,##0.00}\r\n{8}\r\n{9}\r\n{10}\r\n{11}", SubTotal, Gst, Pst, GrandTotal, "", AvgPrice, MaxPrice, MinPrice, "", Count, TaxableCount, MostExpensiveItem);
            }
        }
    }
}
