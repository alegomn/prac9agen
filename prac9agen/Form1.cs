using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac9agen
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (lista.Columns.Count == 0)
            {
                lista.ColumnCount = 5;
                lista.Columns[0].Name = "Nombre";
                lista.Columns[1].Name = "Apellidos";
                lista.Columns[2].Name = "Telefono";
                lista.Columns[3].Name = "Direccion";
                lista.Columns[4].Name = "Email";
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (lista.Columns.Count == 0)
            {
                lista.ColumnCount = 5;
                lista.Columns[0].Name = "Nombre";
                lista.Columns[1].Name = "Apellidos";
                lista.Columns[2].Name = "Telefono";
                lista.Columns[3].Name = "Direccion";
                lista.Columns[4].Name = "Email";
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Escribe el nombre");
                return;
            }

            lista.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (lista.SelectedRows.Count > 0)
            {
                lista.Rows.RemoveAt(lista.SelectedRows[0].Index);
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

      
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Todos los archivos|*.*";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Seleccionaste: " + abrir.FileName);

                textBox4.Text = abrir.FileName;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
} 