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
            Label1.Visible = true;
            for (int i = 0; i < ListBox1.Items.Count; i++)
            {
                if (ListBox1.Items[i].Selected) count++;
            }
            if (count < 3) Label1.Text = "You have chosen less electives. Select 3 electives. ";
            else if (count > 3) Label1.Text = "You have chosen more electives. You can only select 3 electives. ";
            else
            {
                Label1.Text = "You have chosen the following electives: ";
                TextBox1.Visible = true;
                TextBox1.Text = "";
                Button2.Visible = true;
                for (int i = 0; i < ListBox1.Items.Count; i++)
                {
                    if (ListBox1.Items[i].Selected)
                        TextBox1.Text += String.Format("\n{0}" ,ListBox1.Items[i].Value);
                }
                
            }
            
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }
    }
}