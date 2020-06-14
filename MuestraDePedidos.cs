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
    public partial class MuestraDePedidos : Form
    {
        public MuestraDePedidos()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxUniversidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int universidad = 0;
            if (comboBoxUniversidad.SelectedItem != null)
            {
                universidad = int.Parse(comboBoxUniversidad.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboBoxUniversidad.SelectedItem, null).ToString());
            }
            var conexion = new Conexion();
            conexion.CargarComboCarrera(universidad, comboBoxUniversidad);
        }
    }
}
