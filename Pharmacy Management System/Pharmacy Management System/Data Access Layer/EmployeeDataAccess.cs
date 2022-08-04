using Pharmacy_Management_System.Presentation_Layer.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.Data_Access_Layer
{
    class EmployeeDataAccess : DataAccess
    {
        private object employees;

        public List<Employee> GetAllEmployees()
        {
            string sql = "SELECT * FROM Employees_1";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> employees = new List<Employee>();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee.EmployeeId = (int)reader["EmployeeId"];
                employee.EmployeeName = reader["EmployeeName"].ToString();
                employees.Add(employee);
            }
            return employees;
        }
        public bool LoginValidation(string name, string email)
        {
            string sql = "SELECT * FROM Employees_1 WHERE EmployeeName='" + name + "' AND Password='" + email + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return true;
            }
            return false;
        }
    }
}
