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
            string Cadena = "Insert into Productos(Id, Nombre, Telefono, SocioDeCoop) values(" + Idtext.Text + ",'" + NombreText.Text + "'," + TelefonoText.Text + ",'" + SocioDeCoop.Text + "');";
            SqlConnection conexion = new SqlConnection(@"Data Source=UTNSF023\SQLEXPRESS;Initial Catalog=ProdEnOferta;User ID=sa;Password=utn");
            SqlCommand Comando = new SqlCommand(Cadena, conexion);
            conexion.Open();
            Comando.ExecuteNonQuery();
            conexion.Close();
            MessageBox.Show("El Cliente se agrego correctamente a la lista");
        }

        private void SocioDeCoop_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"lo que muestra el combo es: {SocioDeCoop.SelectedItem.GetType().GetProperty("Text").GetValue(SocioDeCoop.SelectedItem, null)} y " +
                       $"en la base de datos se va a guardar {SocioDeCoop.SelectedItem.GetType().GetProperty("Value").GetValue(SocioDeCoop.SelectedItem, null)}");
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
