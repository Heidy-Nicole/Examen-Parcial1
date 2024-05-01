<?php
//crea un controlador para mostrar los datos de lacuenta en la  base de datos   
namespace App\Controllers;

use App\Models\cuenta_modelo;
use App\Models\persona_modelo;

class mostrarController extends BaseController
{
    public function index()
    {
        $cuentaModel = new cuenta_modelo();
        $personaModel = new persona_modelo();
        $cuentas = $cuentaModel->findAll();
        $personas = $personaModel->findAll();
        $data = [
            'cuentas' => $cuentas,
            'personas' => $personas
        ];
        return view('mostrar', $data);
    }

    //funcion para eliminar una cuenta con el id
    public function eliminar()
    {
        $cuentaModel = new cuenta_modelo();
        $id = $this->request->getPost('id');
        $cuentaModel->delete($id);
        return redirect()->to(base_url('public/cuentas'));
    }

    
}
?>

