using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.clases
{
    internal class CCuenta
    {
        public void mostrarCuenta(DataGridView tablaCuentas)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "SELECT * FROM cuentabancaria";
                tablaCuentas.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaCuentas.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No muestra datos en la base de datos" + ex.ToString());
            }
        }
        public void guardarCuentas(TextBox id_per , TextBox numero_cuenta, TextBox saldo, TextBox tipo_cuenta)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "INSERT INTO cuentabancaria (id_per,numero_cuenta,saldo,tipo_cuenta)" + "values ('" + id_per.Text + "','" + numero_cuenta.Text + "','" + saldo.Text + "','" + tipo_cuenta.Text + "');";


                MySqlCommand mycomando = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mycomando.ExecuteReader();
                MessageBox.Show("Datos guardados");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No muestra datos en la base de datos" + ex.ToString());
            }
        }
        public void seleccionarCuenta(DataGridView tablaCuentas, TextBox id_cuen, TextBox id_per, TextBox numero_cuenta, TextBox saldo, TextBox tipo_cuenta)
        {
            try
            {
                id_cuen.Text = tablaCuentas.CurrentRow.Cells[0].Value.ToString();
                id_per.Text = tablaCuentas.CurrentRow.Cells[1].Value.ToString();
                numero_cuenta.Text = tablaCuentas.CurrentRow.Cells[2].Value.ToString();
                saldo.Text = tablaCuentas.CurrentRow.Cells[3].Value.ToString();
                tipo_cuenta.Text = tablaCuentas.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo seleccionar datos" + ex.ToString());
            }
        }
        public void modificarCuentas(TextBox id_cuen, TextBox id_per, TextBox numero_cuenta, TextBox saldo, TextBox tipo_cuenta)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "UPDATE cuentabancaria set id_per='"
                    + id_per.Text + 
                    "',numero_cuenta ='" + numero_cuenta.Text + "',saldo ='" + saldo.Text + "',tipo_cuenta ='" + tipo_cuenta.Text + "' where id_cuen='" + id_cuen.Text + "';";


                MySqlCommand mycomando = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mycomando.ExecuteReader();
                MessageBox.Show("Datos modificados");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se modifico loss datos" + ex.ToString());
            }
        }
        public void eliminarCuentas(TextBox idcuen)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "delete from  cuentabancaria where id_cuen= '" + idcuen.Text + "';";

                MySqlCommand mycomando = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mycomando.ExecuteReader();
                MessageBox.Show("Sel eliminaron datos");
                while (reader.Read())
                {

                }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se elimino los datos" + ex.ToString());
            }
        }
    }
}
