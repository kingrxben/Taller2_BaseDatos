namespace Taller2
{
    partial class ModificarProducto
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
            this.StockLabel1 = new System.Windows.Forms.Label();
            this.StockLabel2 = new System.Windows.Forms.Label();
            this.PrecioLabel1 = new System.Windows.Forms.Label();
            this.PrecioLabel2 = new System.Windows.Forms.Label();
            this.ProductoLabel = new System.Windows.Forms.Label();
            this.ListaProductosBox = new System.Windows.Forms.ComboBox();
            this.StockActualBox = new System.Windows.Forms.TextBox();
            this.PrecioActualBox = new System.Windows.Forms.TextBox();
            this.StockNuevoBox = new System.Windows.Forms.TextBox();
            this.PrecioNuevoBox = new System.Windows.Forms.TextBox();
            this.ActualizarStockBoton = new System.Windows.Forms.Button();
            this.ActualizarPrecioBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StockLabel1
            // 
            this.StockLabel1.AutoSize = true;
            this.StockLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StockLabel1.Location = new System.Drawing.Point(255, 58);
            this.StockLabel1.Name = "StockLabel1";
            this.StockLabel1.Size = new System.Drawing.Size(122, 25);
            this.StockLabel1.TabIndex = 0;
            this.StockLabel1.Text = "Stock Actual";
            // 
            // StockLabel2
            // 
            this.StockLabel2.AutoSize = true;
            this.StockLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.StockLabel2.Location = new System.Drawing.Point(255, 211);
            this.StockLabel2.Name = "StockLabel2";
            this.StockLabel2.Size = new System.Drawing.Size(124, 25);
            this.StockLabel2.TabIndex = 1;
            this.StockLabel2.Text = "Stock Nuevo";
            // 
            // PrecioLabel1
            // 
            this.PrecioLabel1.AutoSize = true;
            this.PrecioLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PrecioLabel1.Location = new System.Drawing.Point(478, 58);
            this.PrecioLabel1.Name = "PrecioLabel1";
            this.PrecioLabel1.Size = new System.Drawing.Size(127, 25);
            this.PrecioLabel1.TabIndex = 2;
            this.PrecioLabel1.Text = "Precio Actual";
            // 
            // PrecioLabel2
            // 
            this.PrecioLabel2.AutoSize = true;
            this.PrecioLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PrecioLabel2.Location = new System.Drawing.Point(478, 211);
            this.PrecioLabel2.Name = "PrecioLabel2";
            this.PrecioLabel2.Size = new System.Drawing.Size(129, 25);
            this.PrecioLabel2.TabIndex = 3;
            this.PrecioLabel2.Text = "Precio Nuevo";
            // 
            // ProductoLabel
            // 
            this.ProductoLabel.AutoSize = true;
            this.ProductoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ProductoLabel.Location = new System.Drawing.Point(60, 58);
            this.ProductoLabel.Name = "ProductoLabel";
            this.ProductoLabel.Size = new System.Drawing.Size(90, 25);
            this.ProductoLabel.TabIndex = 4;
            this.ProductoLabel.Text = "Producto";
            // 
            // ListaProductosBox
            // 
            this.ListaProductosBox.FormattingEnabled = true;
            this.ListaProductosBox.Location = new System.Drawing.Point(43, 128);
            this.ListaProductosBox.Name = "ListaProductosBox";
            this.ListaProductosBox.Size = new System.Drawing.Size(121, 24);
            this.ListaProductosBox.TabIndex = 5;
            this.ListaProductosBox.SelectedIndexChanged += new System.EventHandler(this.ListaProductosBox_SelectedIndexChanged);
            // 
            // StockActualBox
            // 
            this.StockActualBox.Location = new System.Drawing.Point(260, 128);
            this.StockActualBox.Name = "StockActualBox";
            this.StockActualBox.Size = new System.Drawing.Size(100, 22);
            this.StockActualBox.TabIndex = 6;
            // 
            // PrecioActualBox
            // 
            this.PrecioActualBox.Location = new System.Drawing.Point(483, 128);
            this.PrecioActualBox.Name = "PrecioActualBox";
            this.PrecioActualBox.Size = new System.Drawing.Size(100, 22);
            this.PrecioActualBox.TabIndex = 7;
            // 
            // StockNuevoBox
            // 
            this.StockNuevoBox.Location = new System.Drawing.Point(260, 270);
            this.StockNuevoBox.Name = "StockNuevoBox";
            this.StockNuevoBox.Size = new System.Drawing.Size(100, 22);
            this.StockNuevoBox.TabIndex = 8;
            // 
            // PrecioNuevoBox
            // 
            this.PrecioNuevoBox.Location = new System.Drawing.Point(483, 270);
            this.PrecioNuevoBox.Name = "PrecioNuevoBox";
            this.PrecioNuevoBox.Size = new System.Drawing.Size(100, 22);
            this.PrecioNuevoBox.TabIndex = 9;
            // 
            // ActualizarStockBoton
            // 
            this.ActualizarStockBoton.Location = new System.Drawing.Point(274, 329);
            this.ActualizarStockBoton.Name = "ActualizarStockBoton";
            this.ActualizarStockBoton.Size = new System.Drawing.Size(75, 23);
            this.ActualizarStockBoton.TabIndex = 10;
            this.ActualizarStockBoton.Text = "Actualizar";
            this.ActualizarStockBoton.UseVisualStyleBackColor = true;
            this.ActualizarStockBoton.Click += new System.EventHandler(this.ActualizarStockBoton_Click);
            // 
            // ActualizarPrecioBoton
            // 
            this.ActualizarPrecioBoton.Location = new System.Drawing.Point(498, 329);
            this.ActualizarPrecioBoton.Name = "ActualizarPrecioBoton";
            this.ActualizarPrecioBoton.Size = new System.Drawing.Size(75, 23);
            this.ActualizarPrecioBoton.TabIndex = 11;
            this.ActualizarPrecioBoton.Text = "Actualizar";
            this.ActualizarPrecioBoton.UseVisualStyleBackColor = true;
            this.ActualizarPrecioBoton.Click += new System.EventHandler(this.ActualizarPrecioBoton_Click);
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActualizarPrecioBoton);
            this.Controls.Add(this.ActualizarStockBoton);
            this.Controls.Add(this.PrecioNuevoBox);
            this.Controls.Add(this.StockNuevoBox);
            this.Controls.Add(this.PrecioActualBox);
            this.Controls.Add(this.StockActualBox);
            this.Controls.Add(this.ListaProductosBox);
            this.Controls.Add(this.ProductoLabel);
            this.Controls.Add(this.PrecioLabel2);
            this.Controls.Add(this.PrecioLabel1);
            this.Controls.Add(this.StockLabel2);
            this.Controls.Add(this.StockLabel1);
            this.Name = "ModificarProducto";
            this.Text = "ModificarProducto";
            this.Load += new System.EventHandler(this.ModificarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StockLabel1;
        private System.Windows.Forms.Label StockLabel2;
        private System.Windows.Forms.Label PrecioLabel1;
        private System.Windows.Forms.Label PrecioLabel2;
        private System.Windows.Forms.Label ProductoLabel;
        private System.Windows.Forms.ComboBox ListaProductosBox;
        private System.Windows.Forms.TextBox StockActualBox;
        private System.Windows.Forms.TextBox PrecioActualBox;
        private System.Windows.Forms.TextBox StockNuevoBox;
        private System.Windows.Forms.TextBox PrecioNuevoBox;
        private System.Windows.Forms.Button ActualizarStockBoton;
        private System.Windows.Forms.Button ActualizarPrecioBoton;
    }
}