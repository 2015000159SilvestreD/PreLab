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
    public partial class Form2 : Form
    {
        private int pos; //Variable general que se usará para obtener los items en las celdas

        public Form2()
        {
            InitializeComponent();
        }
        private void limpiarTxt() //Método para limpiar las cajas de texto
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
        }
        // Botón de cambio de ventana a los créditos
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 c3 = new Form3();
            c3.Show();
        }
        // Botón añadir
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(textBox1.Text, //Añade en las filas el contenido de las 
                                   textBox2.Text, // cajas de texto
                                   textBox3.Text,
                                   textBox4.Text,
                                   textBox5.Text,
                                   textBox6.Text,
                                   textBox7.Text,
                                   textBox8.Text,
                                   textBox9.Text,
                                   textBox10.Text,
                                   textBox11.Text);
            limpiarTxt(); //limpia las cajas
            textBox1.Focus(); //Centra al usuario en la textBox1 para volver a ingresar datos
        }
        // Botón Editar
        private void button2_Click(object sender, EventArgs e)
        {
            //Se declara la variable "pos" para que obtenga el indice de las celdas en una fila 
            pos = dataGridView1.CurrentCell.RowIndex;
            //Crea el control "newdata" en la fila seleccionada del dataGridView
            DataGridViewRow newdata = dataGridView1.Rows[pos];

            //Establece el contenido de la tabla en cada caja de texto usando el control y la variable
            newdata.Cells[0].Value = textBox1.Text;
            newdata.Cells[1].Value = textBox2.Text;
            newdata.Cells[2].Value = textBox3.Text;
            newdata.Cells[3].Value = textBox4.Text;
            newdata.Cells[4].Value = textBox5.Text;
            newdata.Cells[5].Value = textBox6.Text;
            newdata.Cells[6].Value = textBox7.Text;
            newdata.Cells[7].Value = textBox8.Text;
            newdata.Cells[8].Value = textBox9.Text;
            newdata.Cells[9].Value = textBox10.Text;
            newdata.Cells[10].Value = textBox11.Text;
            limpiarTxt(); //limpia las cajas de texto
            textBox1.Focus(); //centra al usuario en el textBox1
        }
        //Al darle click a una celda
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Se declara la variable "pos" para que obtenga el indice de las celdas en una fila
            pos = dataGridView1.CurrentCell.RowIndex;

            //Convierte los objetos en las posiciones de la fila y las conviente a variable de texto
            textBox1.Text = dataGridView1[0, pos].Value.ToString();
            textBox2.Text = dataGridView1[1, pos].Value.ToString();
            textBox3.Text = dataGridView1[2, pos].Value.ToString();
            textBox4.Text = dataGridView1[3, pos].Value.ToString();
            textBox5.Text = dataGridView1[4, pos].Value.ToString();
            textBox6.Text = dataGridView1[5, pos].Value.ToString();
            textBox7.Text = dataGridView1[6, pos].Value.ToString();
            textBox8.Text = dataGridView1[7, pos].Value.ToString();
            textBox9.Text = dataGridView1[8, pos].Value.ToString();
            textBox10.Text = dataGridView1[9, pos].Value.ToString();
            textBox11.Text = dataGridView1[10, pos].Value.ToString();
        }
        //Boton Eliminar
        private void button3_Click(object sender, EventArgs e)
        {
            //Se declara la variable "pos" para que obtenga el indice de las celdas en una fila 
            pos = dataGridView1.CurrentCell.RowIndex;

            //Elimina la fila entera de la célda seleccionara
            dataGridView1.Rows.RemoveAt(pos);
            limpiarTxt(); //limpiar las cajas
            textBox1.Focus(); //centrar a la textBox1
        }
    }
}
