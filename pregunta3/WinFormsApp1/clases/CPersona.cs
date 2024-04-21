using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.clases
{
    internal class CPersona
    {
        public void mostrarPersonas(DataGridView tablaPersonas)
        {
           try{
                CConexion objetoConexion = new CConexion();

                String query = "SELECT * FROM persona";
                tablaPersonas.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaPersonas.DataSource = dt;
                objetoConexion.cerrarConexion();
            } 
            catch (Exception ex) { 
                MessageBox.Show("No muestra datos en la base de datos" + ex.ToString());
            }
        }
        public void guardarPersonas(TextBox nombre, TextBox apellido, TextBox edad, TextBox direccion)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "INSERT INTO persona (nombre,apellido,edad,direccion)"+"values ('"+nombre.Text+"','"+apellido.Text+"','"+edad.Text+"','"+direccion.Text+"');";
                

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
        public void seleccionarPersonas(DataGridView tablaPersonas, TextBox id, TextBox nombre, TextBox apellido, TextBox edad, TextBox direccion)
        {
            try
            {
                id.Text = tablaPersonas.CurrentRow.Cells[0].Value.ToString();
                nombre.Text = tablaPersonas.CurrentRow.Cells[1].Value.ToString();
                apellido.Text = tablaPersonas.CurrentRow.Cells[2].Value.ToString();
                edad.Text = tablaPersonas.CurrentRow.Cells[3].Value.ToString();
                direccion.Text = tablaPersonas.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo seleccionar datos" + ex.ToString());
            }
        }
        public void modificarPersonas(TextBox id,TextBox nombre, TextBox apellido, TextBox edad, TextBox direccion)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "UPDATE persona set nombre='"
                    + nombre.Text + "',apellido ='" + apellido.Text +
                    "',edad ='" + edad.Text + "',direccion ='" + direccion.Text + "' where id_per='" + id.Text + "';";


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
        public void eliminarPersonas(TextBox id)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "delete from  persona where id_per= '" + id.Text + "';";

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
