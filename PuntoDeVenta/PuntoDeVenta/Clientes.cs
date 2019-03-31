using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PuntoDeVenta.Models;  // es aixi perque he canviat el namespace del la clase cliente

namespace PuntoDeVenta
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.puntoDeVentaDataSet);

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'puntoDeVentaDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.puntoDeVentaDataSet.clientes);

            Cliente entradaCliente = new Cliente(txtBoxNombre.Text,txtBoxApellidos.Text,txtBoxDireccion.Text,txtBoxTelefono.Text,txtBoxEmail.Text);


        }
    }
}
