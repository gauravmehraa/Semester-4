<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="Prac5_6.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:SiteMapPath ID="SiteMapPath1" runat="server">
        </asp:SiteMapPath>
        <br />
        <br />
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1">
        </asp:TreeView>
        <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
        <br />
        <br />
        Shri Vile Parle Kelavani Mandal is a Public Charitable Trust registered under <br />
        the Society’s Registration Act and Bombay Public Trust Act. From its humble <br />
        beginnings in 1934, when it took over the Rashtriya Shala, a school established <br />
        in 1921 in the wake of the National Movement, the Mandal today has grown into a <br />
        big educational complex imparting high-level education to more than 35,000 <br />
        students.
        </div>
    </form>
</body>
</html>
