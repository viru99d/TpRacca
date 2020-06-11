using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FotocopiadoraFacultad
{
    public partial class usuario : Form
    {
        public usuario()
        {
            InitializeComponent();
        }

        private void controlarBotones()
        {
            string usuario = "gonzalo123";
            if (nombre.Text.Trim() != string.Empty && nombre.Text == usuario);
            {
                botonIngresar.Enabled = true;
                errorProvider1.SetError(nombre, "");
            }

            else
            {
                if (nombre.Text != usuario)
                    errorProvider1.SetError(nombre, "El usuario no está registrado, comuniquese con el creador del sistema");

                else
                {
                    errorProvider1.SetError(nombre, "Debe introducir su usuario");
                }
                botonIngresar.Enabled = false;
                nombre.Focus();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            botonIngresar.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection Con = new SqlConnection("Data Source =.; Initial Catalog = Control de Pedidos Fotocopiadora UTN; Integrated Security = True");
                Con.Open();
                MessageBox.Show("Se ha conectado correctamente a la base de datos");

            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrio un error, no se puedo conectar a la base de datos " + error.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingresarUsuario_TextChanged(object sender, EventArgs e)
        {
            controlarBotones();
        }

        
    }
}
