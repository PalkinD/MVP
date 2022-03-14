using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace labArch
{
    public class DriverMapper : IDriversManager
    {
        protected string _dataBaseName;
        protected SqlCommand command = null;
        public DriverMapper(string dataBaseName)
        {
            _dataBaseName = dataBaseName;
        }
        public void EraseDriver(int licenseNumber)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[_dataBaseName].ConnectionString))
            {
                connection.Open();
                command = new SqlCommand("DELETE FROM Drivers WHERE license_number=" + licenseNumber, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataSet GetDriversTable()
        {
            return GetDataSet("SELECT * FROM Drivers");
        }

        public void InsertDriver(DriverData data)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[_dataBaseName].ConnectionString))
            {
                connection.Open();
                command = new SqlCommand("INSERT INTO Drivers (license_number,full_name,adress,age,sex) VALUES (@license_number,@full_name,@adress,@age,@sex)", connection);
                command.Parameters.AddWithValue("license_number", data.LicenseNumber);
                command.Parameters.AddWithValue("full_name", data.FullName);
                command.Parameters.AddWithValue("adress", data.Adress);
                command.Parameters.AddWithValue("age", data.Age);
                command.Parameters.AddWithValue("sex", data.Sex);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataSet SelectDriver(DriverData data)
        {
            return GetDataSet("SELECT * FROM Drivers WHERE " + GetStringForSelect(data));
        }

        public DataSet SelectDriverByCar(int licensePlate)
        {
            return GetDataSet("SELECT * FROM Drivers WHERE license_plate=" + licensePlate);
        }

        public void UpdateDriver(int licenseNumber, DriverData data)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[_dataBaseName].ConnectionString))
            {
                connection.Open();
                string sql = "UPDATE Drivers SET " + GetStringForUpdate(data) + " WHERE license_number=" + licenseNumber;
                command = new SqlCommand(sql, connection);
                AddWithValue(data);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void AddWithValue(DriverData data)
        {
            if (!string.IsNullOrEmpty(data.FullName)) 
            {
                command.Parameters.AddWithValue("full_name", data.FullName);
            }
            if (!string.IsNullOrEmpty(data.Adress))
            {
                command.Parameters.AddWithValue("adress", data.Adress);
            }
            if (data.Age > 18)
            {
                command.Parameters.AddWithValue("age", data.Age);
            }
            if (data.Sex == SEX.MALE || data.Sex == SEX.FEMALE)
            {
                command.Parameters.AddWithValue("sex", data.Sex);
            }
        }

        private string GetStringForUpdate(DriverData data)
        {
            string result = "";
          
            if (!String.IsNullOrEmpty(data.FullName))
            {
                result += " full_name= \'" + data.FullName + "\'";
            }
            if (!String.IsNullOrEmpty(data.Adress))
            {
                if (!String.IsNullOrEmpty(result))
                {
                    result += ",";
                }
                result += " adress= \'" + data.Adress + "\'";
            }
            if (data.Age > 18)
            {
                if (!String.IsNullOrEmpty(result))
                {
                    result += ",";
                }
                result += " age= " + data.Age;
            }

            if (data.Sex == SEX.MALE || data.Sex == SEX.FEMALE)
            {
                if (!String.IsNullOrEmpty(result))
                {
                    result += ",";
                }
                result += " sex=" + data.Sex;
            }
            return result;
        }

        private DataSet GetDataSet(string sql)
        {
            DataSet dataSet = new DataSet();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[_dataBaseName].ConnectionString))
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataSet);
                connection.Close();
            }
            return dataSet;
        }
        private string GetStringForSelect(DriverData data)
        {
            string result = "";
            if (data.LicenseNumber > 0)
            {
                result += "license_number=" + data.LicenseNumber;
            }
            if (!String.IsNullOrEmpty(data.FullName))
            {
                if (!String.IsNullOrEmpty(result))
                {
                    result += " AND ";
                }
                result += " full_name= \'" + data.FullName+"\'";
            }
            if (!String.IsNullOrEmpty(data.Adress))
            {
                if (!String.IsNullOrEmpty(result))
                {
                    result += " AND ";
                }
                result += "adress= \'" + data.Adress+"\'";
            }
            if (data.Age>18)
            {
                if (!String.IsNullOrEmpty(result))
                {
                    result += " AND ";
                }
                result += "age= " + data.Age;
            }

            if (data.Sex==SEX.MALE||data.Sex==SEX.FEMALE)
            {
                if (!String.IsNullOrEmpty(result))
                {
                    result += " AND ";
                }
                result += "sex=" + data.Sex;
            }
            return result;
        }


    }
}
