﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace FotocopiadoraFacultad
{
    class Conexion
    {
        public SqlConnection cnn { get; set; }
        public SqlCommand cmd { get; set; }
        public SqlDataReader dr { get; set; }

        public Conexion()
        {
            try
            {
                cnn = new SqlConnection("Data Source =.; Initial Catalog = Control de Pedidos Fotocopiadora UTN; Integrated Security = True");
            }
            catch (Exception error)
            {
                MessageBox.Show("No se puedo conectar a la base de datos: " + error.ToString());
            }
        }

        public void CargarComboUniversidad(ComboBox cb)
        {
            try
            {
                string query = $"Select Nombre, IdUniversidad from Universidad";
                cnn.Open();
                cmd = new SqlCommand(query, cnn);
                dr = cmd.ExecuteReader();
                cb.DisplayMember = "Text";
                cb.ValueMember = "Value";
                var listaUniversidad = new List<dynamic>();                
                while (dr.Read())
                {
                    listaUniversidad.Add(new { Text = dr["Nombre"].ToString(), Value = dr["IdUniversidad"].ToString() });
                }                
                cb.DataSource = listaUniversidad;
                cb.SelectedIndex = -1;
                dr.Close();
                cnn.Close();                
            }
            catch (Exception error)
            {
                MessageBox.Show("No se llenó el casillero: " + error.ToString());
                cnn.Close();
            }
        }


        public void AgregarCliente(int dni, string nombre, string telefono, int SocioCoop)
        {
            try
            {
                string Cadena = $"Insert into Cliente(IdCliente, Nombre, Telefono, SocioDeCoop) values({dni}, '{nombre}','{telefono}',{SocioCoop});";
                cnn.Open();
                cmd = new SqlCommand(Cadena, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("El cliente se agregó correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar al cliente");
                cnn.Close();
            }
        }

        public void AgregarPedido(int pedido, DateTime fecha, int universidad,int materia, int carrera, int cliente, int apunte, int anillado, int precio, int estado)
        {
            try
            {
                string Cadena = $"Insert into Pedido(IdPedido, Fecha, CodigoUniversidad, CodigoMateria, CodigoCarrera, CodigoCliente, CodigoApunte, Encuadernillado, PrecioTotal, Estado) values('{pedido}','{fecha}', '{universidad}','{materia}','{carrera}','{cliente}', '{apunte}', '{anillado}', '{precio}', '{estado}');";
                cnn.Open();
                cmd = new SqlCommand(Cadena, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El Pedido se cargó correctamente a la base de datos");
                cnn.Close();
                MessageBox.Show("El Pedido se agrego correctamente a la lista");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar el pedido");
                cnn.Close();
            }
        }

        public void CargarComboCarrera(int idUniversidad, ComboBox combo)
        {
            try
            {
                string query = $"Select Nombre, IdCarrera from Carrera where CodigoUniversidad = {idUniversidad}";
                cnn.Open();
                cmd = new SqlCommand(query, cnn);
                dr = cmd.ExecuteReader();
                combo.DisplayMember = "Text";
                combo.ValueMember = "Value";
                var listaCarrera = new List<dynamic>();
                while (dr.Read())
                {
                    listaCarrera.Add(new { Text = dr["Nombre"].ToString(), Value = dr["IdCarrera"].ToString() });
                }
                if(listaCarrera.Count > 0)
                {
                    combo.DataSource = listaCarrera;
                }
                else
                {
                    combo.DataSource = null;
                }              
                combo.SelectedIndex = -1;
                dr.Close();
                cnn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se llenó el casillero: " + error.ToString());
            }
        }

        public void CargarComboMateria(int idCarrera, ComboBox combo)
        {
            try
            {
                string query = $"Select Nombre, IdMateria From Asignacion join Materia on Asignacion.CodigoMateria = Materia.IdMateria where CodigoCarrera ={idCarrera }";
                cnn.Open();
                cmd = new SqlCommand(query, cnn);
                dr = cmd.ExecuteReader();
                combo.DisplayMember = "Text";
                combo.ValueMember = "Value";
                var listaMateria = new List<dynamic>();
                while (dr.Read())
                {
                    listaMateria.Add(new { Text = dr["Nombre"].ToString(), Value = dr["IdMateria"].ToString() });
                }
                if (listaMateria.Count > 0)
                {
                    combo.DataSource = listaMateria;
                }
                else
                {
                    combo.DataSource = null;
                }
                combo.SelectedIndex = -1;
                dr.Close();
                cnn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se llenó el casillero: " + error.ToString());
            }
        }

        public void CargarComboApunte(int idMateria, ComboBox combo)
        {
            try
            {
                string query = $"Select IdApunte, Precio From Apunte where CodigoMateria ={idMateria }";
                cnn.Open();
                cmd = new SqlCommand(query, cnn);
                dr = cmd.ExecuteReader();
                combo.DisplayMember = "Text";
                combo.ValueMember = "Value";
                var listaApunte = new List<dynamic>();
                while (dr.Read())
                {
                    listaApunte.Add(new { Text = dr["IdApunte"].ToString(), Value = dr["IdApunte"].ToString() });
                }
                if (listaApunte.Count > 0)
                {
                    combo.DataSource = listaApunte;
                }
                else
                {
                    combo.DataSource = null;
                }
                combo.SelectedIndex = -1;
                dr.Close();
                cnn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se llenó el casillero: " + error.ToString());
            }
        }

        public void CargarComboCliente(ComboBox ca)
        {
            try
            {
                string query = $"Select IdCliente from Cliente";
                cnn.Open();
                cmd = new SqlCommand(query, cnn);
                dr = cmd.ExecuteReader();
                ca.DisplayMember = "Text";
                ca.ValueMember = "Value";
                var listaCliente = new List<dynamic>();
                while (dr.Read())
                {
                    listaCliente.Add(new { Text = dr["IdCliente"].ToString(), Value = dr["IdCliente"].ToString() });
                }
                ca.DataSource = listaCliente;
                ca.SelectedIndex = -1;
                dr.Close();
                cnn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se llenó el casillero: " + error.ToString());
                cnn.Close();
            }
        }

        public void CargarComboPrecio(int idMateria, ComboBox combo)
        {
            try
            {
                string query = $"Select IdApunte, Precio From Apunte where CodigoMateria ={idMateria}";
                cnn.Open();
                cmd = new SqlCommand(query, cnn);
                dr = cmd.ExecuteReader();
                combo.DisplayMember = "Text";
                combo.ValueMember = "Value";

                var listaPrecio = new List<dynamic>();
                while (dr.Read())
                {
                    listaPrecio.Add(new { Text = dr["Precio"].ToString(), Value = dr["Precio"].ToString() });
                }
                if (listaPrecio.Count > 0)
                {
                    combo.DataSource = listaPrecio;
                }
                else
                {
                    combo.DataSource = null;
                }
               
                dr.Close();
                cnn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se llenó el casillero: " + error.ToString());
            }
        }
    }
}
