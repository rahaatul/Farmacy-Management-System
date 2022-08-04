using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.Presentation_Layer.Data_Access_Layer
{
    class DataAccess
    {
            protected SqlConnection connection;
            protected SqlCommand command;
            public DataAccess()
            {
                this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Pharmacy"].ConnectionString);
                this.connection.Open();
            }

            public SqlDataReader GetData(string sql)
            {
                this.command = new SqlCommand(sql, connection);
                return this.command.ExecuteReader();
            }

            public int ExecuteQuery(string sql)
            {
                this.command = new SqlCommand(sql, connection);
                return this.command.ExecuteNonQuery();
            }

            public void Dispose()
            {
                this.connection.Close();
            }

            ~DataAccess()
            {
                this.connection.Close();
            }
        }
}
