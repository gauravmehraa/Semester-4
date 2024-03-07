<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="Prac5_6.Department" %>

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
        The Computer Science department came into existence under the guidance of 
        eminent scholar and research guide Dr. Mukund Sanglikar.<br />
        The department organized Mithibai College&#39;s first ever inter-collegiate 
        Technical Fest, <b>Galactech</b>.<br />
        The department launched a new departmental fest, <b>TechSpark</b>, with its 
        motto &quot;Engraving Adaptability&quot;, replacing Galactech.<br />
        The University Grants Commissions granted Mithibai College with Grade 1 Autonomy 
        for a period of 10 years without onsite visit by expert committee.<br />
        The department rebooted TechSpark in a grand fashion after its last edition took 
        place in 2020, and was halted due to the pandemic.</div>
    </form>
</body>
</html>
