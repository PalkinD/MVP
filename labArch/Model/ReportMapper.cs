using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;


namespace labArch
{
    public class ReportMapper : IReportModel
    {
        protected string _dataBaseName;
        protected SqlCommand command = null;
        public ReportMapper(string dataBaseName)
        {
            _dataBaseName = dataBaseName;
        }
        public void Insert(ReportData report)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[_dataBaseName].ConnectionString))
            {
                connection.Open();
                command = new SqlCommand("INSERT INTO Inspections (date,report,result,id_token,license_plate) VALUES (@date,@report,@result,@id_token,@license_plate)", connection);
                command.Parameters.AddWithValue("date", report.ReportDate);
                command.Parameters.AddWithValue("report", report.ReportText);
                command.Parameters.AddWithValue("result", report.ReportResult);
                command.Parameters.AddWithValue("id_token", report.IdToken);
                command.Parameters.AddWithValue("license_plate", report.LicensePlate);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        public bool IsAllowedToMakeReport(int idToken, DateTime date)
        {
            int numberOfReports;
            bool result;
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings[_dataBaseName].ConnectionString))
            {
                connection.Open();
                command = new SqlCommand("SELECT count(*) AS \'Number of reports\' FROM Inspections WHERE id_token="+idToken+" AND date=\'"+date.ToShortDateString()+"\'", connection);
                SqlDataReader reader = null;

                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    string temp = reader["Number of reports"].ToString();
                    numberOfReports = Convert.ToInt32(reader["Number of reports"].ToString());
                    if (numberOfReports > 10)
                    {
                        result= false;
                    }
                    result= true;
                }
                else
                {
                    result=true;
                }
                if (reader != null)
                {
                    reader.Close();
                }
                connection.Close();
            }
            return result;
        }
    }
   }

