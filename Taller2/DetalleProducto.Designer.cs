﻿namespace Taller2
{
    partial class DetalleProducto
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
            this.SubtituloText = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TituloText = new System.Windows.Forms.Label();
            this.DetalleProductoBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SubtituloText
            // 
            this.SubtituloText.AutoSize = true;
            this.SubtituloText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SubtituloText.Location = new System.Drawing.Point(273, 117);
            this.SubtituloText.Name = "SubtituloText";
            this.SubtituloText.Size = new System.Drawing.Size(0, 29);
            this.SubtituloText.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(161, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(463, 247);
            this.dataGridView1.TabIndex = 1;
            // 
            // TituloText
            // 
            this.TituloText.AutoSize = true;
            this.TituloText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TituloText.Location = new System.Drawing.Point(255, 40);
            this.TituloText.Name = "TituloText";
            this.TituloText.Size = new System.Drawing.Size(266, 31);
            this.TituloText.TabIndex = 3;
            this.TituloText.Text = "Detalle de Productos";
            // 
            // DetalleProductoBox
            // 
            this.DetalleProductoBox.FormattingEnabled = true;
            this.DetalleProductoBox.Items.AddRange(new object[] {
            "Productos en venta",
            "Productos vendidos este año",
            "Productos vendidos ultimos 2 años"});
            this.DetalleProductoBox.Location = new System.Drawing.Point(161, 149);
            this.DetalleProductoBox.Name = "DetalleProductoBox";
            this.DetalleProductoBox.Size = new System.Drawing.Size(230, 24);
            this.DetalleProductoBox.TabIndex = 4;
            this.DetalleProductoBox.SelectedIndexChanged += new System.EventHandler(this.DetalleProductoBox_SelectedIndexChanged);
            // 
            // DetalleProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DetalleProductoBox);
            this.Controls.Add(this.TituloText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SubtituloText);
            this.Name = "DetalleProducto";
            this.Text = "DetalleProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtituloText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label TituloText;
        private System.Windows.Forms.ComboBox DetalleProductoBox;
    }
}