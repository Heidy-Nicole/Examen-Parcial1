<!DOCTYPE html>
<html>
<head>
    <title>Cliente</title>
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

        table {
            width: 50%;
            margin: 0 auto;
            border-collapse: collapse;
            background-color: #fff; /* Fondo blanco */
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); /* Sombra suave */
        }

        th, td {
            padding: 12px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }

        th {
            background-color: #f5f5f5; /* Color de fondo de las celdas del encabezado */
        }

        tr:nth-child(even) {
            background-color: #f5f5f5; /* Color de fondo de filas pares */
        }
    </style>
</head>
<body>
    <h1>Cliente</h1>
    <table>
        <tr>
            <th>Nombre</th>
            <th>Apellido pat</th>
            <th>Apellido mat</th>
            <th>Correo</th>
            <th>Departamento</th>
        </tr>
        <tr>
            <td><?php echo $datos['nombre']; ?></td>
            <td><?php echo $datos['ap_paterno']; ?></td>
            <td><?php echo $datos['ap_materno']; ?></td>
            <td><?php echo $datos['correo']; ?></td>
            <td><?php echo $datos['departamento']; ?></td>
        </tr>
    </table>
</body>
</html>
