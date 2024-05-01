<?php

use CodeIgniter\Router\RouteCollection;

/**
 * @var RouteCollection $routes
 */
$routes->get('/', 'mostrarController::index');
$routes->get('cuentas', 'mostrarController::index');
$routes->post('mostrar/eliminar', 'mostrarController::eliminar');
$routes->post('login', 'loginController::index');
$routes->post('sesion', 'loginController::login');
$routes->get('director', 'directorController::index');
$routes->get('cliente', 'clienteController::index');
