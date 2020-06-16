using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FotocopiadoraFacultad
{
    public partial class MuestraDePedidos : Form
    {
        public MuestraDePedidos()
        {
            InitializeComponent();
            var conexion = new Conexion();
            conexion.CargarComboUniversidad(comboBoxUniversidad);

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

            conexion.CargarComboCliente(comboBoxCliente);
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            var conexion = new Conexion();
            string consulta = $"Select IdPedido 'Numero de Pedido', Fecha, U.Nombre 'Universidad', C.Nombre 'Carrera', " +
                $"M.Nombre 'Materia', A.Nombre 'Apunte', Cli.Nombre 'Cliente', " +
                $"case when P.Encuadernillado = 1 then 'SI' else 'NO'end 'Anillado', " +
                $"case when P.Estado=1 then 'Pendiente' when P.Estado=2 then 'Realizado' else 'Terminado' end 'Estado', " +
                $"P.PrecioTotal 'Total a pagar' " +
                $"from Pedido P inner join Universidad U " +
                $"on U.IdUniversidad = P.CodigoUniversidad " +
                $"inner join Carrera C on C.IdCarrera = P.CodigoCarrera " +
                $"inner join Materia M on M.IdMateria = P.CodigoMateria " +
                $"inner join Apunte A on A.IdApunte = P.CodigoApunte " +
                $"inner join Cliente Cli on Cli.IdCliente = P.CodigoCliente ";
            if (checkBoxFecha.Checked || checkBoxCliente.Checked || checkBoxUniversidad.Checked || checkBoxCarrera.Checked || checkBoxMateria.Checked || checkBoxApunte.Checked || checkBoxEncuadernillado.Checked || checkBoxEstado.Checked)
            {
                consulta = consulta + $"where ";
                if (checkBoxFecha.Checked)
                {
                    string fechaSeleccionada = dateTimePicker1.Value.ToString("yyyyMMdd");
                    consulta = consulta + $"AND P.Fecha = {fechaSeleccionada} ";
                }
                if (checkBoxCliente.Checked)
                {
                    var cliente = int.Parse(comboBoxCliente.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboBoxCliente.SelectedItem, null).ToString());
                    consulta = consulta + $"AND P.CodigoCliente = {cliente} ";
                }
                if (checkBoxUniversidad.Checked)
                {
                    var universidad = int.Parse(comboBoxUniversidad.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboBoxUniversidad.SelectedItem, null).ToString());
                    consulta = consulta + $"AND P.CodigoUniversidad = {universidad} ";
                }
                if (checkBoxCarrera.Checked)
                {
                    var carrera = int.Parse(comboBoxCarerra.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboBoxCarerra.SelectedItem, null).ToString());
                    consulta = consulta + $"AND P.CodigoCarrera = {carrera} ";
                }
                if (checkBoxMateria.Checked)
                {
                    var materia = int.Parse(comboBoxMateria.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboBoxMateria.SelectedItem, null).ToString());
                    consulta = consulta + $"AND P.CodigoMateria = {materia} ";
                }
                if (checkBoxApunte.Checked)
                {
                    var apunte = int.Parse(comboBoxApunte.SelectedItem.GetType()
                     .GetProperty("Value").GetValue(comboBoxApunte.SelectedItem, null).ToString());
                    consulta = consulta + $"AND P.CodigoApunte = {apunte} ";
                }
                if (checkBoxEncuadernillado.Checked)
                {
                    var anillado = int.Parse(comboBoxEncuadernillado.SelectedItem.GetType()
                .GetProperty("Value").GetValue(comboBoxEncuadernillado.SelectedItem, null).ToString());
                    consulta = consulta + $"AND P.Encuadernillado = {anillado}";
                }
                if (checkBoxEstado.Checked)
                {
                    var estado = int.Parse(comboBoxEstado.SelectedItem.GetType()
                .GetProperty("Value").GetValue(comboBoxEstado.SelectedItem, null).ToString());
                    consulta = consulta + $"AND P.Estado = {estado}";
                }

                consulta = consulta.Replace("where AND", "where");
            }
            conexion.cnn.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, conexion.cnn);
            DataSet DS = new DataSet();
            var commandBuilder = new SqlCommandBuilder(Adaptador);
            var ds = new DataSet();
            Adaptador.Fill(ds);
            dataGridPedidos.ReadOnly = false;
            dataGridPedidos.DataSource = ds.Tables[0];
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

        private void comboBoxApunte_SelectedIndexChanged(object sender, EventArgs e)
        {
            int apunte = 0;
            if (comboBoxApunte.SelectedItem != null)
            {
                apunte = int.Parse(comboBoxApunte.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboBoxApunte.SelectedItem, null).ToString());
            }
            var conexion = new Conexion();
        }

        private void buttonRealizado_Click(object sender, EventArgs e)
        {
            if(dataGridPedidos.SelectedRows.Count>0)
            {
                var seleccionado = dataGridPedidos.SelectedRows[0];
                int id = int.Parse(seleccionado.Cells[0].Value.ToString());
                int Estado = 2;
                var conexion = new Conexion();
                conexion.ActualizarEstado(id, Estado);
            }
            else
            {
                MessageBox.Show("Seleccione la fila de un pedido para poder actualizar el estado.");
            }
             
        }

        private void buttonEntregado_Click(object sender, EventArgs e)
        {
            if (dataGridPedidos.SelectedRows.Count > 0)
            {
                var seleccionado = dataGridPedidos.SelectedRows[0];
                int id = int.Parse(seleccionado.Cells[0].Value.ToString());
                int Estado = 3;
                var conexion = new Conexion();
                conexion.ActualizarEstado(id, Estado);
            }
            else
            {
                MessageBox.Show("Seleccione la fila de un pedido para poder actualizar el estado.");
            }
        }
    }
}
