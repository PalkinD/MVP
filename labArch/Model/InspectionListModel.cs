using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace labArch
{
    public class InspectionListModel : IInspectionsListModel
    {
        protected string _dataBaseName;
        protected SqlCommand command = null;
        public InspectionListModel(string dataBaseName)
        {
            _dataBaseName = dataBaseName;
        }
        public DataSet GetTable(int idToken)
        {
            return GetDataSet("SELECT * FROM Inspections WHERE id_token="+idToken);
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
