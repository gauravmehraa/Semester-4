<%@ page import="java.sql.*" %>
<%
    Class.forName("com.mysql.jdbc.Driver");
    Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/employee", "root", "root");
    pageContext.setAttribute("connection", con);
%>