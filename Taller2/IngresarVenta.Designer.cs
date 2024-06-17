namespace Taller2
{
    partial class IngresarVenta
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
            this.ListaClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CodigoClienteBox = new System.Windows.Forms.TextBox();
            this.StatusClienteBox = new System.Windows.Forms.TextBox();
            this.ListaProductos = new System.Windows.Forms.ComboBox();
            this.PrecioBox = new System.Windows.Forms.TextBox();
            this.CantidadBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.RealizarCompraBoton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaClientes
            // 
            this.ListaClientes.FormattingEnabled = true;
            this.ListaClientes.Location = new System.Drawing.Point(191, 248);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.Size = new System.Drawing.Size(121, 24);
            this.ListaClientes.TabIndex = 0;
            this.ListaClientes.SelectedIndexChanged += new System.EventHandler(this.ListaClientes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status cliente";
            // 
            // CodigoClienteBox
            // 
            this.CodigoClienteBox.Location = new System.Drawing.Point(191, 305);
            this.CodigoClienteBox.Name = "CodigoClienteBox";
            this.CodigoClienteBox.Size = new System.Drawing.Size(100, 22);
            this.CodigoClienteBox.TabIndex = 4;
            // 
            // StatusClienteBox
            // 
            this.StatusClienteBox.Location = new System.Drawing.Point(191, 353);
            this.StatusClienteBox.Name = "StatusClienteBox";
            this.StatusClienteBox.Size = new System.Drawing.Size(100, 22);
            this.StatusClienteBox.TabIndex = 5;
            // 
            // ListaProductos
            // 
            this.ListaProductos.FormattingEnabled = true;
            this.ListaProductos.Location = new System.Drawing.Point(508, 248);
            this.ListaProductos.Name = "ListaProductos";
            this.ListaProductos.Size = new System.Drawing.Size(121, 24);
            this.ListaProductos.TabIndex = 6;
            this.ListaProductos.SelectedIndexChanged += new System.EventHandler(this.ListaProductos_SelectedIndexChanged);
            // 
            // PrecioBox
            // 
            this.PrecioBox.Location = new System.Drawing.Point(529, 308);
            this.PrecioBox.Name = "PrecioBox";
            this.PrecioBox.Size = new System.Drawing.Size(100, 22);
            this.PrecioBox.TabIndex = 7;
            // 
            // CantidadBox
            // 
            this.CantidadBox.Location = new System.Drawing.Point(529, 356);
            this.CantidadBox.Name = "CantidadBox";
            this.CantidadBox.Size = new System.Drawing.Size(100, 22);
            this.CantidadBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombre producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(635, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(211, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(392, 166);
            this.dataGridView1.TabIndex = 12;
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.Location = new System.Drawing.Point(541, 404);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(75, 23);
            this.AgregarBoton.TabIndex = 14;
            this.AgregarBoton.Text = "Agregar";
            this.AgregarBoton.UseVisualStyleBackColor = true;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // RealizarCompraBoton
            // 
            this.RealizarCompraBoton.Location = new System.Drawing.Point(354, 404);
            this.RealizarCompraBoton.Name = "RealizarCompraBoton";
            this.RealizarCompraBoton.Size = new System.Drawing.Size(120, 23);
            this.RealizarCompraBoton.TabIndex = 15;
            this.RealizarCompraBoton.Text = "Realizar compra";
            this.RealizarCompraBoton.UseVisualStyleBackColor = true;
            this.RealizarCompraBoton.Click += new System.EventHandler(this.RealizarCompraBoton_Click);
            // 
            // IngresarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RealizarCompraBoton);
            this.Controls.Add(this.AgregarBoton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CantidadBox);
            this.Controls.Add(this.PrecioBox);
            this.Controls.Add(this.ListaProductos);
            this.Controls.Add(this.StatusClienteBox);
            this.Controls.Add(this.CodigoClienteBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListaClientes);
            this.Name = "IngresarVenta";
            this.Text = "IngresarVenta";
            this.Load += new System.EventHandler(this.IngresarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ListaClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodigoClienteBox;
        private System.Windows.Forms.TextBox StatusClienteBox;
        private System.Windows.Forms.ComboBox ListaProductos;
        private System.Windows.Forms.TextBox PrecioBox;
        private System.Windows.Forms.TextBox CantidadBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AgregarBoton;
        private System.Windows.Forms.Button RealizarCompraBoton;
    }
}