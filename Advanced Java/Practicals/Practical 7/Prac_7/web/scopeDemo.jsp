<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Scope Demo</title>
</head>
<body>
<%
    // Set attributes in different scopes
    pageContext.setAttribute("pageAttribute", "This is a page scope attribute");
    request.setAttribute("requestAttribute", "This is a request scope attribute");
    application.setAttribute("applicationAttribute", "This is an application scope attribute");
    session.setAttribute("sessionAttribute", "This is a session scope attribute");
%>
<h2>Attributes in Different Scopes:</h2>
<p>Page Scope Attribute: <%= pageContext.getAttribute("pageAttribute") %></p>
<p>Request Scope Attribute: <%= request.getAttribute("requestAttribute") %></p>
<p>Application Scope Attribute: <%= application.getAttribute("applicationAttribute") %></p>
<p>Session Scope Attribute: <%= session.getAttribute("sessionAttribute") %></p>
</body>
</html>
