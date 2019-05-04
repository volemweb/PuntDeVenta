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
        ValidarFormulario validar = new ValidarFormulario();

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

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCamps())
            {

                try
                {
                    //this.clientesTableAdapter.Insert(txtBoxNombre.Text, txtBoxApellidos.Text, txtBoxDireccion.Text, txtBoxTelefono.Text, txtBoxEmail.Text);
                }
                catch
                {
                    MessageBox.Show("Error al gurdar los datos!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                borrarDades();

                MessageBox.Show("Datos guardados corretamente!!", "Guardado", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Nu puede haber ningún campo en blanco y el email tiene que ser valido.");
            }
            
        }

        public void borrarDades()
        {
            txtBoxNombre.Text = "";
            txtBoxApellidos.Text = "";
            txtBoxDireccion.Text = "";
            txtBoxTelefono.Text = "";
            txtBoxEmail.Text = "";
        }

        public  bool validarCamps()
        {
            bool validat = false;

            if (txtBoxNombre.Text.Length < 1 || txtBoxDireccion.Text.Length < 1 || txtBoxDireccion.Text.Length < 1 || txtBoxTelefono.Text.Length < 1 || txtBoxEmail.Text.Length < 1 || validar.esEmail(txtBoxEmail.Text)==false)
            {
                txtBoxNombre.Focus();
            }
            else
            { validat = true; }

                 
            return validat;
        }

        private void txtBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e);
        }

        private void txtBoxApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloLetras(e);
        }

        private void txtBoxTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.soloNumeros(e);
        }

    }
}
