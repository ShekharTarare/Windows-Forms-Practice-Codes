using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManagement
{
    class Database_code
    {
        private static string s = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UserManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static SqlConnection con = new SqlConnection(s);

        public void GetAllUsers(DataGridView dataGridView)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Get_All_Users", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView.DataSource = dataTable;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddUser(string name, string phone, Int16 age, Int16 gender, Int16 status)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Insert_User", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@phone", phone);
                sqlCommand.Parameters.AddWithValue("@gender", gender);
                sqlCommand.Parameters.AddWithValue("@age", age);
                sqlCommand.Parameters.AddWithValue("@status", status);
                con.Open();
                int numberOfRecordsInserted = sqlCommand.ExecuteNonQuery();
                if(numberOfRecordsInserted > 0)
                {
                    MessageBox.Show(name + " added successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public string[] GetUserById(int id)
        {
            string[] userData = new string[5];
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Get_User_By_Id", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader dr = sqlCommand.ExecuteReader();
                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        userData[0] = dr["Name"].ToString();
                        userData[1] = dr["Phone"].ToString();
                        userData[2] = dr["Age"].ToString();
                        userData[3] = dr["Gender"].ToString();
                        userData[4] = dr["Status"].ToString();
                    }
                }
                else
                    MessageBox.Show("No data found");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return userData;
        }

        public void UpdateUser(int id, string name, string phone, Int16 age, Int16 gender, Int16 status)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Update_User", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.Parameters.AddWithValue("@name", name);
                sqlCommand.Parameters.AddWithValue("@phone", phone);
                sqlCommand.Parameters.AddWithValue("@gender", gender);
                sqlCommand.Parameters.AddWithValue("@age", age);
                sqlCommand.Parameters.AddWithValue("@status", status);
                con.Open();
                int numberOfRecordsInserted = sqlCommand.ExecuteNonQuery();
                if (numberOfRecordsInserted > 0)
                {
                    MessageBox.Show(name + " updated successfully!");
                }
                else
                    MessageBox.Show("User data not exist!");                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("Delete_User", con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", id);
                con.Open();
                int numberOfRecordsInserted = sqlCommand.ExecuteNonQuery();
                if (numberOfRecordsInserted > 0)
                {
                    MessageBox.Show("Data deleted successfully!");
                }
                else
                    MessageBox.Show("User data not exist!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
