using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Practical8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM STUDENT WHERE DEPARTMENT='"+TextBox1.Text+"'";
            SqlConnection con = new SqlConnection("Data Source=MUM0212CPU0558\\SQLEXPRESS;Initial Catalog=students;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            con.Open();
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                Label1.Text += "SAP ID: " + reader["sapid"].ToString() + "<br/>";
                Label1.Text += "Student Name: " + reader["name"].ToString() + "<br/>";
                Label1.Text += "Department: " + reader["department"].ToString() + "<br/><br/>";
            }
            
        }

    }
}