using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotocopiadoraFacultad
{
    public partial class MuestraDeClientes : Form
    {
        public MuestraDeClientes()
        {
            InitializeComponent();
            comboBoxSocio.DisplayMember = "Text";
            comboBoxSocio.ValueMember = "Value";

            var items = new[]
            {
                new { Text = "SI", Value = 1 },
                new { Text = "NO", Value = 2 }
            };

            comboBoxSocio.DataSource = items;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            var conexion = new Conexion();
            string consulta = "Select * from Cliente ";
            if(checkBoxId.Checked || checkBoxNombre.Checked || checkBoxTelefono.Checked || checkBoxSocioDeCoop.Checked)
            {
                consulta = consulta + $"where ";
                if (checkBoxId.Checked)
                {
                    consulta = consulta + $" IdCliente = {textBoxId.Text} ";
                }
                if (checkBoxNombre.Checked)
                {
                    consulta = consulta + $"AND Nombre = '{textBoxNombre.Text}' ";
                }
                if (checkBoxTelefono.Checked)
                {
                    consulta = consulta + $"AND Telefono = '{textBoxTelefono.Text}' ";
                }
                if (checkBoxSocioDeCoop.Checked)
                {
                    var Socio= int.Parse(comboBoxSocio.SelectedItem.GetType()
                .GetProperty("Value").GetValue(comboBoxSocio.SelectedItem, null).ToString());
                    consulta = consulta + $"AND SocioDeCoop = {Socio}";
                }
                consulta= consulta.Replace("where AND", "where");

            }
            conexion.cnn.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, conexion.cnn);
            DataSet DS = new DataSet();
            var commandBuilder = new SqlCommandBuilder(Adaptador);
            var ds = new DataSet();
            Adaptador.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
