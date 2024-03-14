using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4B
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                HttpCookie user = new HttpCookie("user");
                user["username"] = TextBox1.Text;
                user["email"] = TextBox2.Text;
                user.Expires = DateTime.Now.AddMinutes(15);
                Response.Cookies.Add(user);
            }
            Response.Redirect("WebForm2.aspx");
        }
    }
}