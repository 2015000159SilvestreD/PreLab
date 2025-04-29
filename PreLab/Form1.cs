using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Al presionar el botón añade el numero 1 a la caja de texto
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "1";
        }
        //Al presionar el botón añade el numero 1 a la caja de texto
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "2";
        }
        //Al presionar el botón añade el numero 1 a la caja de texto
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "3";
        }
        //Al presionar el botón añade el numero 1 a la caja de texto
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "4";
        }
        //Al presionar el botón añade el numero 1 a la caja de texto
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "5";
        }
        //Al presionar el botón añade el numero 1 a la caja de texto
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "6";
        }
        //Al presionar el botón añade el numero 1 a la caja de texto
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "7";
        }
        //Al presionar el botón añade el numero 1 a la caja de texto
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "8";
        }
        //Al presionar el botón añade el numero 1 a la caja de texto
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "9";
        }
        //Al presionar el botón añade el numero 1 a la caja de texto
        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") textBox1.Text = "";
            textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        { //Si el texto contenido en la caja es igual a "527609"
            if (textBox1.Text == "527609")
            {//Se esconde el formulario y se abre la ventana 2
                this.Hide();
                Form2 c2 = new Form2();
                c2.Show();
            }
            else if (textBox1.Text == "")
            { //Si no se registra nada, pide por un MEssageBox que se ingrese la contraseña
                MessageBox.Show("Ingrese Contraseña");
            }
            else
            { //Si no se cumplen las condiciones anteriores, la contraseña es incorrecta
                MessageBox.Show("Contraseña Incorrecta");
            }
        }
    }
}
