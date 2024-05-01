<?php
//crea un controlador para un login ten en cuenta que el correo esta en persona y solo usamos corre
namespace App\Controllers;

use App\Models\persona_modelo;
use CodeIgniter\Controller;

class loginController extends Controller
{
    public function index()
    {
        return view('loginView');
    }

    public function login()
    {
       $correo = $this->request->getPost('email');
        $persona = new persona_modelo();
        $usuariovalidado = $persona->where('correo', $correo)->first();
        echo $usuariovalidado['rol'];
        if ($usuariovalidado != null) {
            if ($usuariovalidado['rol'] == 'Director bancario') {
                echo "aaaaaaaaaa";
                return redirect()->to('director')->with('data', $usuariovalidado);
            }
            else{
                return redirect()->to('cliente')->with('data', $usuariovalidado);
            }
        }
        
        else{
            return redirect()->to('loginView');
        }
    }
}
      
