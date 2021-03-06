﻿using System;
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
using System.Data.SqlTypes;

namespace FotocopiadoraFacultad
{
    public partial class registrarPedido : Form
    {
        public registrarPedido()
        {
            InitializeComponent();

            comboAnillado.DisplayMember = "Text";
            comboAnillado.ValueMember = "Value";

            var items = new[]
            {
                new { Text = "NO", Value = 1 },
                new { Text = "SI", Value = 2 }
            };

            comboAnillado.DataSource = items;

            comboEstado.DisplayMember = "Text";
            comboEstado.ValueMember = "Value";

            var items2 = new[]
            {
                new { Text = "PENDIENTE", Value = 1 },
                new { Text = "REALIZADO", Value = 2 },
                new { Text = "ENTREGADO", Value = 3 },

            };

            comboEstado.DataSource = items2;

        }


        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registrarPedido_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            c.CargarComboUniversidad(cbxUniversidad);
            c.CargarComboCliente(comboCliente);
  
        }

        private void comboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cliente = 0;
            if (comboCliente.SelectedItem != null)
            {
                cliente = int.Parse(comboCliente.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboCliente.SelectedItem, null).ToString());
            }
            var conexion = new Conexion();

        }

        private void comboBPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            int universidad = 0;
            if(cbxUniversidad.SelectedItem != null)
            {
                universidad = int.Parse(cbxUniversidad.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(cbxUniversidad.SelectedItem, null).ToString());                             
            }
            var conexion = new Conexion();
            conexion.CargarComboCarrera(universidad, comboCarrera);

        }

        private void comboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            int carrera = 0;
            if (comboCarrera.SelectedItem != null)
            {
                carrera = int.Parse(comboCarrera.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboCarrera.SelectedItem, null).ToString());
            }
            var conexion = new Conexion();
            conexion.CargarComboMateria(carrera, comboMateria);
        }

        private void comboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int materia = 0;
            if (comboMateria.SelectedItem != null)
            {
                materia = int.Parse(comboMateria.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboMateria.SelectedItem, null).ToString());
            }
            var conexion = new Conexion();
            conexion.CargarComboApunte(materia, comboApunte);
            
        }

        private void comboApunte_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int apunte = 0;
            if (comboApunte.SelectedItem != null)
            {
                apunte = int.Parse(comboApunte.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboApunte.SelectedItem, null).ToString());
            }
            var conexion = new Conexion();
            conexion.CargarComboPrecio(apunte, comboPrecio);
        }

        private void comboPrecio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            decimal precio =0;
            if (comboPrecio.SelectedItem != null)
            {
             
                    precio = decimal.Parse(comboPrecio.SelectedItem.GetType()
                  .GetProperty("Value").GetValue(comboPrecio.SelectedItem, null).ToString());
                
                
            }
            var conexion = new Conexion();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            DateTime fecha = DateTime.Now;
            int universidad = int.Parse(cbxUniversidad.SelectedItem.GetType()
               .GetProperty("Value").GetValue(cbxUniversidad.SelectedItem, null).ToString());
            int carrera = int.Parse(comboCarrera.SelectedItem.GetType()
               .GetProperty("Value").GetValue(comboCarrera.SelectedItem, null).ToString());
            int materia = int.Parse(comboMateria.SelectedItem.GetType()
              .GetProperty("Value").GetValue(comboMateria.SelectedItem, null).ToString());
            int cliente = int.Parse(comboCliente.SelectedItem.GetType()
               .GetProperty("Value").GetValue(comboCliente.SelectedItem, null).ToString());
            int apunte = int.Parse(comboApunte.SelectedItem.GetType()
               .GetProperty("Value").GetValue(comboApunte.SelectedItem, null).ToString());
            int anillado = int.Parse(comboAnillado.SelectedItem.GetType()
               .GetProperty("Value").GetValue(comboAnillado.SelectedItem, null).ToString());

            decimal precio = 0m;
            if (comboAnillado.Text == "NO")
            {
                precio = precio + decimal.Parse(comboPrecio.SelectedItem.GetType()
              .GetProperty("Value").GetValue(comboPrecio.SelectedItem, null).ToString());
            }
            else
            {
                precio = 60m;
                precio = precio + decimal.Parse(comboPrecio.SelectedItem.GetType()
              .GetProperty("Value").GetValue(comboPrecio.SelectedItem, null).ToString());
            }



            int estado = int.Parse(comboEstado.SelectedItem.GetType()
               .GetProperty("Value").GetValue(comboEstado.SelectedItem, null).ToString());

            var conexion = new Conexion();
            conexion.AgregarPedido(fecha, universidad, materia, carrera, cliente, apunte, anillado, precio, estado);

        }
    }
}
