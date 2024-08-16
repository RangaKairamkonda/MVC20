using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MVC20.Models
{
    public class Repository
    {
        public bool Check(string chuname ,string chupwd)
        {
            string k = ConfigurationManager.ConnectionStrings["mvc"].ToString();
            bool flag = false;
            SqlConnection con = new SqlConnection(k);
            con.Open();
            string q = "prc_users";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uname", chuname);
            cmd.Parameters.AddWithValue("@pwd", chupwd);
            flag = Convert.ToBoolean(cmd.ExecuteScalar());
            return flag;
        }
    }
}