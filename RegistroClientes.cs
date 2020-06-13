using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FotocopiadoraFacultad
{
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
            SocioDeCoop.DisplayMember = "Text";
            SocioDeCoop.ValueMember = "Value";

            var items = new[] 
            {
                new { Text = "SI", Value = 1 },
                new { Text = "NO", Value = 2 }
            };

            SocioDeCoop.DataSource = items;
        }

        private void Idtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreText_TextChanged(object sender, EventArgs e)
        {

        }
  
        private void TelefonoText_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cargar_Click(object sender, EventArgs e)
        {
            //Idtext.Text + ",'" + NombreText.Text + "'," + TelefonoText.Text + ",'" + SocioDeCoop.Text;
            int dni = int.Parse(Idtext.Text);
            string nombre = NombreText.Text;
            string telefono = TelefonoText.Text;
            int socioDeCoop = int.Parse(SocioDeCoop.SelectedItem.GetType()
                .GetProperty("Value").GetValue(SocioDeCoop.SelectedItem, null).ToString());
            var conexion = new Conexion();
            conexion.AgregarCliente(dni,nombre,telefono,socioDeCoop);
            MessageBox.Show("El Cliente se agrego correctamente a la lista");
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
