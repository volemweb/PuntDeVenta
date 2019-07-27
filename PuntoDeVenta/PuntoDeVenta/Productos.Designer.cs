namespace PuntoDeVenta
{
    partial class Productos
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
            this.btnDescargarProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDescargarProductos
            // 
            this.btnDescargarProductos.Location = new System.Drawing.Point(141, 83);
            this.btnDescargarProductos.Name = "btnDescargarProductos";
            this.btnDescargarProductos.Size = new System.Drawing.Size(216, 23);
            this.btnDescargarProductos.TabIndex = 0;
            this.btnDescargarProductos.Text = "Descargar Productos";
            this.btnDescargarProductos.UseVisualStyleBackColor = true;
            this.btnDescargarProductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 261);
            this.ControlBox = false;
            this.Controls.Add(this.btnDescargarProductos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Productos";
            this.Text = "Productos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDescargarProductos;
    }
}