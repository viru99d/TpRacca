using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace FotocopiadoraFacultad
{
    class Conexion
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            try
            {
                cnn = new SqlConnection("Data Source =.; Initial Catalog = Control de Pedidos Fotocopiadora UTN; Integrated Security = True");
                cnn.Open();

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
                cmd = new SqlCommand("Select Nombre from Universidad", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cb.Items.Add(dr["Nombre"].ToString());
                }
                cb.SelectedIndex = 0;
                dr.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show("No se llenó el casillero: " + error.ToString());
            }
        }

        public void llenar1(ComboBox cc)
        {
            try
            {
                cmd = new SqlCommand("Select Nombre from Materia", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cc.Items.Add(dr["Nombre"].ToString());
                }
                cc.SelectedIndex = 0;
                dr.Close();
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
                cmd = new SqlCommand("Select Nombre from Carrera", cnn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cd.Items.Add(dr["Nombre"].ToString());
                }
                cd.SelectedIndex = 0;
                dr.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("No se llenó el casillero: " + error.ToString());
            }
        }




    }
}
