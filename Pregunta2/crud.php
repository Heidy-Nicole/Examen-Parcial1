<?php
include '../conexion.php';

// Operaciones CRUD para Persona
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    if(isset($_POST['accion_persona'])) {
        $accion_persona = $_POST['accion_persona'];
        
        if($accion_persona == "agregar_persona") {
            $nombre = $_POST['nombre'];
            $apellido = $_POST['apellido'];
            $edad = $_POST['edad'];
            $direccion = $_POST['direccion'];
            
            $sql = "INSERT INTO Persona (nombre, apellido, edad, direccion) VALUES ('$nombre', '$apellido', $edad, '$direccion')";

            $resultado = mysqli_query($conn, $sql);
            if ($resultado) {
                echo "Persona agregada exitosamente.";
            } else {
                echo "Error al agregar persona: " . mysqli_error($conn);
            }
        }
        elseif($accion_persona == "modificar_persona") {
            $id_per = $_POST['id_per'];
            $nombre = $_POST['nombre'];
            $apellido = $_POST['apellido'];
            $edad = $_POST['edad'];
            $direccion = $_POST['direccion'];
            
            $sql = "UPDATE Persona SET nombre='$nombre', apellido='$apellido', edad=$edad, direccion='$direccion' WHERE id_per=$id_per";
            
            $resultado = mysqli_query($conn, $sql);
            if ($resultado) {
                echo "Persona modificada exitosamente.";
            } else {
                echo "Error al modificar persona: " . mysqli_error($conn);
            }
        }
        elseif($accion_persona == "eliminar_persona") {
            $id_per = $_POST['id_per'];
            
            $sql = "DELETE FROM Persona WHERE id_per=$id_per";
            
            $resultado = mysqli_query($conn, $sql);
            if ($resultado) {
                echo "Persona eliminada exitosamente.";
            } else {
                echo "Error al eliminar persona: " . mysqli_error($conn);
            }
        }
    }
}

// Operaciones CRUD para Cuenta Bancaria
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    if(isset($_POST['accion_cuenta'])) {
        $accion_cuenta = $_POST['accion_cuenta'];
        
        if($accion_cuenta == "agregar_cuenta") {
            $id_per = $_POST['id_per'];
            $numero_cuenta = $_POST['numero_cuenta'];
            $saldo = $_POST['saldo'];
            $tipo_cuenta = $_POST['tipo_cuenta'];
            
            $sql = "INSERT INTO cuentabancaria (id_per, numero_cuenta, saldo, tipo_cuenta) VALUES ($id_per, '$numero_cuenta', '$saldo', '$tipo_cuenta')";
            
            $resultado = mysqli_query($conn, $sql);
            if ($resultado) {
                echo "Cuenta bancaria agregada exitosamente.";
            } else {
                echo "Error al agregar cuenta bancaria: " . mysqli_error($conn);
            }
        }
        elseif($accion_cuenta == "modificar_cuenta") {
            $id_cuen = $_POST['id_cuen'];
            $numero_cuenta = $_POST['numero_cuenta'];
            $saldo = $_POST['saldo'];
            $tipo_cuenta = $_POST['tipo_cuenta'];
            $sql = "UPDATE cuentabancaria SET numero_cuenta='$numero_cuenta', saldo='$saldo', tipo_cuenta='$tipo_cuenta' WHERE id_cuen='$id_cuen'";
            
            $resultado = mysqli_query($conn, $sql);
            if ($resultado) {
                echo "Cuenta bancaria modificada exitosamente.";
            } else {
                echo "Error al modificar cuenta bancaria: " . mysqli_error($conn);
            }
        }
        elseif($accion_cuenta == "eliminar_cuenta") {
            $id_cuen = $_POST['id_cuen'];
            
            $sql = "DELETE FROM cuentabancaria WHERE id_cuen=$id_cuen";
            
            $resultado = mysqli_query($conn, $sql);
            if ($resultado) {
                echo "Cuenta bancaria eliminada exitosamente.";
            } else {
                echo "Error al eliminar cuenta bancaria: " . mysqli_error($conn);
            }
        }
    }
}

// Mostrar personas
$sql_mostrar = "SELECT * FROM Persona";
$resultado_mostrar = mysqli_query($conn, $sql_mostrar);
if ($resultado_mostrar) {
    if (mysqli_num_rows($resultado_mostrar) > 0) {
        echo "<h2>Personas:</h2>";
        while ($fila = mysqli_fetch_assoc($resultado_mostrar)) {
            echo "ID: " . $fila['id_per'] . " - Nombre: " . $fila['nombre'] . " " . $fila['apellido'] . " - Edad: " . $fila['edad'] . " - Dirección: " . $fila['direccion'] . "<br>";
        }
    } else {
        echo "<p>No hay personas registradas.</p>";
    }
} else {
    echo "Error al mostrar personas: " . mysqli_error($conn);
}

// Mostrar cuentas bancarias
$sql_mostrar_cuentas = "SELECT * FROM cuentabancaria";
$resultado_mostrar_cuentas = mysqli_query($conn, $sql_mostrar_cuentas);
if ($resultado_mostrar_cuentas) {
    if (mysqli_num_rows($resultado_mostrar_cuentas) > 0) {
        echo "<h2>Cuentas Bancarias:</h2>";
        while ($fila_cuenta = mysqli_fetch_assoc($resultado_mostrar_cuentas)) {
            echo "ID: " . $fila_cuenta['id_cuen'] . " - ID Persona: " . $fila_cuenta['id_per'] . " - Número de Cuenta: " . $fila_cuenta['numero_cuenta'] . " - Saldo: " . $fila_cuenta['saldo'] . " - Tipo de Cuenta: " . $fila_cuenta['tipo_cuenta'] . "<br>";
        }
    } else {
        echo "<p>No hay cuentas bancarias registradas.</p>";
    }
} else {
    echo "Error al mostrar cuentas bancarias: " . mysqli_error($conn);
}

mysqli_close($conn);
?>
