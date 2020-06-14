namespace FotocopiadoraFacultad
{
    partial class MuestraDeClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuestraDeClientes));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Buscar = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.checkBoxNombre = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.checkBoxId = new System.Windows.Forms.CheckBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.checkBoxTelefono = new System.Windows.Forms.CheckBox();
            this.checkBoxSocioDeCoop = new System.Windows.Forms.CheckBox();
            this.comboBoxSocio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 140);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(653, 390);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(104, 34);
            this.Buscar.TabIndex = 1;
            this.Buscar.Text = "BUSCAR";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(60, 390);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(104, 34);
            this.Volver.TabIndex = 2;
            this.Volver.Text = "VOLVER";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // checkBoxNombre
            // 
            this.checkBoxNombre.AutoSize = true;
            this.checkBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNombre.Location = new System.Drawing.Point(231, 77);
            this.checkBoxNombre.Name = "checkBoxNombre";
            this.checkBoxNombre.Size = new System.Drawing.Size(76, 20);
            this.checkBoxNombre.TabIndex = 3;
            this.checkBoxNombre.Text = "Nombre";
            this.checkBoxNombre.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "FILTRAR POR:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(231, 104);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 5;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(82, 104);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 7;
            // 
            // checkBoxId
            // 
            this.checkBoxId.AutoSize = true;
            this.checkBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxId.Location = new System.Drawing.Point(82, 77);
            this.checkBoxId.Name = "checkBoxId";
            this.checkBoxId.Size = new System.Drawing.Size(50, 20);
            this.checkBoxId.TabIndex = 6;
            this.checkBoxId.Text = "DNI";
            this.checkBoxId.UseVisualStyleBackColor = true;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(392, 104);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefono.TabIndex = 9;
            // 
            // checkBoxTelefono
            // 
            this.checkBoxTelefono.AutoSize = true;
            this.checkBoxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTelefono.Location = new System.Drawing.Point(392, 77);
            this.checkBoxTelefono.Name = "checkBoxTelefono";
            this.checkBoxTelefono.Size = new System.Drawing.Size(81, 20);
            this.checkBoxTelefono.TabIndex = 8;
            this.checkBoxTelefono.Text = "Telefono";
            this.checkBoxTelefono.UseVisualStyleBackColor = true;
            // 
            // checkBoxSocioDeCoop
            // 
            this.checkBoxSocioDeCoop.AutoSize = true;
            this.checkBoxSocioDeCoop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSocioDeCoop.Location = new System.Drawing.Point(572, 77);
            this.checkBoxSocioDeCoop.Name = "checkBoxSocioDeCoop";
            this.checkBoxSocioDeCoop.Size = new System.Drawing.Size(167, 20);
            this.checkBoxSocioDeCoop.TabIndex = 10;
            this.checkBoxSocioDeCoop.Text = "Socio De Cooperadora";
            this.checkBoxSocioDeCoop.UseVisualStyleBackColor = true;
            // 
            // comboBoxSocio
            // 
            this.comboBoxSocio.FormattingEnabled = true;
            this.comboBoxSocio.Location = new System.Drawing.Point(572, 104);
            this.comboBoxSocio.Name = "comboBoxSocio";
            this.comboBoxSocio.Size = new System.Drawing.Size(109, 21);
            this.comboBoxSocio.TabIndex = 11;
            // 
            // MuestraDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(809, 450);
            this.Controls.Add(this.comboBoxSocio);
            this.Controls.Add(this.checkBoxSocioDeCoop);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.checkBoxTelefono);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.checkBoxId);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxNombre);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MuestraDeClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.CheckBox checkBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.CheckBox checkBoxId;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.CheckBox checkBoxTelefono;
        private System.Windows.Forms.CheckBox checkBoxSocioDeCoop;
        private System.Windows.Forms.ComboBox comboBoxSocio;
    }
}