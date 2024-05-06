<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
<style>
    body {
        font-family: Arial, sans-serif;
        background-color: #f4f4f4;
        margin: 0;
        padding: 20px;
    }
    
    h2 {
        color: #333;
    }
    
    p {
        color: #666;
    }
    
    a {
        text-decoration: none;
        color: #007bff;
        padding: 5px 10px;
        border: 1px solid #007bff;
        border-radius: 5px;
        background-color: #fff;
        transition: background-color 0.3s, color 0.3s;
    }
    
    a:hover {
        background-color: #007bff;
        color: #fff;
    }
</style>
</head>
<body>
    <a href="MyServlet">GET</a>
    
    <%-- Imprimir datos de las personas --%>
    <% String apiData = (String) request.getAttribute("apiData"); %>
    <h2>Datos de las personas:</h2>
    <p><%= apiData %></p>
    
    <br>
    <br>
    
    <%-- Imprimir datos de las cuentas de las personas --%>
    <% String apiData2 = (String) request.getAttribute("apiData2"); %>
    <h2>Datos de las cuentas de las personas:</h2>
    <p>Datos dentro de la bd: <%= apiData2 %></p>
</body>
</html>
