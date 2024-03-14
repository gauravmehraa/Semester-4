using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical9
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> days = new Dictionary<int, string>();
            days.Add(1, "Monday");
            days.Add(2, "Tuesday");
            days.Add(3, "Wednesday");
            days.Add(4, "Thursday");
            days.Add(5, "Friday");
            days.Add(6, "Saturday");
            days.Add(7, "Sunday");

            ListBox1.DataSource = days;
            ListBox1.DataValueField = "Key";
            ListBox1.DataTextField = "Value";

            this.DataBind();

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = "Day no. " + ListBox1.SelectedValue + " - " + ListBox1.SelectedItem;
        }
    }
}