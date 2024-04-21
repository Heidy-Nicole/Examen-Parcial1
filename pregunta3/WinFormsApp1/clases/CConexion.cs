using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.clases
{
    internal class CConexion
    {
        MySqlConnection conex = new MySqlConnection();
        static string servidor = "localhost";
        static string bd = "BDheidy";
        static string usuario = "root";
        static string password = "";

        string cadenaConexion = "server=" + servidor + ";" + "user=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public MySqlConnection establecerConexion()
        {
            try
            {
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                //MessageBox.Show("se conecto a la bd");
            }
            catch(Exception ex)
            {
                MessageBox.Show("no se conecto la bd, error:" + ex.ToString());
            }
            return conex;
        }
        public void cerrarConexion()
        {
            conex.Close();
        }

    }
}