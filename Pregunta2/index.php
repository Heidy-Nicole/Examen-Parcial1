<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title></title>
    <link rel="stylesheet" href="styles.css">    

</head>
<body>
    <h1>Personas y cuentas bancarias</h1>
    
    <h2>Agregar Persona</h2>
    <form action="crud.php" method="POST">
        <input type="hidden" name="accion_persona" value="agregar_persona">
        Nombre: <input type="text" name="nombre"><br>
        Apellido: <input type="text" name="apellido"><br>
        Edad: <input type="number" name="edad"><br>
        Dirección: <input type="text" name="direccion"><br>
        <input type="submit" value="Agregar Persona">
    </form>
    
    <h2>Modificar Persona</h2>
    <form action="crud.php" method="POST">
        <input type="hidden" name="accion_persona" value="modificar_persona">
        ID de Persona a modificar: <input type="number" name="id_per"><br>
        Nombre: <input type="text" name="nombre"><br>
        Apellido: <input type="text" name="apellido"><br>
        Edad: <input type="number" name="edad"><br>
        Dirección: <input type="text" name="direccion"><br>
        <input type="submit" value="Modificar Persona">
    </form>
    
    <h2>Eliminar Persona</h2>
    <form action="crud.php" method="POST">
        <input type="hidden" name="accion_persona" value="eliminar_persona">
        ID de Persona a eliminar: <input type="number" name="id_per"><br>
        <input type="submit" value="Eliminar Persona">
    </form>
    
    <h2>Agregar Cuenta Bancaria</h2>
    <form action="crud.php" method="POST">
    <input type="hidden" name="accion_cuenta" value="agregar_cuenta">
    ID de Persona: <input type="number" name="id_per"><br>
    Número de Cuenta: <input type="text" name="numero_cuenta"><br>
    Tipo de Cuenta: <input type="text" name="tipo_cuenta"><br> <!-- Campo para el tipo de cuenta -->
    Saldo: <input type="number" step="0.01" name="saldo"><br>
    <input type="submit" value="Agregar Cuenta Bancaria">
    </form>
    
    <h2>Modificar Cuenta Bancaria</h2>
    <form action="crud.php" method="POST">
        <input type="hidden" name="accion_cuenta" value="modificar_cuenta">
        ID de Cuenta a modificar: <input type="number" name="id_cuen"><br>
        Número de Cuenta: <input type="text" name="numero_cuenta"><br>
        Saldo: <input type="number" step="0.01" name="saldo"><br>
        Tipo de Cuenta: <input type="text" name="tipo_cuenta"><br>
        <input type="submit" value="Modificar Cuenta Bancaria">
    </form>
    
    <h2>Eliminar Cuenta Bancaria</h2>
    <form action="crud.php" method="POST">
        <input type="hidden" name="accion_cuenta" value="eliminar_cuenta">
        ID de Cuenta a eliminar: <input type="number" name="id_cuen"><br>
        <input type="submit" value="Eliminar Cuenta Bancaria">
    </form>
</body>
</html>
