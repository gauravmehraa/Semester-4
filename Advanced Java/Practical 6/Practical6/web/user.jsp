<%-- 
    Document   : newjsp
    Created on : 21 Feb, 2024, 3:26:05 PM
    Author     : Admin
--%>

<%@page language="java" contentType="text/html" pageEncoding="UTF-8"%>
<%@page import="bean.User" %>
<!DOCTYPE html>
<html>
    <head>
        <title>User Information</title>
    </head>
    <body>
        <h1>User Information</h1>
        <jsp:useBean id="user" class="bean.User" scope="session"/>
        
        <jsp:setProperty property="username" name="user" value="Gaurav Mehra"/>
        <jsp:setProperty property="email" name="user" value="gauravmehra158@gmail.com"/>
        
        <p>
            <jsp:getProperty property="username" name="user"/>
        </p>
        <p>
            <jsp:getProperty property="email" name="user"/>
        </p>
    </body>
</html>
