namespace FotocopiadoraFacultad
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
            this.MostrarPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(10, 310);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(166, 54);
            this.Volver.TabIndex = 3;
            this.Volver.Text = "VOLVER";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // RegistroPedidos
            // 
            this.RegistroPedidos.Location = new System.Drawing.Point(217, 89);
            this.RegistroPedidos.Name = "RegistroPedidos";
            this.RegistroPedidos.Size = new System.Drawing.Size(166, 54);
            this.RegistroPedidos.TabIndex = 4;
            this.RegistroPedidos.Text = "REGISTRAR PEDIDOS";
            this.RegistroPedidos.UseVisualStyleBackColor = true;
            this.RegistroPedidos.Click += new System.EventHandler(this.RegistroPedidos_Click);
            // 
            // MostrarPedidos
            // 
            this.MostrarPedidos.Location = new System.Drawing.Point(217, 187);
            this.MostrarPedidos.Name = "MostrarPedidos";
            this.MostrarPedidos.Size = new System.Drawing.Size(166, 54);
            this.MostrarPedidos.TabIndex = 5;
            this.MostrarPedidos.Text = "VER PEDIDOS";
            this.MostrarPedidos.UseVisualStyleBackColor = true;
            this.MostrarPedidos.Click += new System.EventHandler(this.MostrarPedidos_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(603, 375);
            this.Controls.Add(this.MostrarPedidos);
            this.Controls.Add(this.RegistroPedidos);
            this.Controls.Add(this.Volver);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button RegistroPedidos;
        private System.Windows.Forms.Button MostrarPedidos;
    }
}