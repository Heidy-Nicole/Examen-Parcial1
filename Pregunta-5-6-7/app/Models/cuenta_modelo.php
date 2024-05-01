<?php
//crea un modelo para cuentabancarias con los siguientes datos: cuentabancaria_id(llave primaria),numero_cuenta,saldo,persona_id,tipo
namespace App\Models;

use CodeIgniter\Model;

class cuenta_modelo extends Model
{
    protected $table      = 'cuentabancarias';
    protected $primaryKey = 'cuentabancaria_id';

    protected $returnType     = 'array';
    protected $useSoftDeletes = false;

    protected $allowedFields = ['cuentabancaria_id','numero_cuenta', 'saldo', 'persona_id', 'tipo'];

    protected $validationRules    = [];
    protected $validationMessages = [];
    protected $skipValidation     = false;
}

