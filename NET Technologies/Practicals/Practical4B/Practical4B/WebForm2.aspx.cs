using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4B
{
    public partial class WebForm2 : System.Web.UI.Page
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
            ListBox1.Items.Add("Cricket");
            ListBox1.Items.Add("Football");
            ListBox1.Items.Add("Badminton");
            ListBox1.Items.Add("Tennis");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["sport"] = ListBox1.SelectedValue;
            Response.Redirect("WebForm3.aspx");
        }
    }
}