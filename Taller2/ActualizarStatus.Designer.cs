namespace Taller2
{
    partial class ActualizarStatus
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
            this.ListaClientesBox = new System.Windows.Forms.ComboBox();
            this.StatusNuevoBox = new System.Windows.Forms.ComboBox();
            this.StatusActualBox = new System.Windows.Forms.TextBox();
            this.ActualizarBoton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizar status de un cliente";
            // 
            // ListaClientesBox
            // 
            this.ListaClientesBox.FormattingEnabled = true;
            this.ListaClientesBox.Location = new System.Drawing.Point(55, 210);
            this.ListaClientesBox.Name = "ListaClientesBox";
            this.ListaClientesBox.Size = new System.Drawing.Size(121, 24);
            this.ListaClientesBox.TabIndex = 1;
            this.ListaClientesBox.SelectedIndexChanged += new System.EventHandler(this.ListaClientesBox_SelectedIndexChanged);
            // 
            // StatusNuevoBox
            // 
            this.StatusNuevoBox.FormattingEnabled = true;
            this.StatusNuevoBox.Items.AddRange(new object[] {
            "Normal",
            "Premium"});
            this.StatusNuevoBox.Location = new System.Drawing.Point(579, 210);
            this.StatusNuevoBox.Name = "StatusNuevoBox";
            this.StatusNuevoBox.Size = new System.Drawing.Size(121, 24);
            this.StatusNuevoBox.TabIndex = 2;
            // 
            // StatusActualBox
            // 
            this.StatusActualBox.Location = new System.Drawing.Point(342, 210);
            this.StatusActualBox.Name = "StatusActualBox";
            this.StatusActualBox.Size = new System.Drawing.Size(100, 22);
            this.StatusActualBox.TabIndex = 3;
            // 
            // ActualizarBoton
            // 
            this.ActualizarBoton.Location = new System.Drawing.Point(348, 338);
            this.ActualizarBoton.Name = "ActualizarBoton";
            this.ActualizarBoton.Size = new System.Drawing.Size(94, 23);
            this.ActualizarBoton.TabIndex = 4;
            this.ActualizarBoton.Text = "Actualizar";
            this.ActualizarBoton.UseVisualStyleBackColor = true;
            this.ActualizarBoton.Click += new System.EventHandler(this.ActualizarBoton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Status actual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nuevo status";
            // 
            // ActualizarStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ActualizarBoton);
            this.Controls.Add(this.StatusActualBox);
            this.Controls.Add(this.StatusNuevoBox);
            this.Controls.Add(this.ListaClientesBox);
            this.Controls.Add(this.label1);
            this.Name = "ActualizarStatus";
            this.Text = "ActualizarStatus";
            this.Load += new System.EventHandler(this.ActualizarStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListaClientesBox;
        private System.Windows.Forms.ComboBox StatusNuevoBox;
        private System.Windows.Forms.TextBox StatusActualBox;
        private System.Windows.Forms.Button ActualizarBoton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}