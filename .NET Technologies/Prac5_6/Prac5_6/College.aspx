<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="College.aspx.cs" Inherits="Prac5_6.College" %>

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
        Mithibai College of Arts and Chauhan Institute of Science was established in 1961 <br />
        by Shri Vile Parle Kelavani Mandal to address the growing need for <br />
        of higher education in the western suburbs of Mumbai.<br />
        With growing demand, Amrutben Jivanlal College of Commerce &amp; Economics was <br />
        instituted in 1981. The college has been granted linguistic minority status for <br />
        the Gujarati community. From a modest two-storey building, the college has now <br />
        grown to a nine- storey edifice that towers over the landscape of Juhu. The <br />
        college has 22 departments associated with the faculties of Arts, Science &amp<br />
        Commerce. There are 16 Post Graduate programs and 10 Research Centres <br />
        Ph.D. programmes. The college is a recipient of grants under Rashtriya <br />
        Shiksha Abhiyan (RUSA-2), DBT and DST.<br />
    </div>
    </form>
</body>
</html>
