using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejer4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnObtener_Click(object sender, EventArgs e)
        {
            await ObtenerDatos();
        }
        private async Task ObtenerDatos()
        {
            try
            {
                using (HttpClient cliente = new HttpClient())
                {
                    HttpResponseMessage respuestaPer = await cliente.GetAsync("http://localhost/Examen-Parcial1/Pregunta4/api1.php");
                    HttpResponseMessage respuestaCue = await cliente.GetAsync("http://localhost/Examen-Parcial1/Pregunta4/api2.php");
                    if (respuestaPer.IsSuccessStatusCode && respuestaCue.IsSuccessStatusCode)
                    {
                        string contenido = await respuestaPer.Content.ReadAsStringAsync();
                        string contenido2 = await respuestaCue.Content.ReadAsStringAsync();
                        var datos = JsonConvert.DeserializeObject<dynamic[]>(contenido);
                        var datos2 = JsonConvert.DeserializeObject<dynamic[]>(contenido2);
                        foreach (var dato in datos)
                        {
                            dgvPersona.Rows.Add(
                                dato.persona_id.ToString(),
                                dato.nombre.ToString(),
                                dato.ap_paterno.ToString(),
                                dato.ap_materno.ToString(),
                                dato.correo.ToString(),
                                dato.rol.ToString(),
                                dato.departamento.ToString()
                            );
                        }
                        foreach (var dato in datos2)
                        {
                            dgvCuenta.Rows.Add(
                                dato.cuentabancaria_id.ToString(),
                                dato.numero_cuenta.ToString(),
                                dato.saldo.ToString(),
                                dato.persona_id.ToString(),
                                dato.tipo.ToString()
                               
                            );
                        }


                    }
                    else
                    {
                        MessageBox.Show("Error al obtener los datos: " + respuestaPer.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvCuenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
