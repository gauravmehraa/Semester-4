using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical9
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<string> players = new List<string>();
            players.Add("Lionel Messi");
            players.Add("Cristiano Ronaldo");
            players.Add("Neymar Jr");
            players.Add("Kylian Mbappe");
            players.Add("Erling Haaland");
            players.Add("Lionel Messi");


            ListBox1.DataSource = players;
            DropDownList1.DataSource = players;
            CheckBoxList1.DataSource = players;
            RadioButtonList1.DataSource = players;

            this.DataBind();
        }
    }
}