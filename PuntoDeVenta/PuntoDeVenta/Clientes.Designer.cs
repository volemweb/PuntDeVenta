namespace PuntoDeVenta
{
    partial class Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.puntoDeVentaDataSet = new PuntoDeVenta.PuntoDeVentaDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new PuntoDeVenta.PuntoDeVentaDataSetTableAdapters.clientesTableAdapter();
            this.tableAdapterManager = new PuntoDeVenta.PuntoDeVentaDataSetTableAdapters.TableAdapterManager();
            this.lblTituloClientes = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApelidos = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxApellidos = new System.Windows.Forms.TextBox();
            this.txtBoxDireccion = new System.Windows.Forms.TextBox();
            this.txtBoxTelefono = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTituloListadoClientes = new System.Windows.Forms.Label();
            this.clientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // puntoDeVentaDataSet
            // 
            this.puntoDeVentaDataSet.DataSetName = "PuntoDeVentaDataSet";
            this.puntoDeVentaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.puntoDeVentaDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.companiasTableAdapter = null;
            this.tableAdapterManager.impuestosTableAdapter = null;
            this.tableAdapterManager.lineasTableAdapter = null;
            this.tableAdapterManager.productosTableAdapter = null;
            this.tableAdapterManager.proveedoresTableAdapter = null;
            this.tableAdapterManager.tiposDePagoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PuntoDeVenta.PuntoDeVentaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ventasTableAdapter = null;
            // 
            // lblTituloClientes
            // 
            this.lblTituloClientes.AutoSize = true;
            this.lblTituloClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloClientes.Location = new System.Drawing.Point(65, 117);
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(218, 20);
            this.lblTituloClientes.TabIndex = 0;
            this.lblTituloClientes.Text = "FORMULARIO CLIENTES";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(52, 158);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(65, 16);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre *";
            // 
            // labelApelidos
            // 
            this.labelApelidos.AutoSize = true;
            this.labelApelidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApelidos.Location = new System.Drawing.Point(52, 182);
            this.labelApelidos.Name = "labelApelidos";
            this.labelApelidos.Size = new System.Drawing.Size(73, 16);
            this.labelApelidos.TabIndex = 2;
            this.labelApelidos.Text = "Apellidos *";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(52, 211);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(73, 16);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección *";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(52, 236);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(70, 16);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Telefono *";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(52, 264);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email *";
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(134, 155);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(158, 20);
            this.txtBoxNombre.TabIndex = 6;
            this.txtBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxNombre_KeyPress);
            // 
            // txtBoxApellidos
            // 
            this.txtBoxApellidos.Location = new System.Drawing.Point(134, 182);
            this.txtBoxApellidos.Name = "txtBoxApellidos";
            this.txtBoxApellidos.Size = new System.Drawing.Size(158, 20);
            this.txtBoxApellidos.TabIndex = 7;
            this.txtBoxApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxApellidos_KeyPress);
            // 
            // txtBoxDireccion
            // 
            this.txtBoxDireccion.Location = new System.Drawing.Point(134, 208);
            this.txtBoxDireccion.Name = "txtBoxDireccion";
            this.txtBoxDireccion.Size = new System.Drawing.Size(158, 20);
            this.txtBoxDireccion.TabIndex = 8;
            // 
            // txtBoxTelefono
            // 
            this.txtBoxTelefono.Location = new System.Drawing.Point(134, 235);
            this.txtBoxTelefono.Name = "txtBoxTelefono";
            this.txtBoxTelefono.Size = new System.Drawing.Size(158, 20);
            this.txtBoxTelefono.TabIndex = 9;
            this.txtBoxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTelefono_KeyPress);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(134, 264);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(158, 20);
            this.txtBoxEmail.TabIndex = 10;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(180, 305);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 23);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTituloListadoClientes
            // 
            this.lblTituloListadoClientes.AutoSize = true;
            this.lblTituloListadoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListadoClientes.Location = new System.Drawing.Point(498, 30);
            this.lblTituloListadoClientes.Name = "lblTituloListadoClientes";
            this.lblTituloListadoClientes.Size = new System.Drawing.Size(176, 20);
            this.lblTituloListadoClientes.TabIndex = 12;
            this.lblTituloListadoClientes.Text = "LISTADO CLIENTES";
            // 
            // clientesBindingSource1
            // 
            this.clientesBindingSource1.DataMember = "clientes";
            this.clientesBindingSource1.DataSource = this.puntoDeVentaDataSet;
            // 
            // clientesBindingSource2
            // 
            this.clientesBindingSource2.DataMember = "clientes";
            this.clientesBindingSource2.DataSource = this.puntoDeVentaDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(397, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(361, 300);
            this.dataGridView1.TabIndex = 13;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.nombreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombreDataGridViewTextBoxColumn.Width = 88;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidosDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidosDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(397, 385);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 23);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // Clientes
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 445);
            this.ControlBox = false;
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTituloListadoClientes);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxTelefono);
            this.Controls.Add(this.txtBoxDireccion);
            this.Controls.Add(this.txtBoxApellidos);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.labelApelidos);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.lblTituloClientes);
            this.MaximizeBox = false;
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.puntoDeVentaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PuntoDeVentaDataSet puntoDeVentaDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private PuntoDeVentaDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private PuntoDeVentaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblTituloClientes;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApelidos;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxApellidos;
        private System.Windows.Forms.TextBox txtBoxDireccion;
        private System.Windows.Forms.TextBox txtBoxTelefono;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTituloListadoClientes;
        private System.Windows.Forms.BindingSource clientesBindingSource1;
        private System.Windows.Forms.BindingSource clientesBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnModificar;
    }
}