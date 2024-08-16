using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MVC20.Models
{
    public class Repository1
    {
        public void Reg(register reg)
        {
            string k = ConfigurationManager.ConnectionStrings["mvc"].ToString();
            SqlConnection con = new SqlConnection(k);
            con.Open();
            string q = "prc_reg_add";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@uid", reg.id);
            cmd.Parameters.AddWithValue("@uname", reg.uname);
            cmd.Parameters.AddWithValue("@pwd", reg.pwd);
            cmd.Parameters.AddWithValue("@cpwd", reg.cpwd);
            cmd.Parameters.AddWithValue("@email", reg.email);
            cmd.Parameters.AddWithValue("@phone", reg.phone);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}