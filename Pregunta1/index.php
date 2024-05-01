<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Cuentas Bancarias</title>
    <link rel="stylesheet" href="styles.css">
</head>
<body>

<div class="container">
    <h1>Cuentas Bancarias</h1>
    <div class="cuentas">
        <div class="cuenta">
            <h2>Cuenta Corriente</h2>
            <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
                <input type="hidden" name="tipo_cuenta" value="corriente">
                <button type="submit" name="ver_detalle_corriente">
                    Ver Detalles
                </button>
            </form>
        </div>
        <div class="cuenta">
            <h2>Cuenta de Cheques</h2>
            <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
                <input type="hidden" name="tipo_cuenta" value="cheques">
                <button type="submit" name="ver_detalle_cheques">
                    Ver Detalles
                </button>
            </form>
        </div>
        <div class="cuenta">
            <h2>Cuenta de Ahorros</h2>
            <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
                <input type="hidden" name="tipo_cuenta" value="ahorros">
                <button type="submit" name="ver_detalle_ahorros">
                    Ver Detalles
                </button>
            </form>
        </div>
    </div>

    <?php
    if(isset($_POST['ver_detalle_corriente'])) {
        echo "<h3>Detalles de la Cuenta Corriente:</h3>";
        echo "<p>En otras palabras, una cuenta corriente es, básicamente, un acuerdo con tu banco que te permite guardar tu dinero con ellos. Una vez depositado, puedes usar ese dinero de varias formas: sacarlo usando un cajero automático, hacer transferencias a otras cuentas, o incluso pagar tus cuentas directamente desde tu cuenta. También, esta cuenta es muy útil para gestionar pagos automáticos. Por ejemplo, puedes programar el pago de tus impuestos o las cuotas de un préstamo sin tener que hacerlo manualmente cada vez. Es una forma de asegurarte de que nunca te atrasarás en tus pagos.</p>";
    } elseif(isset($_POST['ver_detalle_cheques'])) {
        echo "<h3>Detalles de la Cuenta de Cheques:</h3>";
        echo "<p>Las cuentas de cheques ofrecen una manera segura y conveniente de administrar su dinero, incluso de realizar pagos. Con su cuenta, puede tener acceso a cheques y a una tarjeta de débito. Normalmente, su institución financiera le proporcionará cheques cuando abra una cuenta de cheques. Puede solicitar más cheques cuando los necesite, generalmente se cobrará un cargo. Los cheques se presentan en formato impreso y las personas los usan para transferir dinero de un lugar a otro. Un cheque es una orden por escrito que le indica a un banco que pague un monto específico de dinero desde una cuenta de cheques específica a una persona o entidad específica, por ejemplo, una tienda. Si usted tiene cheques, no es necesario que lleve consigo grandes cantidades de efectivo. También puede solicitar una tarjeta de débito cuando abra su cuenta. Su tarjeta de débito le proporciona una manera segura y conveniente de obtener efectivo, transferir fondos, hacer depósitos y administrar su dinero. Tanto con los cheques como con su tarjeta de débito, usted puede realizar compras y pagos, incluso por Internet y por teléfono. Su tarjeta de débito le permite obtener efectivo y administrar su dinero en cajeros automáticos (ATM) usando su tarjeta física, o bien, una billetera digital. Es posible que se le cobre un cargo si usa un ATM en el extranjero o un ATM de otro banco.</p>";
    } elseif(isset($_POST['ver_detalle_ahorros'])) {
        echo "<h3>Detalles de la Cuenta de Ahorros:</h3>";
        echo "<p>Una cuenta de ahorros es un producto financiero ofrecido por el Banco que te permite ahorrar tu dinero de forma segura. Tradicionalmente, la cuenta de ahorros es el producto más usado  para que puedas ahorrar y disponer de tu dinero de forma rápida. El dinero que deposites en tu cuenta generará intereses de acuerdo a las políticas del banco y a las características de cada producto. Puedes revisar los detalles de las tasas en cualquier momento para saber cuál es el interés que se está generando en tu cuenta. Otra característica importante de las cuentas de ahorros, es que éstas te permiten disponer de tu dinero de forma rápida. Al abrir tu cuenta, el banco te entregará un tarjeta débito con la que podrás realizar retiros en los cajeros automáticos que dispone el banco. En resumen, la forma cómo funciona la cuenta es muy sencilla. Podrás recibir depósitos a través de consignaciones hechas por medio de los canales que disponga el banco como oficinas, cajeros y la banca virtual. El dinero que está en tu cuenta, generará intereses de acuerdo a las tasas establecidas por el banco. Para retirar tu dinero, podrás usar la tarjeta débito que te entregará el banco.</p>";
    }
    ?>

</div>

</body>
</html>
