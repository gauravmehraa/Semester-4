<%@ include file="dbConnection.jsp" %>
<%
    String emp_id = request.getParameter("emp_id");
    Connection con3 = (Connection) pageContext.getAttribute("connection");
    PreparedStatement ps = con3.prepareStatement("DELETE FROM employees WHERE emp_id = ?");
    ps.setString(1, emp_id);
    ps.executeUpdate();
%>
Employee deleted successfully.
