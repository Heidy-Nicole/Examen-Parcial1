<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Mostrar Datos</title>
    <style>
        /* Estilos generales */
        body {
            font-family: Arial, sans-serif;
            background-color: #f9f9f9; /* Color de fondo suave */
            margin: 0;
            padding: 0;
        }

        h1 {
            color: #333; /* Color de texto oscuro */
        }

        /* Estilos de la tabla */
        table {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 20px; /* Espacio entre tablas */
        }

        th, td {
            padding: 12px; /* Aumentar el espacio dentro de las celdas */
            text-align: left;
            border-bottom: 1px solid #ddd;
        }

        th {
            background-color: #f5f5f5; /* Color de fondo de las celdas del encabezado */
        }

        tr:nth-child(even) {
            background-color: #f5f5f5; /* Color de fondo de filas pares */
        }

        /* Estilos del formulario */
        form {
            margin-bottom: 20px; /* Espacio entre formularios y tablas */
        }

        input[type="text"] {
            padding: 8px;
            margin-right: 10px;
        }

        button {
            padding: 8px 16px;
            background-color: #ffc0cb; /* Color rosa pastel para botones */
            border: none;
            color: #fff; /* Texto blanco */
            cursor: pointer;
        }

        button:hover {
            background-color: #ffa07a; /* Color rosa pastel más oscuro al pasar el mouse */
        }
    </style>
</head>

<body>
    <h1>Personas</h1>
    <table border="1">
        <tr>
            <th>persona_id</th>
            <th>nombre</th>
            <th>ap_paterno</th>
            <th>ap_materno</th>
            <th>rol</th>
            <th>departamento</th>
        </tr>
        <?php foreach ($personas as $persona) : ?>
            <tr>
                <td><?= $persona['persona_id'] ?></td>
                <td><?= $persona['nombre'] ?></td>
                <td><?= $persona['ap_paterno'] ?></td>
                <td><?= $persona['ap_materno'] ?></td>
                <td><?= $persona['rol'] ?></td>
                <td><?= $persona['departamento'] ?></td>
            </tr>
        <?php endforeach; ?>
    </table>

    <h1>Cuentas</h1>
    <table border="1">
        <tr>
            <th>cuentabancaria_id</th>
            <th>numero_cuenta</th>
            <th>saldo</th>
            <th>persona_id</th>
            <th>tipo</th>
        </tr>
        <?php foreach ($cuentas as $cuenta) : ?>
            <tr>
                <td><?= $cuenta['cuentabancaria_id'] ?></td>
                <td><?= $cuenta['numero_cuenta'] ?></td>
                <td><?= $cuenta['saldo'] ?></td>
                <td><?= $cuenta['persona_id'] ?></td>
                <td><?= $cuenta['tipo'] ?></td>
            </tr>
        <?php endforeach; ?>
    </table>

    <!-- Formulario para eliminar cuenta -->
    <form action="<?= base_url('/mostrar/eliminar') ?>" method="post">
        <input type="text" name="id" placeholder="ID de la cuenta a eliminar">
        <button type="submit">Eliminar</button>
    </form>

    <!-- Botón para iniciar sesión -->
    <form action="login" method="post">
        <button type="submit">Login</button>
    </form>
</body>
</html>
