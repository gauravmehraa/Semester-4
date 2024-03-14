using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4B
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["user"];
            if(cookie != null && Session["food"] != null && Session["sport"] != null)
            {
                Label1.Text = "Welcome " + cookie["username"].ToString();
                Label2.Text = "The following are your choices\n " +
                    "Your favourite food is " + Session["food"].ToString() + "\n" +
                    "Your favourite sport is " + Session["sport"].ToString();
                Label3.Text = "The result will be sent to your Email ID - " + cookie["email"].ToString();
            }
        }
    }
}