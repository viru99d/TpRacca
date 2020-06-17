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
            this.VerClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegistroCliente
            // 
            resources.ApplyResources(this.RegistroCliente, "RegistroCliente");
            this.RegistroCliente.Name = "RegistroCliente";
            this.RegistroCliente.UseVisualStyleBackColor = true;
            this.RegistroCliente.Click += new System.EventHandler(this.RegistroCliente_Click);
            // 
            // Volver
            // 
            resources.ApplyResources(this.Volver, "Volver");
            this.Volver.Name = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // VerClientes
            // 
            resources.ApplyResources(this.VerClientes, "VerClientes");
            this.VerClientes.Name = "VerClientes";
            this.VerClientes.UseVisualStyleBackColor = true;
            this.VerClientes.Click += new System.EventHandler(this.VerClientes_Click);
            // 
            // Clientes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.VerClientes);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.RegistroCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Clientes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegistroCliente;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button VerClientes;
    }
}