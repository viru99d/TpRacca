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
            this.cbxUniversidad = new System.Windows.Forms.ComboBox();
            this.comboMateria = new System.Windows.Forms.ComboBox();
            this.comboCarrera = new System.Windows.Forms.ComboBox();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.comboApunte = new System.Windows.Forms.ComboBox();
            this.comboAnillado = new System.Windows.Forms.ComboBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
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
            this.label8 = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.control_de_Pedidos_Fotocopiadora_UTNDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controldePedidosFotocopiadoraUTNDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxUniversidad
            // 
            this.cbxUniversidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUniversidad.FormattingEnabled = true;
            this.cbxUniversidad.Location = new System.Drawing.Point(294, 65);
            this.cbxUniversidad.Margin = new System.Windows.Forms.Padding(2);
            this.cbxUniversidad.Name = "cbxUniversidad";
            this.cbxUniversidad.Size = new System.Drawing.Size(147, 21);
            this.cbxUniversidad.TabIndex = 1;
            this.cbxUniversidad.SelectedIndexChanged += new System.EventHandler(this.comboBPedido_SelectedIndexChanged);
            // 
            // comboMateria
            // 
            this.comboMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMateria.FormattingEnabled = true;
            this.comboMateria.Location = new System.Drawing.Point(294, 133);
            this.comboMateria.Margin = new System.Windows.Forms.Padding(2);
            this.comboMateria.Name = "comboMateria";
            this.comboMateria.Size = new System.Drawing.Size(147, 21);
            this.comboMateria.TabIndex = 4;
            this.comboMateria.SelectedIndexChanged += new System.EventHandler(this.comboMateria_SelectedIndexChanged);
            // 
            // comboCarrera
            // 
            this.comboCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCarrera.FormattingEnabled = true;
            this.comboCarrera.Location = new System.Drawing.Point(294, 97);
            this.comboCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.comboCarrera.Name = "comboCarrera";
            this.comboCarrera.Size = new System.Drawing.Size(147, 21);
            this.comboCarrera.TabIndex = 5;
            this.comboCarrera.SelectedIndexChanged += new System.EventHandler(this.comboCarrera_SelectedIndexChanged);
            // 
            // comboCliente
            // 
            this.comboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(294, 207);
            this.comboCliente.Margin = new System.Windows.Forms.Padding(2);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(147, 21);
            this.comboCliente.TabIndex = 6;
            // 
            // comboApunte
            // 
            this.comboApunte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboApunte.FormattingEnabled = true;
            this.comboApunte.Location = new System.Drawing.Point(294, 171);
            this.comboApunte.Margin = new System.Windows.Forms.Padding(2);
            this.comboApunte.Name = "comboApunte";
            this.comboApunte.Size = new System.Drawing.Size(147, 21);
            this.comboApunte.TabIndex = 7;
            // 
            // comboAnillado
            // 
            this.comboAnillado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAnillado.FormattingEnabled = true;
            this.comboAnillado.Location = new System.Drawing.Point(294, 241);
            this.comboAnillado.Margin = new System.Windows.Forms.Padding(2);
            this.comboAnillado.Name = "comboAnillado";
            this.comboAnillado.Size = new System.Drawing.Size(147, 21);
            this.comboAnillado.TabIndex = 9;
            this.comboAnillado.SelectedIndexChanged += new System.EventHandler(this.comboAnillado_SelectedIndexChanged);
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(294, 277);
            this.comboEstado.Margin = new System.Windows.Forms.Padding(2);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(147, 21);
            this.comboEstado.TabIndex = 10;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(462, 324);
            this.botonAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(112, 45);
            this.botonAgregar.TabIndex = 11;
            this.botonAgregar.Text = "CARGAR DATOS";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(12, 324);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(112, 45);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "UNIVERSIDAD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "MATERIA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "CARRERA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "CLIENTE N°:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 246);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "ANILLADO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "APUNTE N°:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(144, 282);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "ESTADO PEDIDO:";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(149, 9);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(292, 36);
            this.Titulo.TabIndex = 21;
            this.Titulo.Text = "CARGA EL NUEVO PEDIDO:";
            // 
            // registrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 381);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.comboAnillado);
            this.Controls.Add(this.comboApunte);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.comboCarrera);
            this.Controls.Add(this.comboMateria);
            this.Controls.Add(this.cbxUniversidad);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "registrarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Pedidos";
            this.Load += new System.EventHandler(this.registrarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.control_de_Pedidos_Fotocopiadora_UTNDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controldePedidosFotocopiadoraUTNDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxUniversidad;
        private System.Windows.Forms.ComboBox comboMateria;
        private System.Windows.Forms.ComboBox comboCarrera;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.ComboBox comboApunte;
        private System.Windows.Forms.ComboBox comboAnillado;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button Volver;
        private Control_de_Pedidos_Fotocopiadora_UTNDataSet control_de_Pedidos_Fotocopiadora_UTNDataSet;
        private System.Windows.Forms.BindingSource controldePedidosFotocopiadoraUTNDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Titulo;
    }
}