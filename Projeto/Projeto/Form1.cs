using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
           
        }

        public int somamatematica = 0;
        public int somaaplicacoesinformaticas = 0;
        public int somaportugues = 0;
        public int somafisica = 0;
        public int somaoutros = 0;
        public int somamusica = 0;
        public int somadesporto = 0;
        public int somaler = 0;
        public int somadormir = 0;
        public int somacomputador = 0;

        

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object primcomb = comboBox1.SelectedItem;
            string primeiro = Convert.ToString(primcomb);


           if (primeiro == "Estudar Matemática")
            {
                somamatematica++;
            }
            else if(primeiro == "Estudar Física")
            {
                somafisica++;
            }
            else if (primeiro == "Estudar Português")
            { 
            }
            else if (primeiro == "Estudar Aplicações informáticas")
            {
                somaaplicacoesinformaticas++;
            }
            else if (primeiro == "Ler")
            {
            }
            else if (primeiro == "Dormir")
            {
            }
            else if (primeiro == "Desporto")
            {
            }
            else if (primeiro == "Música")
            { 
            }
            else if (primeiro == "Outros")
            {

            }
            else if (primeiro == "Computador")
            {
                somacomputador += 1;
            }




        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
       private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox32_SelectedIndexChanged(object sender, EventArgs e)
        {
            object segcomb = comboBox32.SelectedItem;
            string segundo = Convert.ToString(segcomb);


            if (segundo == "Estudar Matemática")
            {
                somamatematica++;
            }
            else if (segundo == "Estudar Física")
            {
                somafisica++;
            }
            else if (segundo == "Estudar Português")
            {
            }
            else if (segundo == "Estudar Aplicações informáticas")
            {
                somaaplicacoesinformaticas++;
            }
            else if (segundo == "Ler")
            {
            }
            else if (segundo == "Dormir")
            {
            }
            else if (segundo == "Desporto")
            {
            }
            else if (segundo == "Música")
            {
            }
            else if (segundo == "Outros")
            {

            }
            else if (segundo == "Computador")
            {
                somacomputador++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 frm2 = new Form2();

            frm2.Show();

            frm2.a1 = somamatematica;



        }

        private void comboBox33_SelectedIndexChanged(object sender, EventArgs e)
        {
            object tercomb = comboBox33.SelectedItem;
            string terceiro = Convert.ToString(tercomb);


            if (terceiro == "Estudar Matemática")
            {
                somamatematica++;
            }
            else if (terceiro == "Estudar Física")
            {
                somafisica++;
            }
            else if (terceiro == "Estudar Português")
            {
            }
            else if (terceiro == "Estudar Aplicações informáticas")
            {
                somaaplicacoesinformaticas++;
            }
            else if (terceiro == "Ler")
            {
            }
            else if (terceiro == "Dormir")
            {
            }
            else if (terceiro == "Desporto")
            {
            }
            else if (terceiro == "Música")
            {
            }
            else if (terceiro == "Outros")
            {

            }
            else if (terceiro == "Computador")
            {
                somacomputador++;
            }
        }
    }
}
