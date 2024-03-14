<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Set Session</title>
</head>
<body>
<%
    // Create a new session
    session = request.getSession();
    // Set an attribute to the session
    session.setAttribute("message", "Hello, this is a session message!");
%>
Session is set with a message. <a href="getSession.jsp">Click here</a> to get the session message.
</body>
</html>
