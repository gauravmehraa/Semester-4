<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Get Session</title>
</head>
<body>
<%
    // Get the session
    session = request.getSession();
    // Retrieve the attribute from the session
    String message = (String) session.getAttribute("message");
%>
The session message is: <%= message %>
</body>
</html>
