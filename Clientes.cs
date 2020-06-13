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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistroCliente_Click(object sender, EventArgs e)
        {
            using (RegistroClientes ventanaRegistroClientes = new RegistroClientes())
                ventanaRegistroClientes.ShowDialog();
        }
    }
}
