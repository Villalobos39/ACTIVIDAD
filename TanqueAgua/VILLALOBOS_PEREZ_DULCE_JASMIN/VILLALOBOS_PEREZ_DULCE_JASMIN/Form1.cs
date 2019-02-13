using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VILLALOBOS_PEREZ_DULCE_JASMIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int progreso = 0; 

        private void button1_Click(object sender, EventArgs e)
        {
            if (progreso>=0 && progreso<=5000)
            {
                progreso += 100;
                Bnivel.Value = progreso;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (progreso >= 1 && progreso <= 5000)
            {
                progreso -= 100;
                Bnivel.Value = progreso;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progreso >= 0 && progreso <= 5000)
            {
                progreso += 50;
                Bnivel.Value = progreso;
            }
        }

        private void textBox1_AcceptsTabChanged(object sender, EventArgs e)
        {
         
        }

        private void label4_Click(object sender, EventArgs e)
        {
            textBox1.Text = progreso.ToString();
        }

      
    }
}
