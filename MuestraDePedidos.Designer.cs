namespace FotocopiadoraFacultad
{
    partial class MuestraDePedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuestraDePedidos));
            this.label1 = new System.Windows.Forms.Label();
            this.Volver = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.dataGridPedidos = new System.Windows.Forms.DataGridView();
            this.comboBoxUniversidad = new System.Windows.Forms.ComboBox();
            this.checkBoxMateria = new System.Windows.Forms.CheckBox();
            this.checkBoxUniversidad = new System.Windows.Forms.CheckBox();
            this.checkBoxFecha = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.comboBoxCarerra = new System.Windows.Forms.ComboBox();
            this.checkBoxCarrera = new System.Windows.Forms.CheckBox();
            this.comboBoxApunte = new System.Windows.Forms.ComboBox();
            this.checkBoxApunte = new System.Windows.Forms.CheckBox();
            this.checkBoxCliente = new System.Windows.Forms.CheckBox();
            this.comboBoxEncuadernillado = new System.Windows.Forms.ComboBox();
            this.checkBoxEncuadernillado = new System.Windows.Forms.CheckBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.buttonRealizado = new System.Windows.Forms.Button();
            this.buttonEntregado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "FILTRAR POR:";
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(57, 391);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(104, 34);
            this.Volver.TabIndex = 7;
            this.Volver.Text = "VOLVER";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(618, 351);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(104, 34);
            this.Buscar.TabIndex = 6;
            this.Buscar.Text = "BUSCAR";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // dataGridPedidos
            // 
            this.dataGridPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridPedidos.Location = new System.Drawing.Point(24, 193);
            this.dataGridPedidos.Name = "dataGridPedidos";
            this.dataGridPedidos.Size = new System.Drawing.Size(765, 152);
            this.dataGridPedidos.TabIndex = 5;
            // 
            // comboBoxUniversidad
            // 
            this.comboBoxUniversidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUniversidad.FormattingEnabled = true;
            this.comboBoxUniversidad.Location = new System.Drawing.Point(358, 50);
            this.comboBoxUniversidad.Name = "comboBoxUniversidad";
            this.comboBoxUniversidad.Size = new System.Drawing.Size(109, 21);
            this.comboBoxUniversidad.TabIndex = 19;
            this.comboBoxUniversidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxUniversidad_SelectedIndexChanged);
            // 
            // checkBoxMateria
            // 
            this.checkBoxMateria.AutoSize = true;
            this.checkBoxMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMateria.Location = new System.Drawing.Point(358, 130);
            this.checkBoxMateria.Name = "checkBoxMateria";
            this.checkBoxMateria.Size = new System.Drawing.Size(72, 20);
            this.checkBoxMateria.TabIndex = 18;
            this.checkBoxMateria.Text = "Materia";
            this.checkBoxMateria.UseVisualStyleBackColor = true;
            // 
            // checkBoxUniversidad
            // 
            this.checkBoxUniversidad.AutoSize = true;
            this.checkBoxUniversidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUniversidad.Location = new System.Drawing.Point(358, 24);
            this.checkBoxUniversidad.Name = "checkBoxUniversidad";
            this.checkBoxUniversidad.Size = new System.Drawing.Size(100, 20);
            this.checkBoxUniversidad.TabIndex = 16;
            this.checkBoxUniversidad.Text = "Universidad";
            this.checkBoxUniversidad.UseVisualStyleBackColor = true;
            // 
            // checkBoxFecha
            // 
            this.checkBoxFecha.AutoSize = true;
            this.checkBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFecha.Location = new System.Drawing.Point(122, 62);
            this.checkBoxFecha.Name = "checkBoxFecha";
            this.checkBoxFecha.Size = new System.Drawing.Size(65, 20);
            this.checkBoxFecha.TabIndex = 12;
            this.checkBoxFecha.Text = "Fecha";
            this.checkBoxFecha.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 88);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Location = new System.Drawing.Point(358, 156);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(109, 21);
            this.comboBoxMateria.TabIndex = 21;
            this.comboBoxMateria.SelectedIndexChanged += new System.EventHandler(this.comboBoxMateria_SelectedIndexChanged);
            // 
            // comboBoxCarerra
            // 
            this.comboBoxCarerra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarerra.FormattingEnabled = true;
            this.comboBoxCarerra.Location = new System.Drawing.Point(358, 103);
            this.comboBoxCarerra.Name = "comboBoxCarerra";
            this.comboBoxCarerra.Size = new System.Drawing.Size(109, 21);
            this.comboBoxCarerra.TabIndex = 23;
            this.comboBoxCarerra.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarerra_SelectedIndexChanged);
            // 
            // checkBoxCarrera
            // 
            this.checkBoxCarrera.AutoSize = true;
            this.checkBoxCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCarrera.Location = new System.Drawing.Point(358, 77);
            this.checkBoxCarrera.Name = "checkBoxCarrera";
            this.checkBoxCarrera.Size = new System.Drawing.Size(72, 20);
            this.checkBoxCarrera.TabIndex = 22;
            this.checkBoxCarrera.Text = "Carrera";
            this.checkBoxCarrera.UseVisualStyleBackColor = true;
            // 
            // comboBoxApunte
            // 
            this.comboBoxApunte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApunte.FormattingEnabled = true;
            this.comboBoxApunte.Location = new System.Drawing.Point(539, 50);
            this.comboBoxApunte.Name = "comboBoxApunte";
            this.comboBoxApunte.Size = new System.Drawing.Size(109, 21);
            this.comboBoxApunte.TabIndex = 25;
            this.comboBoxApunte.SelectedIndexChanged += new System.EventHandler(this.comboBoxApunte_SelectedIndexChanged);
            // 
            // checkBoxApunte
            // 
            this.checkBoxApunte.AutoSize = true;
            this.checkBoxApunte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxApunte.Location = new System.Drawing.Point(539, 24);
            this.checkBoxApunte.Name = "checkBoxApunte";
            this.checkBoxApunte.Size = new System.Drawing.Size(69, 20);
            this.checkBoxApunte.TabIndex = 24;
            this.checkBoxApunte.Text = "Apunte";
            this.checkBoxApunte.UseVisualStyleBackColor = true;
            // 
            // checkBoxCliente
            // 
            this.checkBoxCliente.AutoSize = true;
            this.checkBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCliente.Location = new System.Drawing.Point(122, 114);
            this.checkBoxCliente.Name = "checkBoxCliente";
            this.checkBoxCliente.Size = new System.Drawing.Size(68, 20);
            this.checkBoxCliente.TabIndex = 26;
            this.checkBoxCliente.Text = "Cliente";
            this.checkBoxCliente.UseVisualStyleBackColor = true;
            // 
            // comboBoxEncuadernillado
            // 
            this.comboBoxEncuadernillado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEncuadernillado.FormattingEnabled = true;
            this.comboBoxEncuadernillado.Location = new System.Drawing.Point(539, 103);
            this.comboBoxEncuadernillado.Name = "comboBoxEncuadernillado";
            this.comboBoxEncuadernillado.Size = new System.Drawing.Size(109, 21);
            this.comboBoxEncuadernillado.TabIndex = 29;
            // 
            // checkBoxEncuadernillado
            // 
            this.checkBoxEncuadernillado.AutoSize = true;
            this.checkBoxEncuadernillado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEncuadernillado.Location = new System.Drawing.Point(539, 77);
            this.checkBoxEncuadernillado.Name = "checkBoxEncuadernillado";
            this.checkBoxEncuadernillado.Size = new System.Drawing.Size(125, 20);
            this.checkBoxEncuadernillado.TabIndex = 28;
            this.checkBoxEncuadernillado.Text = "Encuadernillado";
            this.checkBoxEncuadernillado.UseVisualStyleBackColor = true;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(539, 155);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(109, 21);
            this.comboBoxEstado.TabIndex = 31;
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstado.Location = new System.Drawing.Point(539, 129);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(70, 20);
            this.checkBoxEstado.TabIndex = 30;
            this.checkBoxEstado.Text = "Estado";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(122, 140);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(109, 21);
            this.comboBoxCliente.TabIndex = 32;
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxCliente_SelectedIndexChanged);
            // 
            // buttonRealizado
            // 
            this.buttonRealizado.Location = new System.Drawing.Point(560, 391);
            this.buttonRealizado.Name = "buttonRealizado";
            this.buttonRealizado.Size = new System.Drawing.Size(104, 34);
            this.buttonRealizado.TabIndex = 33;
            this.buttonRealizado.Text = "CAMBIAR A REALIZADO";
            this.buttonRealizado.UseVisualStyleBackColor = true;
            this.buttonRealizado.Click += new System.EventHandler(this.buttonRealizado_Click);
            // 
            // buttonEntregado
            // 
            this.buttonEntregado.Location = new System.Drawing.Point(684, 391);
            this.buttonEntregado.Name = "buttonEntregado";
            this.buttonEntregado.Size = new System.Drawing.Size(104, 34);
            this.buttonEntregado.TabIndex = 34;
            this.buttonEntregado.Text = "CAMBIAR A ENTREGADO";
            this.buttonEntregado.UseVisualStyleBackColor = true;
            this.buttonEntregado.Click += new System.EventHandler(this.buttonEntregado_Click);
            // 
            // MuestraDePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.buttonEntregado);
            this.Controls.Add(this.buttonRealizado);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.checkBoxEstado);
            this.Controls.Add(this.comboBoxEncuadernillado);
            this.Controls.Add(this.checkBoxEncuadernillado);
            this.Controls.Add(this.checkBoxCliente);
            this.Controls.Add(this.comboBoxApunte);
            this.Controls.Add(this.checkBoxApunte);
            this.Controls.Add(this.comboBoxCarerra);
            this.Controls.Add(this.checkBoxCarrera);
            this.Controls.Add(this.comboBoxMateria);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxUniversidad);
            this.Controls.Add(this.checkBoxMateria);
            this.Controls.Add(this.checkBoxUniversidad);
            this.Controls.Add(this.checkBoxFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.dataGridPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MuestraDePedidos";
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.DataGridView dataGridPedidos;
        private System.Windows.Forms.ComboBox comboBoxUniversidad;
        private System.Windows.Forms.CheckBox checkBoxMateria;
        private System.Windows.Forms.CheckBox checkBoxUniversidad;
        private System.Windows.Forms.CheckBox checkBoxFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private System.Windows.Forms.ComboBox comboBoxCarerra;
        private System.Windows.Forms.CheckBox checkBoxCarrera;
        private System.Windows.Forms.ComboBox comboBoxApunte;
        private System.Windows.Forms.CheckBox checkBoxApunte;
        private System.Windows.Forms.CheckBox checkBoxCliente;
        private System.Windows.Forms.ComboBox comboBoxEncuadernillado;
        private System.Windows.Forms.CheckBox checkBoxEncuadernillado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Button buttonRealizado;
        private System.Windows.Forms.Button buttonEntregado;
    }
}