using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FotocopiadoraFacultad
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Nombre_LostFocus(object sender, EventArgs e)
        {
            controlBotonNombre();
        }

        private void Contraseña_LostFocus(object sender, EventArgs e)
        {
            controlBotonContraseña();
        }


        private void controlBotonNombre()
        {
            if (Nombre.Text.Trim() == "Fotocopiadora 123")
            {
                inicioSesión.Enabled = true;
                errorProvider1.SetError(Nombre, "");
            }
            else
            {
                errorProvider1.SetError(Nombre, "El usuario es incorrecto");
                inicioSesión.Enabled = false;
                Nombre.Focus();
            }
        }

        private void controlBotonContraseña()
        {
            if (Contraseña.Text.Trim() == "12345678")
            {
                inicioSesión.Enabled = true;
                errorProvider2.SetError(Contraseña, "");
            }
            else
            {
                errorProvider2.SetError(Contraseña, "La contraseña es incorrecta");
                inicioSesión.Enabled = false;
                Contraseña.Focus();
            }
        }

        private void inicioSesión_Click(object sender, EventArgs e)
        {
            inicioSesión.Enabled = false;
            using (InicioDos ventanaInicioDos = new InicioDos())
                ventanaInicioDos.ShowDialog();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
