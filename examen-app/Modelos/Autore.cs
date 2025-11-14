using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_app.Modelos
{
    internal class Autore
    {
        public static DataTable Obtener()
        {
            conexion cnn = new conexion();
            try
            {
                cnn.Conectar();
                String consulta = "SELECT * FROM autores";
                SqlCommand comando = new SqlCommand(consulta, cnn.ObtenerConexion());
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString());
                return null;
            }
            finally
            {
                cnn.Desconectar();
            }
        }
    }
}
