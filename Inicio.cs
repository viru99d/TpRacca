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
        string contraseñaUsuario = "fotocopiadora123";
        string usuarioRegistrado = "fotocopiadora123";

        public inicio()
        {
            InitializeComponent();
        }

        private void controlarBotones()
        {
            
            if (nombre.Text.Trim() != string.Empty && nombre.Text == usuarioRegistrado)
            {
                botonIngresar.Enabled = true;
                errorProvider1.SetError(nombre, "");
            }

            else
            {
                if (!(nombre.Text == usuarioRegistrado))
                    errorProvider1.SetError(nombre, "El usuario no está registrado, comuniquese con el creador del sistema");

                else
                {
                    errorProvider1.SetError(nombre, "Debe introducir su usuario");
                }
                botonIngresar.Enabled = true;
                nombre.Focus();
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

        private void botonIngresar_Click(object sender, EventArgs e)
        {
           
            if (contraseña.Text != contraseñaUsuario)
            {
                System.Console.WriteLine("Contraseña incorrecta");
            }

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

        private void inicio_Load(object sender, EventArgs e)
        {
            botonIngresar.Enabled = false;
        }
    }
}
