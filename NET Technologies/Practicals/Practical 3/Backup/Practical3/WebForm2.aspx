<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Practical3.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Preferred Electives (Select any 3)<br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="124px" 
            SelectionMode="Multiple" Width="232px">
            <asp:ListItem>DSA</asp:ListItem>
            <asp:ListItem>Web Design</asp:ListItem>
            <asp:ListItem>Computer Architecture</asp:ListItem>
            <asp:ListItem>Calculus</asp:ListItem>
            <asp:ListItem>Software Engineering</asp:ListItem>
            <asp:ListItem>DBMS</asp:ListItem>
            <asp:ListItem>Game Development</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="Confirm Submission" />
        <br />
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
    </form>
</body>
</html>
