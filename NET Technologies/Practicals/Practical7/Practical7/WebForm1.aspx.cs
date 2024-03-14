using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Practical7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            XmlTextWriter writer = new XmlTextWriter("C:/Users/Admin/Documents/Visual Studio 2010/Projects/Practical7/Practical7/tvschedule.xml", System.Text.Encoding.UTF8);
            XmlTextReader reader = new XmlTextReader("C:/Users/Admin/Documents/Visual Studio 2010/Projects/Practical7/Practical7/tvschedule.xml");
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();

            // Root element
            writer.WriteStartElement("tvschedule");

            // Channel
            writer.WriteStartElement("channel");
            writer.WriteElementString("banner", "Banner123");

            // Day
            writer.WriteStartElement("day");
            writer.WriteElementString("date", "09th March 2024");


            // Programslot
            writer.WriteStartElement("programslot");
            writer.WriteElementString("time", "4:20PM");
            writer.WriteElementString("title", "El Clasico 2024");
            writer.WriteElementString("description", "Football go brrr");
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element) Label1.Text += "Element " + reader.Name + " started<br/>";
                else if (reader.NodeType == XmlNodeType.Text) Label1.Text += "" + reader.Value + "<br/>";
                else if (reader.NodeType == XmlNodeType.EndElement) Label1.Text += "Element " + reader.Name + " ended<br/>";
            }
            reader.Close();
        }
    }
}