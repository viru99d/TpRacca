namespace FotocopiadoraFacultad
{
    partial class usuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usuario));
            this.botonIngresar = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.botonSalir = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // botonIngresar
            // 
            this.botonIngresar.Location = new System.Drawing.Point(280, 239);
            this.botonIngresar.Name = "botonIngresar";
            this.botonIngresar.Size = new System.Drawing.Size(264, 66);
            this.botonIngresar.TabIndex = 1;
            this.botonIngresar.Text = "Ingresar";
            this.botonIngresar.UseVisualStyleBackColor = true;
            this.botonIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(208, 153);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(66, 18);
            this.nombre.TabIndex = 2;
            this.nombre.Text = "Usuario:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.ingresarUsuario_TextChanged);
            // 
            // contraseña
            // 
            this.contraseña.AutoSize = true;
            this.contraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(181, 192);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(93, 18);
            this.contraseña.TabIndex = 4;
            this.contraseña.Text = "Contraseña:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(280, 193);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 20);
            this.textBox2.TabIndex = 5;
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(694, 413);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(98, 36);
            this.botonSalir.TabIndex = 6;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.botonIngresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio de fotocopias";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botonIngresar;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

