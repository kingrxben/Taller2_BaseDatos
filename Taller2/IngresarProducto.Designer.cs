namespace Taller2
{
    partial class IngresarProducto
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
            this.TituloLabel = new System.Windows.Forms.Label();
            this.NombreProductoLabel = new System.Windows.Forms.Label();
            this.PrecioLabel = new System.Windows.Forms.Label();
            this.StockLabel = new System.Windows.Forms.Label();
            this.NombreProductoBox = new System.Windows.Forms.TextBox();
            this.PrecioBox = new System.Windows.Forms.TextBox();
            this.StockBox = new System.Windows.Forms.TextBox();
            this.AñadirBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TituloLabel.Location = new System.Drawing.Point(292, 46);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(230, 31);
            this.TituloLabel.TabIndex = 0;
            this.TituloLabel.Text = "Ingresar Producto";
            // 
            // NombreProductoLabel
            // 
            this.NombreProductoLabel.AutoSize = true;
            this.NombreProductoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NombreProductoLabel.Location = new System.Drawing.Point(152, 164);
            this.NombreProductoLabel.Name = "NombreProductoLabel";
            this.NombreProductoLabel.Size = new System.Drawing.Size(81, 25);
            this.NombreProductoLabel.TabIndex = 1;
            this.NombreProductoLabel.Text = "Nombre";
            // 
            // PrecioLabel
            // 
            this.PrecioLabel.AutoSize = true;
            this.PrecioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PrecioLabel.Location = new System.Drawing.Point(369, 164);
            this.PrecioLabel.Name = "PrecioLabel";
            this.PrecioLabel.Size = new System.Drawing.Size(67, 25);
            this.PrecioLabel.TabIndex = 2;
            this.PrecioLabel.Text = "Precio";
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StockLabel.Location = new System.Drawing.Point(547, 164);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(146, 25);
            this.StockLabel.TabIndex = 3;
            this.StockLabel.Text = "Cantidad Stock";
            // 
            // NombreProductoBox
            // 
            this.NombreProductoBox.Location = new System.Drawing.Point(143, 206);
            this.NombreProductoBox.Name = "NombreProductoBox";
            this.NombreProductoBox.Size = new System.Drawing.Size(100, 22);
            this.NombreProductoBox.TabIndex = 4;
            // 
            // PrecioBox
            // 
            this.PrecioBox.Location = new System.Drawing.Point(350, 214);
            this.PrecioBox.Name = "PrecioBox";
            this.PrecioBox.Size = new System.Drawing.Size(100, 22);
            this.PrecioBox.TabIndex = 5;
            // 
            // StockBox
            // 
            this.StockBox.Location = new System.Drawing.Point(573, 214);
            this.StockBox.Name = "StockBox";
            this.StockBox.Size = new System.Drawing.Size(100, 22);
            this.StockBox.TabIndex = 6;
            // 
            // AñadirBoton
            // 
            this.AñadirBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AñadirBoton.Location = new System.Drawing.Point(350, 293);
            this.AñadirBoton.Name = "AñadirBoton";
            this.AñadirBoton.Size = new System.Drawing.Size(100, 50);
            this.AñadirBoton.TabIndex = 7;
            this.AñadirBoton.Text = "Añadir";
            this.AñadirBoton.UseVisualStyleBackColor = true;
            this.AñadirBoton.Click += new System.EventHandler(this.AñadirBoton_Click);
            // 
            // IngresarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AñadirBoton);
            this.Controls.Add(this.StockBox);
            this.Controls.Add(this.PrecioBox);
            this.Controls.Add(this.NombreProductoBox);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.PrecioLabel);
            this.Controls.Add(this.NombreProductoLabel);
            this.Controls.Add(this.TituloLabel);
            this.Name = "IngresarProducto";
            this.Text = "IngresarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.Label NombreProductoLabel;
        private System.Windows.Forms.Label PrecioLabel;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.TextBox NombreProductoBox;
        private System.Windows.Forms.TextBox PrecioBox;
        private System.Windows.Forms.TextBox StockBox;
        private System.Windows.Forms.Button AñadirBoton;
    }
}