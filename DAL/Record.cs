using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Record
    {
        string connectionString = @"Server=DESKTOP-PKSIHBM\SQLEXPRESS;Database=Medicine Search;Trusted_Connection=true;";
        SqlConnection Conn;  // Conn = Connection
        SqlCommand command;
        DataTable dt;
        SqlDataAdapter adapter;
        DataSet ds;
    
        public int GetMaxID()
        {
            int MaxID;
            string vQuery = "Select isnull(max(RecordID),0)+1 as RecordID From Record";
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

        public int InsertRecord(string MedicineName, int Quantity)
        {
            DateTime dateTime = DateTime.Now;
            int vCheck;
            string vQuery = "Insert into Record(RecordID,Item,Quantity,Price,Date) " +
                "Values (" + GetMaxID() + ",'" + MedicineName + "'," + Quantity + ","
                + getPrice(MedicineName, Quantity) + ",'" + dateTime + "')";
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

        public int getPrice(string MedicineName, int Quantity)
        {
            int price;
            string vQuery = "Select Price from Medicine where Medicine_Name = '" + MedicineName + "'";
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            try
            {
                Conn.Open();
                price = Convert.ToInt32(command.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return price*Quantity;
        }

        public DataTable formload()
        {
            string vQuery = "Select * From Record";

            dt = new DataTable();
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            try
            {
                Conn.Open();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return dt;


        }

        public DataTable SerachByName(string Medicine)
        {
            string vQuery = "Select * From Record Where Item LIKE '%" + Medicine + "%'";

            dt = new DataTable();
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            try
            {
                Conn.Open();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                Conn.Close();
            }

            return dt;
        }

        public DataTable SerachByDate(DateTime dateTime)
        {
            String.Format("{0:u}", dateTime);
            string vQuery = "Select * From Record Where Date Between '" + dateTime.Date+ " 00:00:00' and '"+dateTime.Date+" 23:59:59'";

            vQuery = "Select * FROM Record Where Date Between @DateTime and @DateTime 23:59:59";
            command.Parameters.Add("@DateTime", SqlDbType.Date).Value = dateTime.Date;


            dt = new DataTable();
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            try
            {
                Conn.Open();
                adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                Conn.Close();
            }

            return dt;
        }
    }

}
