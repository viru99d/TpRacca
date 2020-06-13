namespace FotocopiadoraFacultad
{
    partial class registrarPedido
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
            this.components = new System.ComponentModel.Container();
            this.dtgvPedidos = new System.Windows.Forms.DataGridView();
            this.idPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoUniversidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCarrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoApunte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encuadernillado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBPedido = new System.Windows.Forms.ComboBox();
            this.comboMateria = new System.Windows.Forms.ComboBox();
            this.comboCarrera = new System.Windows.Forms.ComboBox();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.comboApunte = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboAnillado = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.control_de_Pedidos_Fotocopiadora_UTNDataSet = new FotocopiadoraFacultad.Control_de_Pedidos_Fotocopiadora_UTNDataSet();
            this.controldePedidosFotocopiadoraUTNDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_de_Pedidos_Fotocopiadora_UTNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controldePedidosFotocopiadoraUTNDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPedidos
            // 
            this.dtgvPedidos.AllowUserToAddRows = false;
            this.dtgvPedidos.AllowUserToDeleteRows = false;
            this.dtgvPedidos.AllowUserToOrderColumns = true;
            this.dtgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedido,
            this.Fecha,
            this.codigoUniversidad,
            this.codigoCarrera,
            this.codigoMateria,
            this.codigoCliente,
            this.codigoApunte,
            this.Encuadernillado,
            this.precioTotal,
            this.estado});
            this.dtgvPedidos.Location = new System.Drawing.Point(9, 10);
            this.dtgvPedidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgvPedidos.Name = "dtgvPedidos";
            this.dtgvPedidos.ReadOnly = true;
            this.dtgvPedidos.RowTemplate.Height = 24;
            this.dtgvPedidos.Size = new System.Drawing.Size(844, 195);
            this.dtgvPedidos.TabIndex = 0;
            this.dtgvPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvPedidos_CellContentClick);
            // 
            // idPedido
            // 
            this.idPedido.HeaderText = "N° Pedido";
            this.idPedido.Name = "idPedido";
            this.idPedido.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // codigoUniversidad
            // 
            this.codigoUniversidad.HeaderText = "Codigo Universidad";
            this.codigoUniversidad.Name = "codigoUniversidad";
            this.codigoUniversidad.ReadOnly = true;
            // 
            // codigoCarrera
            // 
            this.codigoCarrera.HeaderText = "Codigo Carrera";
            this.codigoCarrera.Name = "codigoCarrera";
            this.codigoCarrera.ReadOnly = true;
            // 
            // codigoMateria
            // 
            this.codigoMateria.HeaderText = "Codigo Materia";
            this.codigoMateria.Name = "codigoMateria";
            this.codigoMateria.ReadOnly = true;
            // 
            // codigoCliente
            // 
            this.codigoCliente.HeaderText = "N° Cliente";
            this.codigoCliente.Name = "codigoCliente";
            this.codigoCliente.ReadOnly = true;
            // 
            // codigoApunte
            // 
            this.codigoApunte.HeaderText = "N° Apunte";
            this.codigoApunte.Name = "codigoApunte";
            this.codigoApunte.ReadOnly = true;
            // 
            // Encuadernillado
            // 
            this.Encuadernillado.HeaderText = "Anillado";
            this.Encuadernillado.Name = "Encuadernillado";
            this.Encuadernillado.ReadOnly = true;
            // 
            // precioTotal
            // 
            this.precioTotal.HeaderText = "Precio total";
            this.precioTotal.Name = "precioTotal";
            this.precioTotal.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado ";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // comboBPedido
            // 
            this.comboBPedido.FormattingEnabled = true;
            this.comboBPedido.Location = new System.Drawing.Point(26, 264);
            this.comboBPedido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBPedido.Name = "comboBPedido";
            this.comboBPedido.Size = new System.Drawing.Size(90, 21);
            this.comboBPedido.TabIndex = 1;
            // 
            // comboMateria
            // 
            this.comboMateria.FormattingEnabled = true;
            this.comboMateria.Location = new System.Drawing.Point(233, 264);
            this.comboMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboMateria.Name = "comboMateria";
            this.comboMateria.Size = new System.Drawing.Size(144, 21);
            this.comboMateria.TabIndex = 4;
            // 
            // comboCarrera
            // 
            this.comboCarrera.FormattingEnabled = true;
            this.comboCarrera.Location = new System.Drawing.Point(120, 264);
            this.comboCarrera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboCarrera.Name = "comboCarrera";
            this.comboCarrera.Size = new System.Drawing.Size(109, 21);
            this.comboCarrera.TabIndex = 5;
            // 
            // comboCliente
            // 
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(381, 264);
            this.comboCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(77, 21);
            this.comboCliente.TabIndex = 6;
            // 
            // comboApunte
            // 
            this.comboApunte.FormattingEnabled = true;
            this.comboApunte.Location = new System.Drawing.Point(462, 264);
            this.comboApunte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboApunte.Name = "comboApunte";
            this.comboApunte.Size = new System.Drawing.Size(80, 21);
            this.comboApunte.TabIndex = 7;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(619, 264);
            this.comboBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(57, 21);
            this.comboBox8.TabIndex = 8;
            // 
            // comboAnillado
            // 
            this.comboAnillado.FormattingEnabled = true;
            this.comboAnillado.Location = new System.Drawing.Point(546, 264);
            this.comboAnillado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboAnillado.Name = "comboAnillado";
            this.comboAnillado.Size = new System.Drawing.Size(69, 21);
            this.comboAnillado.TabIndex = 9;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(680, 264);
            this.comboBox10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(115, 21);
            this.comboBox10.TabIndex = 10;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(808, 255);
            this.botonAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(67, 36);
            this.botonAgregar.TabIndex = 11;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(9, 332);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(122, 32);
            this.Volver.TabIndex = 12;
            this.Volver.Text = "VOLVER";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // control_de_Pedidos_Fotocopiadora_UTNDataSet
            // 
            this.control_de_Pedidos_Fotocopiadora_UTNDataSet.DataSetName = "Control_de_Pedidos_Fotocopiadora_UTNDataSet";
            this.control_de_Pedidos_Fotocopiadora_UTNDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controldePedidosFotocopiadoraUTNDataSetBindingSource
            // 
            this.controldePedidosFotocopiadoraUTNDataSetBindingSource.DataSource = this.control_de_Pedidos_Fotocopiadora_UTNDataSet;
            this.controldePedidosFotocopiadoraUTNDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Universidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Materia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Carrera:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(378, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cliente N°:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(546, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Anillado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(462, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Apunte N°:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(619, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(677, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Estado Pedido:";
            // 
            // registrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 375);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.comboBox10);
            this.Controls.Add(this.comboAnillado);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.comboApunte);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.comboCarrera);
            this.Controls.Add(this.comboMateria);
            this.Controls.Add(this.comboBPedido);
            this.Controls.Add(this.dtgvPedidos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "registrarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Pedidos";
            this.Load += new System.EventHandler(this.registrarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.control_de_Pedidos_Fotocopiadora_UTNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controldePedidosFotocopiadoraUTNDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPedidos;
        private System.Windows.Forms.ComboBox comboBPedido;
        private System.Windows.Forms.ComboBox comboMateria;
        private System.Windows.Forms.ComboBox comboCarrera;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.ComboBox comboApunte;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox comboAnillado;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button Volver;
        private Control_de_Pedidos_Fotocopiadora_UTNDataSet control_de_Pedidos_Fotocopiadora_UTNDataSet;
        private System.Windows.Forms.BindingSource controldePedidosFotocopiadoraUTNDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoUniversidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoApunte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encuadernillado;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}