using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace Practical3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Visible = true;
            Label1.Font.Bold = Label1.Font.Italic = Label1.Font.Underline = false;
            if (CheckBoxList1.SelectedIndex == -1 || RadioButtonList1.SelectedIndex == -1)
            {
                Label1.Text = "Values should be selected";
                return;
            }
            string inputusername = TextBox1.Text;
            string inputpassword = TextBox2.Text;
            if (inputusername.Equals("admin") && inputpassword.Equals("root"))
            {
                Button2.Visible = true;
                Label1.Font.Bold = CheckBoxList1.Items[0].Selected ? true: false;
                Label1.Font.Italic = CheckBoxList1.Items[1].Selected ? true : false;
                Label1.Font.Underline = CheckBoxList1.Items[2].Selected ? true : false;
                switch(RadioButtonList1.SelectedValue)
                {
                    case "Red": Label1.ForeColor = System.Drawing.Color.Red; break;
                    case "Blue": Label1.ForeColor = System.Drawing.Color.Blue; break;
                    case "Green": Label1.ForeColor = System.Drawing.Color.Green; break;
                }

                Label1.Text = "Login Successful! Welcome " + inputusername;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}