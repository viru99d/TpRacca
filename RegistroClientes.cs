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
    public partial class RegistroClientes : Form
    {
        public RegistroClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conexion = new Conexion();
            SqlDataAdapter Adaptador = new SqlDataAdapter("Select * from Cliente", conexion.cnn);
            DataSet DS = new DataSet();
            //Adaptador.Fill(DS, "Clientes");
            //dataGridView1.DataSource = DS;
            //dataGridView1.DataMember = "Clientes";
            var commandBuilder = new SqlCommandBuilder(Adaptador);
            var ds = new DataSet();
            Adaptador.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
