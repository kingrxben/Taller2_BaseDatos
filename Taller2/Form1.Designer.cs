namespace Taller2
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
            this.label1 = new System.Windows.Forms.Label();
            this.VerClientes = new System.Windows.Forms.Button();
            this.Prueba = new System.Windows.Forms.Button();
            this.VerProductos = new System.Windows.Forms.Button();
            this.ClienteLabel = new System.Windows.Forms.Label();
            this.ProductoLabel = new System.Windows.Forms.Label();
            this.VentasLabel = new System.Windows.Forms.Label();
            this.VerVentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú Principal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VerClientes
            // 
            this.VerClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VerClientes.Location = new System.Drawing.Point(126, 220);
            this.VerClientes.Name = "VerClientes";
            this.VerClientes.Size = new System.Drawing.Size(90, 40);
            this.VerClientes.TabIndex = 1;
            this.VerClientes.Text = "Ver";
            this.VerClientes.UseVisualStyleBackColor = true;
            this.VerClientes.Click += new System.EventHandler(this.VerClientes_Click);
            // 
            // Prueba
            // 
            this.Prueba.Location = new System.Drawing.Point(0, 0);
            this.Prueba.Name = "Prueba";
            this.Prueba.Size = new System.Drawing.Size(75, 23);
            this.Prueba.TabIndex = 0;
            // 
            // VerProductos
            // 
            this.VerProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VerProductos.Location = new System.Drawing.Point(345, 220);
            this.VerProductos.Name = "VerProductos";
            this.VerProductos.Size = new System.Drawing.Size(90, 40);
            this.VerProductos.TabIndex = 2;
            this.VerProductos.Text = "Ver";
            this.VerProductos.UseVisualStyleBackColor = true;
            this.VerProductos.Click += new System.EventHandler(this.VerProductos_Click);
            // 
            // ClienteLabel
            // 
            this.ClienteLabel.AutoSize = true;
            this.ClienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ClienteLabel.Location = new System.Drawing.Point(133, 175);
            this.ClienteLabel.Name = "ClienteLabel";
            this.ClienteLabel.Size = new System.Drawing.Size(83, 25);
            this.ClienteLabel.TabIndex = 3;
            this.ClienteLabel.Text = "Clientes";
            // 
            // ProductoLabel
            // 
            this.ProductoLabel.AutoSize = true;
            this.ProductoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProductoLabel.Location = new System.Drawing.Point(340, 175);
            this.ProductoLabel.Name = "ProductoLabel";
            this.ProductoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ProductoLabel.Size = new System.Drawing.Size(100, 25);
            this.ProductoLabel.TabIndex = 4;
            this.ProductoLabel.Text = "Productos";
            // 
            // VentasLabel
            // 
            this.VentasLabel.AutoSize = true;
            this.VentasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VentasLabel.Location = new System.Drawing.Point(561, 175);
            this.VentasLabel.Name = "VentasLabel";
            this.VentasLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VentasLabel.Size = new System.Drawing.Size(74, 25);
            this.VentasLabel.TabIndex = 5;
            this.VentasLabel.Text = "Ventas";
            // 
            // VerVentas
            // 
            this.VerVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.VerVentas.Location = new System.Drawing.Point(545, 220);
            this.VerVentas.Name = "VerVentas";
            this.VerVentas.Size = new System.Drawing.Size(90, 40);
            this.VerVentas.TabIndex = 6;
            this.VerVentas.Text = "Ver";
            this.VerVentas.UseVisualStyleBackColor = true;
            this.VerVentas.Click += new System.EventHandler(this.VerVentas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VerVentas);
            this.Controls.Add(this.VentasLabel);
            this.Controls.Add(this.ProductoLabel);
            this.Controls.Add(this.ClienteLabel);
            this.Controls.Add(this.VerProductos);
            this.Controls.Add(this.Prueba);
            this.Controls.Add(this.VerClientes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VerClientes;
        private System.Windows.Forms.Button Prueba;
        private System.Windows.Forms.Button VerProductos;
        private System.Windows.Forms.Label ClienteLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProductoLabel;
        private System.Windows.Forms.Label VentasLabel;
        private System.Windows.Forms.Button VerVentas;
    }
}

