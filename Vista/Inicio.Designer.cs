﻿
namespace Vista
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnContactos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FondoInicio = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FondoInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContactos
            // 
            this.btnContactos.Location = new System.Drawing.Point(321, 190);
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Size = new System.Drawing.Size(127, 53);
            this.btnContactos.TabIndex = 0;
            this.btnContactos.Text = "Ver Contactos";
            this.btnContactos.UseVisualStyleBackColor = true;
            this.btnContactos.Click += new System.EventHandler(this.btnContactos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnContactos);
            this.panel1.Controls.Add(this.FondoInicio);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 451);
            this.panel1.TabIndex = 1;
            // 
            // FondoInicio
            // 
            this.FondoInicio.Location = new System.Drawing.Point(0, 0);
            this.FondoInicio.Name = "FondoInicio";
            this.FondoInicio.Size = new System.Drawing.Size(800, 450);
            this.FondoInicio.TabIndex = 1;
            this.FondoInicio.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FondoInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnContactos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox FondoInicio;
    }
}

