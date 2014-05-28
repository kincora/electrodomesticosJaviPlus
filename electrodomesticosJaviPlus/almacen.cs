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
    public partial class almacen : Form
    {
        public almacen()
        {
            InitializeComponent();
        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database3DataSet);

        }

        private void almacen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database3DataSet.Producto' Puede moverla o quitarla según sea necesario.
            //this.productoTableAdapter.Fill(this.database3DataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'database3DataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.database3DataSet.Producto);

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.productoTableAdapter.FillBynombre(this.database3DataSet.Producto, nombreTextBox.Text);
        }

        private void productoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.productoTableAdapter.Fill(this.database3DataSet.Producto);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //apretando este boton guarda los datos en la base de datos
        }

      



    }
}
