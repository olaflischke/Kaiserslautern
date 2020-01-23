using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoricalRatesDal
{
    public class Currency
    {
        //public Currency(int id)
        //{
        //    try
        //    {
        //        using (SqlConnection connection = new SqlConnection())
        //        {
        //            connection.ConnectionString = Properties.Settings.Default.ArchiveDb;
        //            connection.Open();

        //            SqlCommand command = new SqlCommand()
        //            {
        //                Connection = connection,
        //                CommandText = "SELECT * FROM Currency WHERE id = @Id"
        //            };

        //            SqlParameter parId = new SqlParameter("@Id", id);
        //            command.Parameters.Add(parId);

        //            SqlDataReader reader = command.ExecuteReader();

        //            if (reader.Read())
        //            {
        //                this.EuroValue = Convert.ToDouble(reader["Value"]);
        //                this.Symbol = reader["Symbol"].ToString();
        //                this.Id = id;
        //            }

        //        }


        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}

        public string Symbol { get; set; }
        public double EuroValue { get; set; }

        public int Id { get; set; }

        public TradingDay Day { get; set; }
    }
}
