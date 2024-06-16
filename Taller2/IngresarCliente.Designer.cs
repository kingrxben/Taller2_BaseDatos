namespace Taller2
{
    partial class IngresarCliente
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
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.CiudadBox = new System.Windows.Forms.TextBox();
            this.AñadirBoton = new System.Windows.Forms.Button();
            this.TipoBox = new System.Windows.Forms.ListBox();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.CiudadLabel = new System.Windows.Forms.Label();
            this.TipoLabel = new System.Windows.Forms.Label();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(170, 219);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(100, 22);
            this.NombreBox.TabIndex = 0;
            // 
            // CiudadBox
            // 
            this.CiudadBox.Location = new System.Drawing.Point(372, 219);
            this.CiudadBox.Name = "CiudadBox";
            this.CiudadBox.Size = new System.Drawing.Size(100, 22);
            this.CiudadBox.TabIndex = 1;
            // 
            // AñadirBoton
            // 
            this.AñadirBoton.Location = new System.Drawing.Point(385, 302);
            this.AñadirBoton.Name = "AñadirBoton";
            this.AñadirBoton.Size = new System.Drawing.Size(75, 23);
            this.AñadirBoton.TabIndex = 2;
            this.AñadirBoton.Text = "Añadir";
            this.AñadirBoton.UseVisualStyleBackColor = true;
            this.AñadirBoton.Click += new System.EventHandler(this.AñadirBoton_Click);
            // 
            // TipoBox
            // 
            this.TipoBox.FormattingEnabled = true;
            this.TipoBox.ItemHeight = 16;
            this.TipoBox.Items.AddRange(new object[] {
            "Normal",
            "Premiun"});
            this.TipoBox.Location = new System.Drawing.Point(574, 219);
            this.TipoBox.Name = "TipoBox";
            this.TipoBox.Size = new System.Drawing.Size(120, 20);
            this.TipoBox.TabIndex = 3;
            this.TipoBox.SelectedIndexChanged += new System.EventHandler(this.TipoBox_SelectedIndexChanged);
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.NombreLabel.Location = new System.Drawing.Point(180, 181);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(81, 25);
            this.NombreLabel.TabIndex = 4;
            this.NombreLabel.Text = "Nombre";
            // 
            // CiudadLabel
            // 
            this.CiudadLabel.AutoSize = true;
            this.CiudadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CiudadLabel.Location = new System.Drawing.Point(385, 181);
            this.CiudadLabel.Name = "CiudadLabel";
            this.CiudadLabel.Size = new System.Drawing.Size(75, 25);
            this.CiudadLabel.TabIndex = 5;
            this.CiudadLabel.Text = "Ciudad";
            // 
            // TipoLabel
            // 
            this.TipoLabel.AutoSize = true;
            this.TipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TipoLabel.Location = new System.Drawing.Point(610, 181);
            this.TipoLabel.Name = "TipoLabel";
            this.TipoLabel.Size = new System.Drawing.Size(51, 25);
            this.TipoLabel.TabIndex = 6;
            this.TipoLabel.Text = "Tipo";
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TituloLabel.Location = new System.Drawing.Point(326, 58);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(206, 31);
            this.TituloLabel.TabIndex = 7;
            this.TituloLabel.Text = "Ingresar Cliente";
            // 
            // IngresarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TituloLabel);
            this.Controls.Add(this.TipoLabel);
            this.Controls.Add(this.CiudadLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.TipoBox);
            this.Controls.Add(this.AñadirBoton);
            this.Controls.Add(this.CiudadBox);
            this.Controls.Add(this.NombreBox);
            this.Name = "IngresarCliente";
            this.Text = "IngresarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.TextBox CiudadBox;
        private System.Windows.Forms.Button AñadirBoton;
        private System.Windows.Forms.ListBox TipoBox;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label CiudadLabel;
        private System.Windows.Forms.Label TipoLabel;
        private System.Windows.Forms.Label TituloLabel;
    }
}