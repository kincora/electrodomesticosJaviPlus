﻿using System;
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
            this.productoTableAdapter.Fill(this.database3DataSet.Producto);

        }
    }
}
