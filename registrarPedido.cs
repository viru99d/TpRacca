using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace FotocopiadoraFacultad
{
    public partial class registrarPedido : Form
    {
        public registrarPedido()
        {
            InitializeComponent();
        }


        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtgvPedidos.Rows.Add();
            int cantFilas = dtgvPedidos.Rows.Count - 1;
            DateTime fecha = DateTime.Now;

            dtgvPedidos[0, cantFilas].Value = cantFilas+1;

            dtgvPedidos[1, cantFilas].Value = fecha;

            dtgvPedidos[2, cantFilas].Value = 1;

             
         

            /*int cantFilas = dtgvPedidos.Rows.Count - 1;

            dtgvPedidos[3, cantFilas].Value = codigoMateria.ToString();
            dtgvPedidos[4, cantFilas].Value = codigoCarrera.ToString();
            dtgvPedidos[5, cantFilas].Value = codigoCliente.ToString();
            dtgvPedidos[6, cantFilas].Value = codigoApunte.ToString();
            dtgvPedidos[7, cantFilas].Value = Encuadernillado.ToString();
            dtgvPedidos[8, cantFilas].Value = precioTotal.ToString();
            dtgvPedidos[9, cantFilas].Value = estado.ToString();*/
        }

        private void registrarPedido_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.llenar(comboBPedido);
            c.llenar1(comboMateria);
            c.llenar2(comboCarrera);

        }

        private void dtgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
