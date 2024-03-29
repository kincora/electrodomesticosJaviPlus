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
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database3DataSet);

        }

        private void clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database3DataSet.Clientes' Puede moverla o quitarla según sea necesario.
           // this.clientesTableAdapter.Fill(this.database3DataSet.Clientes);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.FillByNombre(database3DataSet.Clientes,nombreTextBox.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void apellidoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.database3DataSet.Clientes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aqui deberia haber un codigo el cual nos permitiera poder guardar un cliente en la base de datos
            this.clientesTableAdapter.Insert(nombreTextBox.Text, apellidoTextBox.Text, int.Parse(dNITextBox.Text), int.Parse(telefonoTextBox.Text), direccionTextBox.Text, emailTextBox.Text);
        }
    }
}
