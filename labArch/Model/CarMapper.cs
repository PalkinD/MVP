using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace labArch
{
    public class CarMapper:ICarsManager
    {
        protected string _dataBaseName;
        protected SqlCommand command = null;
        public CarMapper(string dataBaseName)
        {
            _dataBaseName = dataBaseName;
        }

        public void EraseCar(int licensePlate)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[_dataBaseName].ConnectionString))
            {
                connection.Open();
                command = new SqlCommand("DELETE FROM Cars WHERE license_plate=" + licensePlate, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataSet GetCarsTable()
        {
            return GetDataSet("SELECT * FROM Cars");
        }

        public void InsertCar(CarData data)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[_dataBaseName].ConnectionString))
            {
                connection.Open();
                command = new SqlCommand("INSERT INTO Cars (license_plate,engine_number,color_code,license_number) VALUES (@license_plate,@engine_number,@color_code,@license_number)", connection);
                command.Parameters.AddWithValue("license_plate",data.LicensePlate);
                command.Parameters.AddWithValue("engine_number", data.EngineNumber);
                command.Parameters.AddWithValue("color_code", data.ColorCode);
                command.Parameters.AddWithValue("license_number", data.LicenseNumber);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataSet SelectCar(CarData data)
        {
            return GetDataSet("SELECT * FROM Cars WHERE "+GetStringForSelect(data));
        }

        public DataSet SelectCarsByDriver(int licenseNumber)
        {
            return GetDataSet("SELECT * FROM Cars WHERE license_number=" + licenseNumber);
        }

        public void UpdateCar(int licensePlate, CarData data)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[_dataBaseName].ConnectionString))
            {
                connection.Open();
                command = new SqlCommand("UPDATE Cars SET "+GetStringForUpdate(data)+" WHERE license_plate="+licensePlate, connection);
                AddWithValue(licensePlate, data);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private string GetStringForUpdate(CarData data)
        {
            string result = "";
            if (data.EngineNumber > 0)
            {
                result += " engine_number=@engine_number";
            }
            if (data.ColorCode > 0)
            {
                if (!String.IsNullOrEmpty(result))
                {
                    result += ",";
                }
                result += " color_code=@color_code";
            }
            if (data.LicenseNumber > 0)
            {
                if (!String.IsNullOrEmpty(result))
                {
                    result += ",";
                }
                result += " license_number=@license_number";
            }
            return result;
        }
        private string GetStringForSelect(CarData data)
        {
            string result = "";
            if (data.LicensePlate > 0)
            {
                result += "license_plate=" + data.LicensePlate;
            }
            if (data.EngineNumber > 0)
            {
                if (!String.IsNullOrEmpty(result))
                {
                    result += " AND ";
                }
                result += " engine_number="+data.EngineNumber;
            }
            if (data.ColorCode > 0)
            {
                if (!String.IsNullOrEmpty(result))
                {
                    result += " AND ";
                }
                result += " color_code="+data.ColorCode;
            }
            if (data.LicenseNumber > 0)
            {
                if (!String.IsNullOrEmpty(result))
                {
                    result += " AND ";
                }
                result += " license_number="+data.LicenseNumber;
            }
            return result;
        }
       private void AddWithValue(int licensePlate,CarData data)
        {
            if (licensePlate > 0)
            {
                command.Parameters.AddWithValue("license_plate", licensePlate);
            }
            if (data.EngineNumber > 0)
            {
                command.Parameters.AddWithValue("engine_number", data.EngineNumber);
            }
            if (data.ColorCode > 0)
            {
                command.Parameters.AddWithValue("color_code", data.ColorCode);
            }
            if (data.LicenseNumber > 0)
            {
                command.Parameters.AddWithValue("license_number", data.LicenseNumber);
            }
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
    }
}
