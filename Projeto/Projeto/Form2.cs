using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Form2 : Form
    {
        
        
        public Form2()
        {
            InitializeComponent();            
        }

        public int a1=0;        

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {          
            textBox1.Text = Convert.ToString(a1);           
        }


    }
}
