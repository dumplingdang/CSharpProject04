using CSharpProject04Data.Common;
using CSharpProject04Data.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CSharpProject04Data.Business
{
    public class ProductValidation
    {
        public static InvoiceDetailCollection GetProducts() => ProductRepository.GetProducts();
        private static List<string> errors = new List<string>();

        public static string ErrorMessage
        {
            get
            {
                string message = "";
                List<string> errorsNoDuplicate = errors.Distinct().ToList();
                foreach (string error in errorsNoDuplicate)
                {
                    message += error + "\r\n";
                }
                return message;
            }
        }

        public static bool Validate(Product product)
        {
            string regExSku = @"^[A-Z]{3}\d{4}$";
            if (string.IsNullOrWhiteSpace(product.Sku))
            {
                errors.Add("Sku must not be empty");
            }
            else
            {
                errors.RemoveAll(error => error.Equals("Sku must not be empty"));
            }
            if (!Regex.IsMatch(product.Sku, regExSku))
            {
                errors.Add("Sku must be in format LLL0000");
            }
            else
            {
                errors.RemoveAll(error => error.Equals("Sku must be in format LLL0000"));
            }
            if (product.Price <= 0)
            {
                errors.Add("Price is required and must be positive");
            }
            else
            {
                errors.RemoveAll(error => error.Equals("Price is required and must be positive"));
            }
            int? quantity = product.Quantity;
            if (!quantity.HasValue)
            {
                errors.Add("Quantity is required");
            }
            if (product.Quantity <= 0)
            {
                errors.Add("Quantity must be positive");
            }
            else
            {
                errors.RemoveAll(error => error.Equals("Quantity must be positive"));
            }
            return errors.Count == 0;

        }
    }
}
