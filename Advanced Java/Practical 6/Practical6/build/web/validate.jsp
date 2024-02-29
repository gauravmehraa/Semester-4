
<%@ page import="java.sql.*" %>
<% 
    String username = request.getParameter("username");
    String password = request.getParameter("password");
    Class.forName("com.mysql.jdbc.Driver");
    Connection con = DriverManager.getConnection("jdbc:mysql://localhost:3306/library", "root", "root");
    Statement st = con.createStatement();
    ResultSet rs = st.executeQuery("select * from admin where username='"+ username +"' and password = '"+password+"';");
    String filename = rs.next()? "menu.jsp": "msg.jsp";
            
    
    request.getRequestDispatcher(filename).forward(request, response);
%>
