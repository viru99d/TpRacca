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
            comboBoxEncuadernillado.DisplayMember = "Text";
            comboBoxEncuadernillado.ValueMember = "Value";

            var items = new[]
            {
                new { Text = "SI", Value = 1 },
                new { Text = "NO", Value = 2 }
            };

            comboBoxEncuadernillado.DataSource = items;

            comboBoxEstado.DisplayMember = "Text";
            comboBoxEstado.ValueMember = "Value";

            var items2 = new[]
            {
                new { Text = "PENDIENTE", Value = 1 },
                new { Text = "REALIZADO", Value = 2 },
                new { Text = "ENTREGADO", Value = 3 },

            };

            comboBoxEstado.DataSource = items2;
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            var conexion = new Conexion();
            string consulta = "Select * from Pedido ";
            if (checkBoxFecha.Checked || checkBoxCliente.Checked || checkBoxUniversidad.Checked || checkBoxCarrera.Checked || checkBoxMateria.Checked || checkBoxApunte.Checked || checkBoxEncuadernillado.Checked || checkBoxEstado.Checked)
            {
                consulta = consulta + $"where ";
                if (checkBoxFecha.Checked)
                {
                    string fechaSeleccionada = dateTimePicker1.Value.ToString("yyyyMMdd");
                    consulta = consulta + $"AND Fecha = {fechaSeleccionada} ";
                }
                if (checkBoxCliente.Checked)
                {
                    var cliente = int.Parse(comboBoxCliente.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboBoxCliente.SelectedItem, null).ToString());
                    consulta = consulta + $"AND CodigoCliente = {cliente} ";
                }
                if (checkBoxUniversidad.Checked)
                {
                    var universidad = int.Parse(comboBoxUniversidad.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboBoxUniversidad.SelectedItem, null).ToString());
                    consulta = consulta + $"AND CodigoUniversidad = {universidad} ";
                }
                if (checkBoxCarrera.Checked)
                {
                    var carrera = int.Parse(comboBoxCarerra.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboBoxCarerra.SelectedItem, null).ToString());
                    consulta = consulta + $"AND CodigoCarrera = {carrera} ";
                }
                if(checkBoxMateria.Checked)
                {
                    var materia = int.Parse(comboBoxMateria.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboBoxMateria.SelectedItem, null).ToString());
                    consulta = consulta + $"AND CodigoMateria = {materia} ";
                }
                if(checkBoxApunte.Checked)
                {

                }
                if(checkBoxEncuadernillado.Checked)
                {

                }

                consulta = consulta.Replace("where AND", "where");

            }
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
            conexion.CargarComboCarrera(universidad, comboBoxCarerra);
        }

        private void comboBoxCarerra_SelectedIndexChanged(object sender, EventArgs e)
        {
            int carrera = 0;
            if (comboBoxCarerra.SelectedItem != null)
            {
                carrera = int.Parse(comboBoxCarerra.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboBoxCarerra.SelectedItem, null).ToString());
            }
            var conexion = new Conexion();
            conexion.CargarComboMateria(carrera, comboBoxMateria);
        }

        private void comboBoxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int materia = 0;
            if (comboBoxMateria.SelectedItem != null)
            {
                materia = int.Parse(comboBoxMateria.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboBoxMateria.SelectedItem, null).ToString());
            }
            var conexion = new Conexion();
            conexion.CargarComboApunte(materia, comboBoxApunte);
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cliente = 0;
            if (comboBoxCliente.SelectedItem != null)
            {
                cliente = int.Parse(comboBoxCliente.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboBoxCliente.SelectedItem, null).ToString());
            }
            var conexion = new Conexion();
        }
    }
}
