<?php
//crea un controlador para cliente donde muestre los datos
namespace App\Controllers;

use App\Models\persona_modelo;

class clienteController extends BaseController
{
    public function index()
    {
        $usuario = session('data');
        $persona = new persona_modelo();
        $datos = $persona->where('correo', $usuario['correo'])->first();
        $data = [
            'datos' => $datos
        ];
        return view('clienteView', $data);
    }
}
?>