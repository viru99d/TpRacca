namespace FotocopiadoraFacultad
{
    partial class RegistroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroClientes));
            this.Id = new System.Windows.Forms.Label();
            this.Idtext = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.NombreText = new System.Windows.Forms.TextBox();
            this.TelefonoText = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.Label();
            this.SocioCoop = new System.Windows.Forms.Label();
            this.SocioDeCoop = new System.Windows.Forms.ComboBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.Cargar = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(60, 102);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(34, 16);
            this.Id.TabIndex = 0;
            this.Id.Text = "DNI:";
            // 
            // Idtext
            // 
            this.Idtext.Location = new System.Drawing.Point(289, 101);
            this.Idtext.Name = "Idtext";
            this.Idtext.Size = new System.Drawing.Size(206, 20);
            this.Idtext.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(60, 140);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(70, 16);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "NOMBRE:";
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(289, 140);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(206, 20);
            this.NombreText.TabIndex = 3;
            // 
            // TelefonoText
            // 
            this.TelefonoText.Location = new System.Drawing.Point(289, 182);
            this.TelefonoText.Name = "TelefonoText";
            this.TelefonoText.Size = new System.Drawing.Size(206, 20);
            this.TelefonoText.TabIndex = 5;
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(60, 182);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(80, 16);
            this.Telefono.TabIndex = 4;
            this.Telefono.Text = "TELEFONO";
            // 
            // SocioCoop
            // 
            this.SocioCoop.AutoSize = true;
            this.SocioCoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SocioCoop.Location = new System.Drawing.Point(60, 224);
            this.SocioCoop.Name = "SocioCoop";
            this.SocioCoop.Size = new System.Drawing.Size(182, 16);
            this.SocioCoop.TabIndex = 6;
            this.SocioCoop.Text = "SOCIO DE COOPERADORA:";
            // 
            // SocioDeCoop
            // 
            this.SocioDeCoop.FormattingEnabled = true;
            this.SocioDeCoop.Location = new System.Drawing.Point(289, 218);
            this.SocioDeCoop.Name = "SocioDeCoop";
            this.SocioDeCoop.Size = new System.Drawing.Size(206, 21);
            this.SocioDeCoop.TabIndex = 7;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(160, 33);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(297, 36);
            this.Titulo.TabIndex = 8;
            this.Titulo.Text = "CARGA EL NUEVO CLIENTE:";
            // 
            // Cargar
            // 
            this.Cargar.Location = new System.Drawing.Point(450, 277);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(112, 45);
            this.Cargar.TabIndex = 9;
            this.Cargar.Text = "CARGAR DATOS";
            this.Cargar.UseVisualStyleBackColor = true;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(28, 277);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(112, 45);
            this.Volver.TabIndex = 10;
            this.Volver.Text = "VOLVER";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // RegistroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(585, 334);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.SocioDeCoop);
            this.Controls.Add(this.SocioCoop);
            this.Controls.Add(this.TelefonoText);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Idtext);
            this.Controls.Add(this.Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegistroClientes";
            this.Text = "Registro Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox Idtext;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.TextBox TelefonoText;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label SocioCoop;
        private System.Windows.Forms.ComboBox SocioDeCoop;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button Cargar;
        private System.Windows.Forms.Button Volver;
    }
}