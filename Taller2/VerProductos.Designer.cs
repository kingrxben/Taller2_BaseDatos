namespace Taller2
{
    partial class VerProductos
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
            this.EliminarProducto = new System.Windows.Forms.Button();
            this.AgregarProducto = new System.Windows.Forms.Button();
            this.EliminarText = new System.Windows.Forms.Label();
            this.AgregarText = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.ModificarProducto = new System.Windows.Forms.Button();
            this.ModificarText = new System.Windows.Forms.Label();
            this.DetalleProducto = new System.Windows.Forms.Button();
            this.DetalleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EliminarProducto
            // 
            this.EliminarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EliminarProducto.Location = new System.Drawing.Point(463, 277);
            this.EliminarProducto.Name = "EliminarProducto";
            this.EliminarProducto.Size = new System.Drawing.Size(90, 40);
            this.EliminarProducto.TabIndex = 9;
            this.EliminarProducto.Text = "Ir";
            this.EliminarProducto.UseVisualStyleBackColor = true;
            this.EliminarProducto.Click += new System.EventHandler(this.EliminarProducto_Click);
            // 
            // AgregarProducto
            // 
            this.AgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AgregarProducto.Location = new System.Drawing.Point(138, 277);
            this.AgregarProducto.Name = "AgregarProducto";
            this.AgregarProducto.Size = new System.Drawing.Size(90, 40);
            this.AgregarProducto.TabIndex = 8;
            this.AgregarProducto.Text = "Ir";
            this.AgregarProducto.UseVisualStyleBackColor = true;
            this.AgregarProducto.Click += new System.EventHandler(this.AgregarProducto_Click);
            // 
            // EliminarText
            // 
            this.EliminarText.AutoSize = true;
            this.EliminarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EliminarText.Location = new System.Drawing.Point(472, 235);
            this.EliminarText.Name = "EliminarText";
            this.EliminarText.Size = new System.Drawing.Size(81, 25);
            this.EliminarText.TabIndex = 7;
            this.EliminarText.Text = "Eliminar";
            // 
            // AgregarText
            // 
            this.AgregarText.AutoSize = true;
            this.AgregarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AgregarText.Location = new System.Drawing.Point(146, 235);
            this.AgregarText.Name = "AgregarText";
            this.AgregarText.Size = new System.Drawing.Size(82, 25);
            this.AgregarText.TabIndex = 6;
            this.AgregarText.Text = "Agregar";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Titulo.Location = new System.Drawing.Point(327, 134);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(197, 31);
            this.Titulo.TabIndex = 5;
            this.Titulo.Text = "Menú Producto";
            // 
            // ModificarProducto
            // 
            this.ModificarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ModificarProducto.Location = new System.Drawing.Point(297, 277);
            this.ModificarProducto.Name = "ModificarProducto";
            this.ModificarProducto.Size = new System.Drawing.Size(90, 40);
            this.ModificarProducto.TabIndex = 11;
            this.ModificarProducto.Text = "Ir";
            this.ModificarProducto.UseVisualStyleBackColor = true;
            this.ModificarProducto.Click += new System.EventHandler(this.ModificarProducto_Click);
            // 
            // ModificarText
            // 
            this.ModificarText.AutoSize = true;
            this.ModificarText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ModificarText.Location = new System.Drawing.Point(305, 235);
            this.ModificarText.Name = "ModificarText";
            this.ModificarText.Size = new System.Drawing.Size(91, 25);
            this.ModificarText.TabIndex = 10;
            this.ModificarText.Text = "Modificar";
            // 
            // DetalleProducto
            // 
            this.DetalleProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DetalleProducto.Location = new System.Drawing.Point(606, 277);
            this.DetalleProducto.Name = "DetalleProducto";
            this.DetalleProducto.Size = new System.Drawing.Size(90, 40);
            this.DetalleProducto.TabIndex = 13;
            this.DetalleProducto.Text = "Ir";
            this.DetalleProducto.UseVisualStyleBackColor = true;
            this.DetalleProducto.Click += new System.EventHandler(this.DetalleProducto_Click);
            // 
            // DetalleText
            // 
            this.DetalleText.AutoSize = true;
            this.DetalleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DetalleText.Location = new System.Drawing.Point(615, 235);
            this.DetalleText.Name = "DetalleText";
            this.DetalleText.Size = new System.Drawing.Size(72, 25);
            this.DetalleText.TabIndex = 12;
            this.DetalleText.Text = "Detalle";
            this.DetalleText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VerProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DetalleProducto);
            this.Controls.Add(this.DetalleText);
            this.Controls.Add(this.ModificarProducto);
            this.Controls.Add(this.ModificarText);
            this.Controls.Add(this.EliminarProducto);
            this.Controls.Add(this.AgregarProducto);
            this.Controls.Add(this.EliminarText);
            this.Controls.Add(this.AgregarText);
            this.Controls.Add(this.Titulo);
            this.Name = "VerProductos";
            this.Text = "VerProductos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarProducto;
        private System.Windows.Forms.Button AgregarProducto;
        private System.Windows.Forms.Label EliminarText;
        private System.Windows.Forms.Label AgregarText;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button ModificarProducto;
        private System.Windows.Forms.Label ModificarText;
        private System.Windows.Forms.Button DetalleProducto;
        private System.Windows.Forms.Label DetalleText;
    }
}