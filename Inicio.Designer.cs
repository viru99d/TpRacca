namespace FotocopiadoraFacultad
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.TextBox();
            this.inicioSesión = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE PEDIDOS WADSCOPY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "USUARIO:";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(335, 204);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(188, 22);
            this.Nombre.TabIndex = 3;
            this.Nombre.LostFocus += new System.EventHandler(this.Nombre_LostFocus);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 267);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "CONTRASEÑA:";
            // 
            // Contraseña
            // 
            this.Contraseña.Location = new System.Drawing.Point(335, 270);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(188, 22);
            this.Contraseña.TabIndex = 5;
            this.Contraseña.LostFocus += new System.EventHandler(this.Contraseña_LostFocus);
            // 
            // inicioSesión
            // 
            this.inicioSesión.Location = new System.Drawing.Point(335, 316);
            this.inicioSesión.Name = "inicioSesión";
            this.inicioSesión.Size = new System.Drawing.Size(123, 38);
            this.inicioSesión.TabIndex = 6;
            this.inicioSesión.Text = "Iniciar sesión";
            this.inicioSesión.UseVisualStyleBackColor = true;
            this.inicioSesión.Click += new System.EventHandler(this.inicioSesión_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(639, 411);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(123, 38);
            this.Salir.TabIndex = 8;
            this.Salir.Text = "SALIR";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FotocopiadoraFacultad.Properties.Resources.copiadora_profesional_oficina_documentos_papel_impresion_impresora_multifuncionales_aislo_ejemplo_vector_maquina_impresora_copiadora_trabajo_oficina_53562_6147__1_;
            this.pictureBox1.Location = new System.Drawing.Point(529, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inicioSesión);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servicio de fotocopias";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Contraseña;
        private System.Windows.Forms.Button inicioSesión;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Salir;
    }
}

