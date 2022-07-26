using CSharpProject04Data.Data;
using System.Collections.Generic;
using System.Linq;
namespace CSharpProject04Data.Common
{
    public class InvoiceDetailCollection : List<Product>
    {
        public decimal SubTotal
        {
            get
            {
                decimal subTotal = 0m;
                foreach (Product product in this)
                {
                    subTotal += product.Extension;
                }
                return subTotal;
            }
        }
        private decimal gst = TaxRateRepository.GetTaxRates()[0].TaxRate*0.01m;
        private decimal pst = TaxRateRepository.GetTaxRates()[2].TaxRate*0.01m;

        public decimal Gst => SubTotal * gst;

        public decimal Pst => this.Sum(product => product.Taxable ? product.Extension * pst : 0m);
        public decimal GrandTotal => SubTotal + Gst + Pst;

        public decimal AvgPrice => this.Average(product => product.Price);
        public decimal MaxPrice => this.Max(product => product.Price);
        public decimal MinPrice => this.Min(product => product.Price);
        public int TaxableCount => this.Count(product => product.Taxable);
        public string MostExpensiveItem => this.Where(product => product.Price == MaxPrice).First().Sku;
        public int TotalProducts
        {
            get
            {
                int total = 0;
                foreach (Product product in this)
                {
                    total += product.Quantity;
                }
                return total;
            }
        }
    }
}
