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
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductoLabel);
            this.Controls.Add(this.PrecioLabel2);
            this.Controls.Add(this.PrecioLabel1);
            this.Controls.Add(this.StockLabel2);
            this.Controls.Add(this.StockLabel1);
            this.Name = "ModificarProducto";
            this.Text = "ModificarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StockLabel1;
        private System.Windows.Forms.Label StockLabel2;
        private System.Windows.Forms.Label PrecioLabel1;
        private System.Windows.Forms.Label PrecioLabel2;
        private System.Windows.Forms.Label ProductoLabel;
    }
}