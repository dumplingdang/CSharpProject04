using CSharpProject04Data.Common;
using System.Data;
using System.Data.SqlClient;

namespace CSharpProject04Data.Data
{
    public class TaxRateRepository
    {
        private static readonly string connString = @"Server = tcp:comp2614.database.windows.net,1433;
                                                Initial Catalog =comp2614;
                                                User ID =student;
                                                Password = iLOVEpho!;
                                                Encrypt =True;
                                                TrustServerCertificate =False;
                                                Connection Timeout =30";

        public static TaxRateList GetTaxRates()
        {
            TaxRateList rates = new TaxRateList();

            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = @"SELECT * FROM SalesTaxRate";

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Connection = conn;

                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader(0))
                    {
                        int taxId;
                        string taxCode;
                        decimal taxRate;
                        while (reader.Read())
                        {
                            taxId = (int)reader[0];
                            taxCode = reader[1] as string;
                            taxRate = (decimal)reader[2];
                            rates.Add(new SalesTaxRate
                            {
                                TaxId = taxId,
                                TaxCode = taxCode,
                                TaxRate = taxRate
                            });
                        }
                    }
                }
            }
            return rates;
        }
    }
}
