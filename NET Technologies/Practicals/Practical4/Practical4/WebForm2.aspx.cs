using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {

            }
            else
            {
                Label1.Text = Request.QueryString["name"];
                Label2.Text = Request.QueryString["stream"];
                Label3.Text = Request.QueryString["subject"];
            }
        }
    }
}