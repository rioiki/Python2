using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TRABAJO
{
    public partial class Form1 : Form


    {
        private Cliente cliente;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Cliente cli = new Cliente
            {
                nombre = textBox2.Text,
                documento = textBox1.Text,
                edad = comboBox6.Text,
                razón_social = comboBox4.Text,
                estado_civil = comboBox1.Text,
                estrato = comboEstrato.Text,
                ocupación = checkedListBox2.Text,
                tipo_contrato = comboBox2.Text,
                antigüedad_laboral = comboAntiguedad.Text,
                tipo_vivienda = checkedListBox3.Text,
                nivelEducativo = checkedListBox1.Text,
                personaAcargo = comboBox3.Text,
                tipo_documento = comboDocumento.Text,
                productoSolicitado = comboBox7.Text,
                calificacionCentralesRiesgo = comboBox8.Text,

            };
            labelMuestra.Text = cli.nombre + "\n" + cli.documento + "\n" + cli.edad + "\n" + cli.razón_social + "\n" + cli.estado_civil + "\n" + cli.estrato + "\n" + cli.ocupación + "\n"
                + cli.tipo_contrato + "\n" + cli.antigüedad_laboral + "\n" + cli.tipo_vivienda + "\n" + cli.nivelEducativo + "\n" + cli.personaAcargo
                + "\n" + cli.tipo_documento + "\n" + cli.productoSolicitado + "\n" + "\n" + cli.calificacionCentralesRiesgo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente
            {
                nombre = textBox2.Text,
                documento = textBox1.Text,
                // Otras propiedades...

                // Convertir ingresos y egresos a double
                Ingresos = double.TryParse(checkedListBox4.Text, out double ingresos) ? ingresos : 0.0,
                Egresos = double.TryParse(checkedListBox5.Text, out double egresos) ? egresos : 0.0,

                // Otras propiedades...

            };

            labelCalculo.Text = cli.ingresos + "\n" + cli.egresos;

        }

    }
}
