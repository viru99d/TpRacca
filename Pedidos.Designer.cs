﻿namespace FotocopiadoraFacultad
{
    partial class Pedidos
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
            this.Volver = new System.Windows.Forms.Button();
            this.RegistroPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(29, 384);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(166, 54);
            this.Volver.TabIndex = 3;
            this.Volver.Text = "VOLVER";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // RegistroPedidos
            // 
            this.RegistroPedidos.Location = new System.Drawing.Point(311, 107);
            this.RegistroPedidos.Name = "RegistroPedidos";
            this.RegistroPedidos.Size = new System.Drawing.Size(166, 54);
            this.RegistroPedidos.TabIndex = 4;
            this.RegistroPedidos.Text = "Registrar Pedidos";
            this.RegistroPedidos.UseVisualStyleBackColor = true;
            this.RegistroPedidos.Click += new System.EventHandler(this.RegistroPedidos_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegistroPedidos);
            this.Controls.Add(this.Volver);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button RegistroPedidos;
    }
}