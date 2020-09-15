using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{

    public class Formula
    {
        /*
        string connectionString = @"Server=DESKTOP-PKSIHBM\SQLEXPRESS;Database=Medicine Search;Trusted_Connection=true;";
        SqlConnection Conn;  // Conn = Connection
        SqlCommand command;
        DataTable dt;
        public int GetMaxID()
        {
            int MaxID;
            string vQuery = "Select isnull(max(Formula_ID),0)+1 as Formula_ID From Formula";
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

        public int InsertData(Objects.Formula formula)
        {
            int vCheck;
            string vQuery = "Insert into Formula(Formula_ID, Formula) " +
                "Values ('" + formula.FormulaID + "','" + formula.FormulaName+ "')";
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
