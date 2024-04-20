<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tipos de Cuentas Bancarias</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <header>
        <nav>
            <ul>
                <li><a href="#" class="active">Cuentas</a></li>
            </ul>
        </nav>
    </header>
    
    <div class="container">
        <h1>Tipos de Cuentas Bancarias</h1>
        <div class="cuentas">
            <?php
            // Definir las cuentas bancarias
            $cuentas = array(
                array(
                    'tipo' => 'Cuenta Corriente',
                    'descripcion' => 'Una cuenta corriente es una cuenta bancaria que permite al titular realizar múltiples transacciones, como depósitos, retiros y transferencias.',   
                ),
                array(
                    'tipo' => 'Cuenta de Ahorros',
                    'descripcion' => 'Una cuenta de ahorros es una cuenta bancaria que permite a los titulares depositar dinero y ganar interés sobre los fondos depositados.',  
                ),
                array(
                    'tipo' => 'Cuenta de Cheques',
                    'descripcion' => 'Una cuenta de cheques es una cuenta bancaria que permite al titular emitir cheques para realizar pagos y retirar fondos mediante cheques o tarjetas de débito.',     
                )
            );

            // Mostrar cada cuenta bancaria
            foreach ($cuentas as $cuenta) {
                echo '<div class="cuenta">';
                echo '<h2>' . $cuenta['tipo'] . '</h2>';
                echo '<p>' . $cuenta['descripcion'] . '</p>';
                echo '</div>';
            }
            ?>
        </div>
    </div>
</body>
</html>
