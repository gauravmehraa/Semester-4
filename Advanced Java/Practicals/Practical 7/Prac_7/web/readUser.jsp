<%@ include file="dbConnection.jsp" %>
<%
    String emp_id = request.getParameter("emp_id");
    Connection con4 = (Connection) pageContext.getAttribute("connection");
    PreparedStatement ps = con4.prepareStatement("SELECT * FROM employees WHERE emp_id = ?");
    ps.setString(1, emp_id);
    ResultSet rs = ps.executeQuery();
    while (rs.next()) {
%>
    Employee ID: <%= rs.getString("emp_id") %><br>
    First Name: <%= rs.getString("first_name") %><br>
    Last Name: <%= rs.getString("last_name") %><br>
<%
    }
%>
