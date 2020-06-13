namespace FotocopiadoraFacultad
{
    partial class InicioDos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioDos));
            this.Clientes = new System.Windows.Forms.Button();
            this.Pedidos = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clientes
            // 
            this.Clientes.Location = new System.Drawing.Point(304, 134);
            this.Clientes.Margin = new System.Windows.Forms.Padding(4);
            this.Clientes.Name = "Clientes";
            this.Clientes.Size = new System.Drawing.Size(221, 66);
            this.Clientes.TabIndex = 0;
            this.Clientes.Text = "CLIENTES";
            this.Clientes.UseVisualStyleBackColor = true;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Pedidos
            // 
            this.Pedidos.Location = new System.Drawing.Point(304, 238);
            this.Pedidos.Margin = new System.Windows.Forms.Padding(4);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.Size = new System.Drawing.Size(221, 66);
            this.Pedidos.TabIndex = 1;
            this.Pedidos.Text = "PEDIDOS";
            this.Pedidos.UseVisualStyleBackColor = true;
            this.Pedidos.Click += new System.EventHandler(this.Pedidos_Click);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(13, 382);
            this.Volver.Margin = new System.Windows.Forms.Padding(4);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(221, 66);
            this.Volver.TabIndex = 2;
            this.Volver.Text = "VOLVER";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // InicioDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Pedidos);
            this.Controls.Add(this.Clientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InicioDos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio de Fotocopias";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Clientes;
        private System.Windows.Forms.Button Pedidos;
        private System.Windows.Forms.Button Volver;
    }
}