using System;
using System.Data.SqlClient;
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

        public void llenar(ComboBox cb)
        {
            try
            {
                cnn.Open();
                cmd = new SqlCommand("Select Nombre from Universidad", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Nombre"].ToString());
                    //cb.Items.Add(dr["IdUniversidad"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
                cnn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se llenó el casillero: " + error.ToString());
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
                    //cc.Items.Add(dr["IdMateria"].ToString());
                }
                cc.SelectedIndex = 0;
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
                    //cd.Items.Add(dr["IdCarrera"].ToString());
                }
                cd.SelectedIndex = 0;
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
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo agregar el pedido");
                cnn.Close();
            }
        }
    }
}
