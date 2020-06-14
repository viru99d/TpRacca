using System;
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

        public void llenar1(ComboBox cc)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("Select Nombre from Materia", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cc.Items.Add(dr["Nombre"].ToString());
                }
                cc.SelectedIndex = -1;
                dr.Close();
                cnn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se llenó el casillero: " + error.ToString());
            }
        }

        public void llenar2(ComboBox cd)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("Select Nombre from Carrera", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr["Nombre"].ToString());
                }
                cd.SelectedIndex = -1;
                dr.Close();
                cnn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se llenó el casillero: " + error.ToString());
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
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar al cliente");
                cnn.Close();
            }
        }

        public void AgregarPedido(int pedido, DateTime fecha, int universidad, int carrera, int cliente, int apunte, int anillado, int precio, int estado)
        {
            try
            {
                string Cadena = $"Insert into Cliente(IdPedido, Fecha, codigoUniversdad, codigoCarrera, codigoCliente, codigoApunte, Encuadernillado, PrecioTotal, Estado) values('{pedido}','{fecha}', '{universidad}','{carrera}','{cliente}', '{apunte}', '{anillado}', '{precio}', '{estado}');";
                cnn.Open();
                cmd = new SqlCommand(Cadena, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("El Cliente se agrego correctamente a la lista");
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
    }
}
