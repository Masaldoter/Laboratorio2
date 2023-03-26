using Laboratorio2.Clases;
using Laboratorio2.Properties;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Laboratorio2
{
    public partial class Form1 : Form
    {
        Perro perro = new Perro();
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            perro.setRaza("PASTOR AUSTRALIANO");
            label1.Text = perro.Comer();
            pictureBox1.Image = Properties.Resources.PERRO_COMIENDO;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            perro.setRaza("PASTOR AUSTRALIANO");
            label1.Text = perro.Respirar("SÍ");
            pictureBox1.Image = Properties.Resources.pastor_ganadero_australiano;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            perro.setRaza("PASTOR AUSTRALIANO");
            label1.Text = perro.Ladrar();
            pictureBox1.Image = Properties.Resources.PERRO_LADRANDO;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            perro.setRaza("PASTOR AUSTRALIANO");
            label1.Text = perro.Correr();
            pictureBox1.Image = Properties.Resources.PERRO_CORRIENDO;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            perro.setNombre(textBox1.Text);
        }
    }
}