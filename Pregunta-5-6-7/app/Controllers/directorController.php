<?php
//crea un controlador de director que muestre los datos de director bancario

namespace App\Controllers;

use App\Models\persona_modelo;

class directorController extends BaseController
{
    public function index()
    {
       


       $usuario = session('data');
       $persona = new persona_modelo();
        

       $datos = $persona->where('correo', $usuario['correo'])->first();

         $data = [
              'datos' => $datos
         ];     
         
         
      $tablita = $persona->query("
      SELECT 
      sum(CASE when departamento= 'Potosi' then saldo else 0 end)as Potosi,
      sum(CASE when departamento= 'La Paz' then saldo else 0 end)as La_Paz,
      sum(CASE when departamento= 'Cochabamba' then saldo else 0 end)as Cochabamba,
      sum(CASE when departamento= 'Oruro' then saldo else 0 end)as Oruro,
      sum(CASE when departamento= 'Beni' then saldo else 0 end)as Beni,
      sum(CASE when departamento= 'Tarija' then saldo else 0 end)as Tarija,
      sum(CASE when departamento= 'Chuquisaca' then saldo else 0 end)as Chuquisaca,
      sum(CASE when departamento= 'Santa Cruz' then saldo else 0 end)as Santa_Cruz,
      sum(CASE when departamento= 'Pando' then saldo else 0 end)as Pando
          
      FROM personas JOIN cuentabancarias on personas.persona_id = cuentabancarias.persona_id")->getResultArray();

        $data['tabla'] = $tablita[0];

  
       return view('directorView', $data);
    }
}