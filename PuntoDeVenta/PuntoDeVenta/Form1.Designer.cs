namespace PuntoDeVenta
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.btnSortir = new System.Windows.Forms.Button();
            this.lblEstat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.Location = new System.Drawing.Point(34, 42);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(200, 20);
            this.lblTituloPrincipal.TabIndex = 0;
            this.lblTituloPrincipal.Text = "Punt De Venta Volem Web";
            // 
            // btnSortir
            // 
            this.btnSortir.Location = new System.Drawing.Point(312, 309);
            this.btnSortir.Name = "btnSortir";
            this.btnSortir.Size = new System.Drawing.Size(120, 23);
            this.btnSortir.TabIndex = 1;
            this.btnSortir.Text = "SORTIR";
            this.btnSortir.UseVisualStyleBackColor = true;
            this.btnSortir.Click += new System.EventHandler(this.btnSortir_Click);
            // 
            // lblEstat
            // 
            this.lblEstat.AutoSize = true;
            this.lblEstat.Location = new System.Drawing.Point(35, 319);
            this.lblEstat.Name = "lblEstat";
            this.lblEstat.Size = new System.Drawing.Size(97, 13);
            this.lblEstat.TabIndex = 2;
            this.lblEstat.Text = "Infromació Accions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 353);
            this.Controls.Add(this.lblEstat);
            this.Controls.Add(this.btnSortir);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Name = "Form1";
            this.Text = "Punt de Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Button btnSortir;
        private System.Windows.Forms.Label lblEstat;
    }
}

