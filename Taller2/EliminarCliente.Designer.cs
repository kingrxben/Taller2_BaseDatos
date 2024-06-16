namespace Taller2
{
    partial class EliminarCliente
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
            this.DatosCliente = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatosCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Cliente";
            // 
            // DatosCliente
            // 
            this.DatosCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosCliente.Location = new System.Drawing.Point(227, 110);
            this.DatosCliente.Name = "DatosCliente";
            this.DatosCliente.RowHeadersWidth = 51;
            this.DatosCliente.RowTemplate.Height = 24;
            this.DatosCliente.Size = new System.Drawing.Size(367, 217);
            this.DatosCliente.TabIndex = 1;
            this.DatosCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosCliente_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(373, 347);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // EliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.DatosCliente);
            this.Controls.Add(this.label1);
            this.Name = "EliminarCliente";
            this.Text = "EliminarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.DatosCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DatosCliente;
        private System.Windows.Forms.Button Eliminar;
    }
}