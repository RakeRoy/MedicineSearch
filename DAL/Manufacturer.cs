using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Manufacturer
    {
        /*
        string connectionString = @"Server=DESKTOP-PKSIHBM\SQLEXPRESS;Database=Medicine Search;Trusted_Connection=true;";
        SqlConnection Conn;  // Conn = Connection
        SqlCommand command;
        DataTable dt;
        public int GetMaxID()
        {
            int MaxID;
            string vQuery = "Select isnull(max(Manufacturer_ID),0)+1 as Manufacturer_ID From Manufacturer";
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            try
            {
                Conn.Open();
                MaxID = Convert.ToInt32(command.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return MaxID;
        }

        public int InsertData(Objects.Manufacturer manufacturer)
        {
            int vCheck;
            string vQuery = "Insert into Manufacturer(Manufacturer_ID, Manufacturer) " +
                "Values ('" + manufacturer.ManufacturerID+ "','" + manufacturer.ManufacturerName+ "')";
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            try
            {
                Conn.Open();
                vCheck = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return vCheck;
        }
        */
    }
}
