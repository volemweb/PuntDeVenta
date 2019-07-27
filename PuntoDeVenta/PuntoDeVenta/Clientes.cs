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

        int modificar = 0;

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

            //NoTas : Para que un dataGrid no se puedan cambiar el alto de las celdas es tiene que poner la 
            //AllowUserToResizeColumns = False ; AllowUserToResizeRows = false;

            // MessageBox.Show(dataGridView1.CurrentCell.Value.ToString()); *Ver la celda seleccionada


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCamps())
            {

                try
                {
                    if (modificar == 0)
                    {

                        this.clientesTableAdapter.Insert(txtBoxNombre.Text, txtBoxApellidos.Text, txtBoxDireccion.Text, txtBoxTelefono.Text, txtBoxEmail.Text);

                        MessageBox.Show("Datos guardados correctamente!!", "Guardado", MessageBoxButtons.OK);

                        this.clientesTableAdapter.Fill(this.puntoDeVentaDataSet.clientes);
                    }
                    else
                    {
                        int idCliente = int.Parse(dataGridView1["IdClientes", dataGridView1.CurrentRow.Index].Value.ToString());

                        this.clientesTableAdapter.UpdateQuery(txtBoxNombre.Text, txtBoxApellidos.Text, txtBoxDireccion.Text, txtBoxTelefono.Text, txtBoxEmail.Text, idCliente);

                        MessageBox.Show("Datos modificados correctamente!!", "Guardado", MessageBoxButtons.OK);

                        this.clientesTableAdapter.Fill(this.puntoDeVentaDataSet.clientes);

                        modificar = 0;
                    }
             
                }
                catch
                {
                    MessageBox.Show("Error al guardar o modificar los datos!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                borrarDades();

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


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            modificar = 1;

            txtBoxNombre.Text = dataGridView1["Nombre", dataGridView1.CurrentRow.Index].Value.ToString();
            txtBoxApellidos.Text = dataGridView1["Apellidos", dataGridView1.CurrentRow.Index].Value.ToString();
            txtBoxDireccion.Text = dataGridView1["Direccion", dataGridView1.CurrentRow.Index].Value.ToString();
            txtBoxTelefono.Text = dataGridView1["Telefono", dataGridView1.CurrentRow.Index].Value.ToString();
            txtBoxEmail.Text = dataGridView1["Email", dataGridView1.CurrentRow.Index].Value.ToString();

        }

        private void btnClienteNuevo_Click(object sender, EventArgs e)
        {
            modificar = 0;

            borrarDades();
        }
    }
}
