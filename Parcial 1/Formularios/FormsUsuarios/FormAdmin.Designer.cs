﻿
namespace Formularios
{
    partial class FormAdmin
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
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnFacturacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Location = new System.Drawing.Point(22, 354);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(322, 58);
            this.btnEmpleados.TabIndex = 11;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Location = new System.Drawing.Point(22, 290);
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(322, 57);
            this.btnFacturacion.TabIndex = 12;
            this.btnFacturacion.Text = "Facturacion";
            this.btnFacturacion.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(989, 495);
            this.Controls.Add(this.btnFacturacion);
            this.Controls.Add(this.btnEmpleados);
            this.Name = "FormAdmin";
            this.Text = " ";
            this.Controls.SetChildIndex(this.btnEmpleados, 0);
            this.Controls.SetChildIndex(this.btnFacturacion, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnFacturacion;
    }
}