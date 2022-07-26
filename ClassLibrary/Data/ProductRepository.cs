using CSharpProject04Data.Common;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CSharpProject04Data.Data
{
    public class ProductRepository
    {
        private static readonly string connString = @"Server = tcp:comp2614.database.windows.net,1433;
                                                Initial Catalog =comp2614;
                                                User ID =student;
                                                Password = iLOVEpho!;
                                                Encrypt =True;
                                                TrustServerCertificate =False;
                                                Connection Timeout =30";

        public static InvoiceDetailCollection GetProducts()
        {
            InvoiceDetailCollection products = new InvoiceDetailCollection();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT * FROM InvoiceDetail ORDER BY Sku ASC";
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        int detailId;
                        int quantity;
                        string sku;
                        string description;
                        decimal price;
                        bool taxable;

                        while (reader.Read())
                        {
                            detailId = (int)reader["DetailId"];
                            quantity = (int)reader["Quantity"];
                            sku = reader["Sku"] as string;

                            if (!reader.IsDBNull(3))
                            {
                                description = reader["Description"] as string;
                            }
                            else
                            {
                                description = null;
                            }

                            price = (decimal)reader["Price"];

                            if (!reader.IsDBNull(reader.GetOrdinal("Taxable")))
                            {
                                taxable = (bool)reader["Taxable"];
                            }
                            else
                            {
                                taxable = true;
                            }

                            products.Add(new Product
                            {
                                DetailId = detailId,
                                Quantity = quantity,
                                Sku = sku,
                                Description = description,
                                Price = price,
                                Taxable = taxable
                            });
                        }
                    }
                }
            }
            return products;
        }

        internal static int UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
