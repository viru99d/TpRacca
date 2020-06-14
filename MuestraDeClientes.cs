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
            conexion.cnn.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Cliente", conexion.cnn);
            DataSet DS = new DataSet();
            var commandBuilder = new SqlCommandBuilder(Adaptador);
            var ds = new DataSet();
            Adaptador.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void checkBoxNombre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MuestraDeClientes_Load(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxId_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxTelefono_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSocioDeCoop_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSocio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
