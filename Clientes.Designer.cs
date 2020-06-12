namespace FotocopiadoraFacultad
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.RegistroCliente = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegistroCliente
            // 
            this.RegistroCliente.Location = new System.Drawing.Point(301, 185);
            this.RegistroCliente.Name = "RegistroCliente";
            this.RegistroCliente.Size = new System.Drawing.Size(166, 54);
            this.RegistroCliente.TabIndex = 3;
            this.RegistroCliente.Text = "REGISTRAR CLIENTE";
            this.RegistroCliente.UseVisualStyleBackColor = true;
            this.RegistroCliente.Click += new System.EventHandler(this.RegistroCliente_Click);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(41, 363);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(166, 54);
            this.Volver.TabIndex = 4;
            this.Volver.Text = "VOLVER";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.RegistroCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegistroCliente;
        private System.Windows.Forms.Button Volver;
    }
}