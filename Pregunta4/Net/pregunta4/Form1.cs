using Newtonsoft.Json;

namespace Ejer4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    HttpResponseMessage resPersona = await cliente.GetAsync("http://localhost/examen-Parcial1/Pregunta4/api1.php");
                    HttpResponseMessage resCuenta = await cliente.GetAsync("http://localhost/examen-Parcial1/Pregunta4/api2.php");

                    if (resCuenta.IsSuccessStatusCode && resCuenta.IsSuccessStatusCode)
                    {
                        string cont1 = await resPersona.Content.ReadAsStringAsync();
                        string cont2 = await resCuenta.Content.ReadAsStringAsync();

                        var dat1 = JsonConvert.DeserializeObject<dynamic[]>(cont1);
                        var dat2 = JsonConvert.DeserializeObject<dynamic[]>(cont2);

                        foreach (var dato in dat1)
                        {
                            dgvPersona.Rows.Add(
                                dato.carnet.ToString(),
                                dato.nombre.ToString(),
                                dato.apellido.ToString(),
                                dato.departamento.ToString(),
                                dato.correo.ToString(),
                                dato.tipo.ToString()
                            );
                        }

                        foreach (var dato in dat2)
                        {
                            dgvCuentas.Rows.Add(
                                dato.id_cuenta.ToString(),
                                dato.carnet.ToString(),
                                dato.tipo.ToString(),
                                dato.monto.ToString()

                                );
                        }

                    }
                    else
                    {
                        MessageBox.Show("Error al obtener datos " + resCuenta.ReasonPhrase + " " + resPersona.ReasonPhrase);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
