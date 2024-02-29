using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Visible = true;
            DateTime start = new DateTime(2024, 9, 25);
            DateTime end = new DateTime(2024, 10, 17);
            DateTime selected = Calendar1.SelectedDate;
            if(selected > end || selected < start)
            {
                Label1.Text = "Enter valid date between 25 September 2024 and 17 October 2024";
            }
            else
            {
                Label1.Text = String.Format("You have chosen {0}-{1}-{2} as the submission date.",
                    selected.Day, selected.Month, selected.Year);
            }
        }
    }
}