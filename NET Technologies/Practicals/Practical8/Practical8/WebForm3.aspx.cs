﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Practical8
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String sql = "DELETE FROM STUDENT WHERE SAPID = " + TextBox1.Text + ";";
            SqlConnection con = new SqlConnection("Data Source=MUM0212CPU0558\\SQLEXPRESS;Initial Catalog=students;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            Label1.Text = "Data Deleted";
        }

    }
}