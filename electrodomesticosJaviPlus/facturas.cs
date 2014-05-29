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
    public partial class facturas : Form
    {
        public facturas()
        {
            InitializeComponent();
        }

        private void facturaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facturaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database3DataSet);

        }

        private void facturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database3DataSet.Producto' Puede moverla o quitarla según sea necesario.
            //this.productoTableAdapter.Fill(this.database3DataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'database3DataSet.Clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.database3DataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'database3DataSet.Factura' Puede moverla o quitarla según sea necesario.
            // this.facturaTableAdapter.Fill(this.database3DataSet.Factura);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //para que rellene los campos del cliente al pulsar el boton buscar
            this.clientesTableAdapter.FillByNombreBeatriz(this.database3DataSet.Clientes, nombreTextBox1.Text);
            //para que rellene los campos del producto al pulsar el boton buscar

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //para que rellene los campos del producto al pulsar el boton buscar

            this.productoTableAdapter.FillByNombreBeatriz(this.database3DataSet.Producto, nombreTextBox.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //calculamos el total
            int total= int.Parse(textBox2.Text)*int.Parse(precioTextBox.Text);
            textBox1.Text = Convert.ToString(total);
            //añadimos los datos a la factura:
            
        }

      
    }
}