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
    public partial class InicioDos : Form
    {
        public object Response { get; private set; }

        public InicioDos()
        {
            InitializeComponent();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            using (Clientes ventanaClientes = new Clientes())
                ventanaClientes.ShowDialog();
        }
        private void Pedidos_Click(object sender, EventArgs e)
        {
            using (Pedidos ventanaPedidos = new Pedidos())
                ventanaPedidos.ShowDialog();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
