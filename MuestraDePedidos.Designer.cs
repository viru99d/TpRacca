﻿namespace FotocopiadoraFacultad
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.checkBoxId = new System.Windows.Forms.CheckBox();
            this.checkBoxFecha = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.comboBoxCarerra = new System.Windows.Forms.ComboBox();
            this.checkBoxCarrera = new System.Windows.Forms.CheckBox();
            this.comboBoxApunte = new System.Windows.Forms.ComboBox();
            this.checkBoxApunte = new System.Windows.Forms.CheckBox();
            this.textBoxCliente = new System.Windows.Forms.TextBox();
            this.checkBoxCliente = new System.Windows.Forms.CheckBox();
            this.comboBoxEncuadernillado = new System.Windows.Forms.ComboBox();
            this.checkBoxEncuadernillado = new System.Windows.Forms.CheckBox();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 9);
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
            this.Buscar.Location = new System.Drawing.Point(650, 391);
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
            this.dataGridPedidos.Location = new System.Drawing.Point(20, 216);
            this.dataGridPedidos.Name = "dataGridPedidos";
            this.dataGridPedidos.Size = new System.Drawing.Size(765, 169);
            this.dataGridPedidos.TabIndex = 5;
            // 
            // comboBoxUniversidad
            // 
            this.comboBoxUniversidad.FormattingEnabled = true;
            this.comboBoxUniversidad.Location = new System.Drawing.Point(354, 73);
            this.comboBoxUniversidad.Name = "comboBoxUniversidad";
            this.comboBoxUniversidad.Size = new System.Drawing.Size(109, 21);
            this.comboBoxUniversidad.TabIndex = 19;
            this.comboBoxUniversidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxUniversidad_SelectedIndexChanged);
            // 
            // checkBoxMateria
            // 
            this.checkBoxMateria.AutoSize = true;
            this.checkBoxMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMateria.Location = new System.Drawing.Point(354, 153);
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
            this.checkBoxUniversidad.Location = new System.Drawing.Point(354, 47);
            this.checkBoxUniversidad.Name = "checkBoxUniversidad";
            this.checkBoxUniversidad.Size = new System.Drawing.Size(100, 20);
            this.checkBoxUniversidad.TabIndex = 16;
            this.checkBoxUniversidad.Text = "Universidad";
            this.checkBoxUniversidad.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(119, 74);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 15;
            // 
            // checkBoxId
            // 
            this.checkBoxId.AutoSize = true;
            this.checkBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxId.Location = new System.Drawing.Point(119, 47);
            this.checkBoxId.Name = "checkBoxId";
            this.checkBoxId.Size = new System.Drawing.Size(85, 20);
            this.checkBoxId.TabIndex = 14;
            this.checkBoxId.Text = "Id Pedido";
            this.checkBoxId.UseVisualStyleBackColor = true;
            // 
            // checkBoxFecha
            // 
            this.checkBoxFecha.AutoSize = true;
            this.checkBoxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFecha.Location = new System.Drawing.Point(119, 100);
            this.checkBoxFecha.Name = "checkBoxFecha";
            this.checkBoxFecha.Size = new System.Drawing.Size(65, 20);
            this.checkBoxFecha.TabIndex = 12;
            this.checkBoxFecha.Text = "Fecha";
            this.checkBoxFecha.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(188, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Location = new System.Drawing.Point(354, 179);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(109, 21);
            this.comboBoxMateria.TabIndex = 21;
            // 
            // comboBoxCarerra
            // 
            this.comboBoxCarerra.FormattingEnabled = true;
            this.comboBoxCarerra.Location = new System.Drawing.Point(354, 126);
            this.comboBoxCarerra.Name = "comboBoxCarerra";
            this.comboBoxCarerra.Size = new System.Drawing.Size(109, 21);
            this.comboBoxCarerra.TabIndex = 23;
            // 
            // checkBoxCarrera
            // 
            this.checkBoxCarrera.AutoSize = true;
            this.checkBoxCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCarrera.Location = new System.Drawing.Point(354, 100);
            this.checkBoxCarrera.Name = "checkBoxCarrera";
            this.checkBoxCarrera.Size = new System.Drawing.Size(72, 20);
            this.checkBoxCarrera.TabIndex = 22;
            this.checkBoxCarrera.Text = "Carrera";
            this.checkBoxCarrera.UseVisualStyleBackColor = true;
            // 
            // comboBoxApunte
            // 
            this.comboBoxApunte.FormattingEnabled = true;
            this.comboBoxApunte.Location = new System.Drawing.Point(535, 73);
            this.comboBoxApunte.Name = "comboBoxApunte";
            this.comboBoxApunte.Size = new System.Drawing.Size(109, 21);
            this.comboBoxApunte.TabIndex = 25;
            // 
            // checkBoxApunte
            // 
            this.checkBoxApunte.AutoSize = true;
            this.checkBoxApunte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxApunte.Location = new System.Drawing.Point(535, 47);
            this.checkBoxApunte.Name = "checkBoxApunte";
            this.checkBoxApunte.Size = new System.Drawing.Size(69, 20);
            this.checkBoxApunte.TabIndex = 24;
            this.checkBoxApunte.Text = "Apunte";
            this.checkBoxApunte.UseVisualStyleBackColor = true;
            // 
            // textBoxCliente
            // 
            this.textBoxCliente.Location = new System.Drawing.Point(119, 179);
            this.textBoxCliente.Name = "textBoxCliente";
            this.textBoxCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxCliente.TabIndex = 27;
            // 
            // checkBoxCliente
            // 
            this.checkBoxCliente.AutoSize = true;
            this.checkBoxCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCliente.Location = new System.Drawing.Point(119, 152);
            this.checkBoxCliente.Name = "checkBoxCliente";
            this.checkBoxCliente.Size = new System.Drawing.Size(68, 20);
            this.checkBoxCliente.TabIndex = 26;
            this.checkBoxCliente.Text = "Cliente";
            this.checkBoxCliente.UseVisualStyleBackColor = true;
            // 
            // comboBoxEncuadernillado
            // 
            this.comboBoxEncuadernillado.FormattingEnabled = true;
            this.comboBoxEncuadernillado.Location = new System.Drawing.Point(535, 126);
            this.comboBoxEncuadernillado.Name = "comboBoxEncuadernillado";
            this.comboBoxEncuadernillado.Size = new System.Drawing.Size(109, 21);
            this.comboBoxEncuadernillado.TabIndex = 29;
            // 
            // checkBoxEncuadernillado
            // 
            this.checkBoxEncuadernillado.AutoSize = true;
            this.checkBoxEncuadernillado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEncuadernillado.Location = new System.Drawing.Point(535, 100);
            this.checkBoxEncuadernillado.Name = "checkBoxEncuadernillado";
            this.checkBoxEncuadernillado.Size = new System.Drawing.Size(125, 20);
            this.checkBoxEncuadernillado.TabIndex = 28;
            this.checkBoxEncuadernillado.Text = "Encuadernillado";
            this.checkBoxEncuadernillado.UseVisualStyleBackColor = true;
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(535, 178);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(109, 21);
            this.comboBoxEstado.TabIndex = 31;
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstado.Location = new System.Drawing.Point(535, 152);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(70, 20);
            this.checkBoxEstado.TabIndex = 30;
            this.checkBoxEstado.Text = "Estado";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // MuestraDePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.checkBoxEstado);
            this.Controls.Add(this.comboBoxEncuadernillado);
            this.Controls.Add(this.checkBoxEncuadernillado);
            this.Controls.Add(this.textBoxCliente);
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
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.checkBoxId);
            this.Controls.Add(this.checkBoxFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.dataGridPedidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.CheckBox checkBoxId;
        private System.Windows.Forms.CheckBox checkBoxFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private System.Windows.Forms.ComboBox comboBoxCarerra;
        private System.Windows.Forms.CheckBox checkBoxCarrera;
        private System.Windows.Forms.ComboBox comboBoxApunte;
        private System.Windows.Forms.CheckBox checkBoxApunte;
        private System.Windows.Forms.TextBox textBoxCliente;
        private System.Windows.Forms.CheckBox checkBoxCliente;
        private System.Windows.Forms.ComboBox comboBoxEncuadernillado;
        private System.Windows.Forms.CheckBox checkBoxEncuadernillado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.CheckBox checkBoxEstado;
    }
}