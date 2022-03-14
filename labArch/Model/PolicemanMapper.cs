using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace labArch
{
    class PolicemanMapper:ILoginModel,IRegistrationModel
    {
        protected string _dataBaseName;
        protected SqlCommand command = null;
        public PolicemanMapper(string dataBaseName)
        {
            _dataBaseName = dataBaseName;
        }
       public void Insert(Policeman policeman,string password)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[_dataBaseName].ConnectionString))
            {
                connection.Open();
                command = new SqlCommand("INSERT INTO Policemen (id_token,password,full_name,rank,position) VALUES (@id_token,@password,@full_name,@rank,@position)", connection);
                command.Parameters.AddWithValue("id_token", policeman.IdToken);
                command.Parameters.AddWithValue("password", password);
                command.Parameters.AddWithValue("full_name", policeman.FullName);
                command.Parameters.AddWithValue("rank", policeman.Rank);
                command.Parameters.AddWithValue("position", policeman.Position);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
      public  void erase (Policeman policeman)
        {

        }
      public  void update (Policeman policeman)
        {

        }
       public Policeman Select(int idToken,string password)
        {
             string fullname = "", rank = "", position = "";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[_dataBaseName].ConnectionString))
            {
                connection.Open();
                command = new SqlCommand("SELECT password,full_name,rank,position FROM Policemen WHERE id_token = \'" + idToken  + "\'", connection);
                SqlDataReader reader = null;
               
                    reader = command.ExecuteReader();
                if (reader.Read()){
                    string realPassword = reader["password"].ToString();
                    if (password.CompareTo(realPassword)!=0){
                            throw new Exception("Пароли не совпадают");
                        }
                        fullname = reader["full_name"].ToString();
                        rank = reader["rank"].ToString();
                        position = reader["position"].ToString();
                }
                else
                {
                    throw new Exception("Нет такого пользователя");
                }
                    if (reader != null)
                    {
                        reader.Close();
                    }
                    connection.Close();
            }
            return new Policeman(idToken,fullname,rank,position);
        }
    }
}
