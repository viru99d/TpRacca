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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void controlarBotones()
        {
            string usuarioRegistrado = "gonzalo123";

            if (nombre.Text.Trim() != string.Empty && nombre.Text == usuarioRegistrado)
            {
                botonIngresar.Enabled = true;
                errorProvider1.SetError(nombre, " ");
            }

            else
            {
                if (!(nombre.Text == usuarioRegistrado))
                    errorProvider1.SetError(nombre, "El usuario no está registrado, comuniquese con el creador del sistema");

                else
                {
                    errorProvider1.SetError(nombre, "Debe introducir su usuario");
                }
                botonIngresar.Enabled = false;
                nombre.Focus();
            }
        }

        private void controlarBotones1()
        {
            if (nombre.Text.Trim() != string.Empty)
            {
                botonIngresar.Enabled = true;
                errorProvider1.SetError(contraseña, " ");
            }

            else
            {
                errorProvider1.SetError(nombre, "Debe introducir su usuario");
                
                botonIngresar.Enabled = false;
                nombre.Focus();
            }
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


        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            controlarBotones();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            controlarBotones1();
        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            botonIngresar.Enabled = false;
        }

    }
}
