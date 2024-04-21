namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            clases.CPersona objetoPersona = new clases.CPersona();
            objetoPersona.mostrarPersonas(dgvPersona);
            clases.CCuenta objetoCuenta = new clases.CCuenta();
            objetoCuenta.mostrarCuenta(dgvCuenta);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            clases.CPersona objetoPersona = new clases.CPersona();
            objetoPersona.guardarPersonas(txtnombre, txtapellido, txtedad, txtdireccion);
            objetoPersona.mostrarPersonas(dgvPersona);
        }

        private void dgvPersona_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clases.CPersona objetoPersona = new clases.CPersona();
            objetoPersona.seleccionarPersonas(dgvPersona, txtid, txtnombre, txtapellido, txtedad, txtdireccion);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            clases.CPersona objetoPersona = new clases.CPersona();
            objetoPersona.modificarPersonas(txtid, txtnombre, txtapellido, txtedad, txtdireccion);
            objetoPersona.mostrarPersonas(dgvPersona);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            clases.CPersona objetoPersona = new clases.CPersona();
            objetoPersona.eliminarPersonas(txtid);
            objetoPersona.mostrarPersonas(dgvPersona);
        }

        private void btnguardarcuenta_Click(object sender, EventArgs e)
        {
            clases.CCuenta objetoCuenta = new clases.CCuenta();
            objetoCuenta.guardarCuentas(txtidPersona, txtnumero, txtsaldo, txttipo);
            objetoCuenta.mostrarCuenta(dgvCuenta);
        }



        private void btnmodificarcuenta_Click(object sender, EventArgs e)
        {
            clases.CCuenta objetoCuenta = new clases.CCuenta();
            objetoCuenta.modificarCuentas(txtidcuenta, txtidPersona, txtnumero, txtsaldo, txttipo);
            objetoCuenta.mostrarCuenta(dgvCuenta);
        }

        private void dgvCuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clases.CCuenta objetoCuenta = new clases.CCuenta();
            objetoCuenta.seleccionarCuenta(dgvCuenta, txtidcuenta, txtidPersona, txtnumero, txtsaldo, txttipo);
        }

        private void btneliminarcuenta_Click(object sender, EventArgs e)
        {
            clases.CCuenta objetoCuenta = new clases.CCuenta();
            objetoCuenta.eliminarCuentas(txtidcuenta);
            objetoCuenta.mostrarCuenta(dgvCuenta);
        }
    }
}
