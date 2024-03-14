<%@ include file="dbConnection.jsp" %>
<%
    String emp_id = request.getParameter("emp_id");
    String first_name = request.getParameter("first_name");
    String last_name = request.getParameter("last_name");
    Connection con = (Connection) pageContext.getAttribute("connection");
    PreparedStatement ps = con.prepareStatement("INSERT INTO employees (emp_id, first_name, last_name) VALUES (?, ?, ?)");
    ps.setString(1, emp_id);
    ps.setString(2, first_name);
    ps.setString(3, last_name);
    ps.executeUpdate();
%>
Employee created successfully.
