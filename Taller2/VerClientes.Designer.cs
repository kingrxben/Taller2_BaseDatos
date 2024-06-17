namespace Taller2
{
    partial class VerClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AgregarCliente = new System.Windows.Forms.Button();
            this.EliminarCliente = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ActualizarStatusBoton = new System.Windows.Forms.Button();
            this.ListClientesBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(315, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(83, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agregar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(250, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Eliminar";
            // 
            // AgregarCliente
            // 
            this.AgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AgregarCliente.Location = new System.Drawing.Point(75, 226);
            this.AgregarCliente.Name = "AgregarCliente";
            this.AgregarCliente.Size = new System.Drawing.Size(90, 40);
            this.AgregarCliente.TabIndex = 3;
            this.AgregarCliente.Text = "Ir";
            this.AgregarCliente.UseVisualStyleBackColor = true;
            this.AgregarCliente.Click += new System.EventHandler(this.AgregarCliente_Click);
            // 
            // EliminarCliente
            // 
            this.EliminarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EliminarCliente.Location = new System.Drawing.Point(241, 226);
            this.EliminarCliente.Name = "EliminarCliente";
            this.EliminarCliente.Size = new System.Drawing.Size(90, 40);
            this.EliminarCliente.TabIndex = 4;
            this.EliminarCliente.Text = "Ir";
            this.EliminarCliente.UseVisualStyleBackColor = true;
            this.EliminarCliente.Click += new System.EventHandler(this.EliminarCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Actualizar status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(639, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Listado clientes";
            // 
            // ActualizarStatusBoton
            // 
            this.ActualizarStatusBoton.Location = new System.Drawing.Point(458, 226);
            this.ActualizarStatusBoton.Name = "ActualizarStatusBoton";
            this.ActualizarStatusBoton.Size = new System.Drawing.Size(91, 40);
            this.ActualizarStatusBoton.TabIndex = 7;
            this.ActualizarStatusBoton.Text = "Ir";
            this.ActualizarStatusBoton.UseVisualStyleBackColor = true;
            this.ActualizarStatusBoton.Click += new System.EventHandler(this.ActualizarStatusBoton_Click);
            // 
            // ListClientesBoton
            // 
            this.ListClientesBoton.Location = new System.Drawing.Point(642, 227);
            this.ListClientesBoton.Name = "ListClientesBoton";
            this.ListClientesBoton.Size = new System.Drawing.Size(97, 44);
            this.ListClientesBoton.TabIndex = 8;
            this.ListClientesBoton.Text = "Ir";
            this.ListClientesBoton.UseVisualStyleBackColor = true;
            this.ListClientesBoton.Click += new System.EventHandler(this.ListClientesBoton_Click);
            // 
            // VerClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListClientesBoton);
            this.Controls.Add(this.ActualizarStatusBoton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EliminarCliente);
            this.Controls.Add(this.AgregarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VerClientes";
            this.Text = "VerClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AgregarCliente;
        private System.Windows.Forms.Button EliminarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ActualizarStatusBoton;
        private System.Windows.Forms.Button ListClientesBoton;
    }
}