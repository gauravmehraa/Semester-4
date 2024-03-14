using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4B
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user"];
            if (cookie != null)
            {
                Label1.Text = "Welcome " + cookie["username"].ToString();
            }
            else
            {
                Label1.Text = "Welcome User";
            }
            ListBox1.Items.Add("Pizza");
            ListBox1.Items.Add("Sandwich");
            ListBox1.Items.Add("Fries");
            ListBox1.Items.Add("Burger");
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            Session["food"] = ListBox1.SelectedValue;
            Response.Redirect("WebForm4.aspx");
        }
    }
}