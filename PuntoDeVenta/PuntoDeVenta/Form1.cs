using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuntoDeVenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblEstat.Text = "Programa Iniciado";
        }

        private void btnSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //He inicializado el formulario en InitializeComponent()
            if (this.clientes == null)
            {
                clientes = new Clientes();
                clientes.MdiParent = this;
                clientes.Show();
                clientes.WindowState = FormWindowState.Maximized;
            }
            else { clientes.Focus(); clientes.WindowState = FormWindowState.Maximized; }    
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //He inicializado el formulario en InitializeComponent()
            if (this.caja == null)
            {
                caja = new Caja();
                caja.MdiParent = this;
                caja.Show();
                caja.WindowState = FormWindowState.Maximized;
            }
            else { caja.Focus(); caja.WindowState = FormWindowState.Maximized; }

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //He inicializado el formulario en InitializeComponent()
            if (this.productos == null)
            {
                productos = new Productos();
                productos.MdiParent = this;
                productos.Show();
                productos.WindowState = FormWindowState.Maximized;
            }
            else { productos.Focus(); productos.WindowState = FormWindowState.Maximized; }
        }
    }
}
