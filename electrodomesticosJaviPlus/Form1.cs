using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace electrodomesticosJaviPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new almacen().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new clientes().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new facturas().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new calculadora().ShowDialog();
        }
    }
}
