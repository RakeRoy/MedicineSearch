using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Medicine
    {
        string connectionString = @"Server=DESKTOP-PKSIHBM\SQLEXPRESS;Database=Medicine Search;Trusted_Connection=true;";
        SqlConnection Conn;  // Conn = Connection
        SqlCommand command;
        DataTable dt;
        SqlDataAdapter adapter;
        DataSet ds;
        

        public DataTable formload(Objects.Medicine med)
        {
             string vQuery = "Select Medicine_Name, Expiry_Time, Formula, Manufacturer, Quantity, Price, " +
                "Type.Type, Symptom.Symptom From Medicine INNER JOIN Type ON Type.Type_ID = Medicine.Type_ID " +
                "INNER JOIN Symptom ON Symptom.Symptom_ID = Medicine.Symptom_ID";

            dt = new DataTable();
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            med = new Objects.Medicine();
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

        public DataTable formloadFormula (Objects.Medicine med, string formula)
        {
            string vQuery = "Select Medicine_Name, Expiry_Time, Formula, Manufacturer, Quantity, Price, " +
               "Type.Type, Symptom.Symptom From Medicine INNER JOIN Type ON Type.Type_ID = Medicine.Type_ID " +
               "INNER JOIN Symptom ON Symptom.Symptom_ID = Medicine.Symptom_ID where Formula LIKE '%"+ formula + "%'";


            dt = new DataTable();
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            med = new Objects.Medicine();
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


        public DataTable formloadName(Objects.Medicine med, string name)
        {
            string vQuery = "Select Medicine_Name, Expiry_Time, Formula, Manufacturer, Quantity, Price," +
               "Type.Type, Symptom.Symptom From Medicine INNER JOIN Type ON Type.Type_ID = Medicine.Type_ID " +
               "INNER JOIN Symptom ON Symptom.Symptom_ID = Medicine.Symptom_ID where Medicine_Name LIKE '%" + name + "%'";


            dt = new DataTable();
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            med = new Objects.Medicine();
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


        public DataTable formloadManufacturer(Objects.Medicine med, string manufacturer)
        {
            string vQuery = "Select Medicine_Name, Expiry_Time, Formula, Manufacturer, Quantity, Price," +
               "Type.Type, Symptom.Symptom From Medicine INNER JOIN Type ON Type.Type_ID = Medicine.Type_ID " +
               "INNER JOIN Symptom ON Symptom.Symptom_ID = Medicine.Symptom_ID where Manufacturer LIKE '%" + manufacturer + "%'";


            dt = new DataTable();
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            med = new Objects.Medicine();
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


        public DataTable formloadSymptom(Objects.Medicine med, string symptom)
        {
            string vQuery = "Select Medicine_Name, Expiry_Time, Formula, Manufacturer, Quantity, Price," +
               "Type.Type, Symptom.Symptom From Medicine INNER JOIN Type ON Type.Type_ID = Medicine.Type_ID " +
               "INNER JOIN Symptom ON Symptom.Symptom_ID = Medicine.Symptom_ID where Symptom LIKE '%" + symptom + "%'";



            dt = new DataTable();
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            med = new Objects.Medicine();
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




        public int GetMaxID()
        {
            int MaxID;
            string vQuery = "Select isnull(max(Med_ID),0)+1 as MedID From Medicine";
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            try
            {
                Conn.Open();
                MaxID = Convert.ToInt32(command.ExecuteScalar().ToString());
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return MaxID;
        }



        public int InsertData(Objects.Medicine med)
        {
           int vCheck;
            string vQuery = "Insert into Medicine(Med_ID,Medicine_Name,Expiry_Time,Formula ,Manufacturer ,Type_ID,Symptom_ID, Quantity, Price) " +
                "Values ('" + GetMaxID() + "','" + med.MedName + "','" + med.ExpTime + "','" + med.Formula + "','"
                + med.Manufacturer + "'," + med.TypeID + "," + med.SymptomID + "," + med.Quantity + "," + med.Price + ")";                           
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



        //Gets The ID of Type from database

        public int GetTypeID(string Type)
        {
            int IDType;
            string vQuery = "Select Type_ID from Type where Type = '" + Type + "'";
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);


            try
            {
                Conn.Open();
                IDType =  Convert.ToInt32(command.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return IDType;

        }



        public DataTable GetTypeData()
        {
            string vQuery = "Select * From Type";
            DataTable dt = new DataTable();
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { Conn.Close(); }
            return dt;
        }

        public int GetUseID(string Symptom)
        {
            int IDType;
            string vQuery = "Select Symptom_ID from Symptom where Symptom = '" + Symptom + "'";
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            try
            {
                Conn.Open();
                IDType = Convert.ToInt32(command.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conn.Close();
            }
            return IDType;
        }

        public DataTable GetUseData()
        {
            string vQuery = "Select * From Symptom";
            DataTable dt = new DataTable();
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { Conn.Close(); }
            return dt;
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
            return price;
        }

        public Objects.Medicine getRow(string Medicine)
        {
            Objects.Medicine med = new Objects.Medicine();

            string vQuery = "Select * from Medicine WHERE Medicine_Name = '" + Medicine + "'";
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            SqlDataReader dr;
            try
            {
                Conn.Open();
                dr = command.ExecuteReader();
                if(dr.Read())
                { 
                    med.MedID = Convert.ToInt32(dr["Med_ID"].ToString());
                    med.MedName = dr["Medicine_Name"].ToString();
                    med.ExpTime = dr["Expiry_Time"].ToString();
                    med.Formula = dr["Formula"].ToString();
                    med.Manufacturer = dr["Manufacturer"].ToString();
                    med.Quantity = Convert.ToInt32(dr["Quantity"].ToString());
                    med.Price = Convert.ToInt32(dr["Price"].ToString());
                    med.TypeID = Convert.ToInt32(dr["Type_ID"].ToString());
                    med.SymptomID = Convert.ToInt32(dr["Symptom_ID"].ToString());
                    
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {

                Conn.Close();
            }

            return med;
        }

        public void BuyMedicine(string MedicineName, int Quantity)
        {
            
            string vQuery = "UPDATE Medicine SET Quantity = Quantity - " + Quantity + " WHERE Medicine_Name = '" + MedicineName + "'";
            Conn = new SqlConnection(connectionString);
            command = new SqlCommand(vQuery, Conn);
            try
            {
                Conn.Open();
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                Conn.Close();
            }

            DAL.Record RecObj = new DAL.Record();
            RecObj.InsertRecord(MedicineName, Quantity);
            return;

        }

        public int UpdateData(Objects.Medicine med)
        {
            int vCheck;
//            string vQuery = "Insert into Medicine(Med_ID,Medicine_Name,Expiry_Time,Formula ,Manufacturer ,Type_ID,Symptom_ID, Quantity, Price) " +
//              "Values ('" + GetMaxID() + "','" + med.MedName + "','" + med.ExpTime + "','" + med.Formula + "','"
//            + med.Manufacturer + "'," + med.TypeID + "," + med.SymptomID + "," + med.Quantity + "," + med.Price + ")";

            string vQuery = "UPDATE Medicine SET Medicine_Name = '" + med.MedName + "', Expiry_Time = '" + med.ExpTime + "', Formula = '" + med.Formula +
                "', Manufacturer = '" + med.Manufacturer + "', Type_ID = " + med.TypeID + ", Symptom_ID = " + med.SymptomID + ", Quantity = " + med.Quantity +
                ", Price = " + med.Price + " WHERE Medicine_Name = '" + med.MedName + "'";
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

        public int DeleteData(string Medicine)
        {
            int vCheck;
            string vQuery = "Delete FROM Medicine Where Medicine_Name = '" + Medicine + "'";
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

    }
}
