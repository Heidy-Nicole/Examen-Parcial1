<!DOCTYPE html>
<html>
<head>
    <title>Login</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f9f9f9; /* Color de fondo suave */
            margin: 0;
            padding: 0;
        }

        h1 {
            color: #333; /* Color de texto oscuro */
            text-align: center; /* Centrar el texto */
            margin-top: 50px; /* Espacio superior */
        }

        form {
            width: 300px;
            margin: 0 auto;
            background-color: #fff; /* Fondo blanco */
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); /* Sombra suave */
        }

        label {
            display: block;
            margin-bottom: 8px;
            color: #555; /* Color de texto gris */
        }

        input[type="text"] {
            width: calc(100% - 20px);
            padding: 8px;
            margin-bottom: 15px;
            border: 1px solid #ccc; /* Borde gris */
            border-radius: 4px;
        }

        button {
            width: 100%;
            padding: 10px;
            background-color: #007bff; /* Color azul */
            border: none;
            color: #fff; /* Texto blanco */
            border-radius: 4px;
            cursor: pointer;
        }

        button:hover {
            background-color: #0056b3; /* Color azul más oscuro al pasar el mouse */
        }
    </style>
</head>
<body>
    <h1>Login</h1>
    <form method="post" action="sesion">
        <label for="email">Email</label>
        <input type="text" name="email" id="email" required>
        <button type="submit">Iniciar sesión</button>
    </form>
</body>
</html>
