using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objects;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace DAL
{
    public class User
    {
        SqlConnection con;
        DataSet dataSet;
        SqlDataAdapter adapter;

        string connectionString = @"Server=DESKTOP-PKSIHBM\SQLEXPRESS;Database=Medicine Search;Trusted_Connection=true;";

        public int ULogin(Objects.User obj)
        {
            /*
            int vcheck;
            string Email = obj.Email;
            string Password = obj.Password;
            string vQuery = "select UserID from UserData where Email='" + obj.Email + "' and Password='" + obj.Password + "'";
            con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(vQuery, con);
            try
            {
                con.Open();
                vcheck = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }

            */

            //cmd.CommandType = CommandType.Text;
            //return vcheck;

            int vcheck;
            SqlConnection con = new SqlConnection(connectionString);
            string VQuery = "SELECT COUNT(*) from UserData where Email = '" + obj.Email + "' and Password = '" + obj.Password + "'";
            SqlCommand cmd = new SqlCommand(VQuery, con);
            try
            {
                con.Open();
                vcheck = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return vcheck;
        }

        public int GetMaxID()
        {
            int MaxID;
            string vQuery = "Select ISNULL(max(UserID),0)+1 as UserID From UserData";
            SqlConnection Conn = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(vQuery, Conn);
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

        public int URegistration(Objects.User obj)
        {
            int vcheck;
            SqlConnection con = new SqlConnection(connectionString);
            string VQuery = "Insert Into UserData(UserID,FirstName,LastName,Email,Address,Password,Country) " +
                "values (" + GetMaxID() + ",'" + obj.FirstName + "','" + obj.LastName + "','" + obj.Email + "','"
                + obj.Address + "','" + obj.Password + "','" + obj.Country + "')";
            SqlCommand cmd = new SqlCommand(VQuery, con);
            cmd.CommandType = CommandType.Text;
            try
            {
                con.Open();
                vcheck = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return vcheck;





        }
    }
}
