<%@ include file="dbConnection.jsp" %>
<%
    String emp_id = request.getParameter("emp_id");
    String first_name = request.getParameter("first_name");
    String last_name = request.getParameter("last_name");
    Connection con2 = (Connection) pageContext.getAttribute("connection");
    PreparedStatement ps = con2.prepareStatement("UPDATE employees SET first_name = ?, last_name = ? WHERE emp_id = ?");
    ps.setString(1, first_name);
    ps.setString(2, last_name);
    ps.setString(3, emp_id);
    ps.executeUpdate();
%>
Employee updated successfully.
