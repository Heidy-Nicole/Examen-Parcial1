<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
	<h1>Mostrando datos de las personas</h1>
	<%
		try{
			String apiData = (String) request.getAttribute("apiData");
			
			
			
			for(int i = 0; i <= apiData.length(); i++){
				char x = apiData.charAt(i);
				
				if(x == '[' || x == '{' || x == ']' || x == '"'){
					
				}else{
					if(x == '}' || x == ',')
						out.println("<br>");
					else
						out.print(x);
				}
				
			}
			out.println("Datos de la API: " + apiData );
			
		}
		catch(Exception e){
			out.println("");
		}
		
	%>
	
	<br>
	<br>
	<h1>Mostrando datos de las cuentas</h1>
	<%
		
		try{
			String apiData2 = (String) request.getAttribute("apiData2");

			for(int i = 0; i <= apiData2.length(); i++){
				char x = apiData2.charAt(i);
				
				if(x == '[' || x == '{' || x == ']' || x == '"'){
					
				}else{
					if(x == '}' || x == ',')
						out.println("<br>");
					else
						out.print(x);
				}
				
			}

		}
		catch(Exception e){
			out.println("");
		}
		
	
	%>		
	<a href="MyServlet">
	
	<button type="button">
		GET
	
	</button>
	</a>
</body>
</html>