﻿using Pharmacy_Management_System.Presentation_Layer.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management_System.Data_Access_Layer
{
    class UserDataAccess : DataAccess
    {
        public bool UserRegister(User user)
        {
            string sql = "INSERT INTO Users(Name,Username,Email,Password,DateOfBirth,Gender,BloodGroup) VALUES('" + user.Name + "','" + user.Username + "','" + user.Email + "','" + user.Password + "','" + user.DateOfBirth + "','" + user.Gender + "','" + user.BloodGroup + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
            {
                return true;
            }
            return false;
        }

        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                return true;
            }
            return false;
        }
    }
}
