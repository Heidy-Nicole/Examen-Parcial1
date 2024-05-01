using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServicioWebSoapClient ws = new ServiceReference1.ServicioWebSoapClient();
            ws.ModificarPersona(Convert.ToInt16( textBox1.Text),textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,textBox6.Text,textBox7.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServicioWebSoapClient ag = new ServiceReference1.ServicioWebSoapClient();
            ag.AgregarPersonaAsync(textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.ServicioWebSoapClient el = new ServiceReference1.ServicioWebSoapClient();
            el.EliminarPersonaAsync(Convert.ToInt16(textBox14.Text));
        }
    }
}
