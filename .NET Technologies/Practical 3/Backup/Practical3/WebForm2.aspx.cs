using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                if (ListBox1.Items[i].Selected) count++;
            }
            string text = "You have selected " + count + " elective(s). ";
            if (count < 3) text += "Select 3 electives. ";
            else if (count > 3) text += "You can only select 3 electives. ";
            Label1.Visible = true;
            Label1.Text = text;
        }
    }
}