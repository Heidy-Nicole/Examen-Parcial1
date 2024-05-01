<?php
//haz un modelo para persona tiene los siguientes datos: persona_id(llave primaria),nombre,ap_paterno,ap_materno,rol,departamento
namespace App\Models;

use CodeIgniter\Model;

class persona_modelo extends Model
{
    protected $table      = 'personas';
    protected $primaryKey = 'persona_id';

    protected $returnType     = 'array';
    protected $useSoftDeletes = false;

    protected $allowedFields = ['persona_id','nombre', 'ap_paterno', 'ap_materno', 'rol', 'departamento','correo'];

    protected $validationRules    = [];
    protected $validationMessages = [];
    protected $skipValidation     = false;
}