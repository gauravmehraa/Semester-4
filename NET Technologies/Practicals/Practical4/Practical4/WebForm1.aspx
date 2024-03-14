<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical4.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Enter Name:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Choose your stream<br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="Science"></asp:ListItem>
            <asp:ListItem Value="Commerce"></asp:ListItem>
            <asp:ListItem Value="Humanities"></asp:ListItem>
            <asp:ListItem Value="Arts"></asp:ListItem>
        </asp:RadioButtonList>
        <br />
        Select your favourite subject<br />
        <asp:ListBox ID="ListBox1" runat="server">
            <asp:ListItem Value="Physics"></asp:ListItem>
            <asp:ListItem Value="Chemistry"></asp:ListItem>
            <asp:ListItem Value="Mathematics"></asp:ListItem>
            <asp:ListItem Value="Computer Science"></asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Query String" 
            onclick="Button1_Click" />
    
    </div>
    </form>
</body>
</html>
