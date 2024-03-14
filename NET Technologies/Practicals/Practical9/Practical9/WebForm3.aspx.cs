using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Practical9
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Label1.Text = "";
                string sql = "SELECT sapid, name FROM STUDENT";
                SqlConnection con = new SqlConnection("Data Source=MUM0212CPU0558\\SQLEXPRESS;Initial Catalog=students;Integrated Security=True");
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                ListBox1.DataSource = cmd.ExecuteReader();
                ListBox1.DataTextField = "name";
                ListBox1.DataValueField = "sapid";
                this.DataBind();
                con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "SAP ID - " + ListBox1.SelectedValue + ": " + ListBox1.SelectedItem;
        }
    }
}