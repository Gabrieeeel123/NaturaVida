using MySql.Data.MySqlClient;
using System;
using CapaEntidad;
using System.Windows.Forms;
using System.Data;
namespace CapaDatos
{
    public class CDNatur
    {
        string cadenaConexion = "Server=Localhost;User=root;Password=admin;Port=3306;database=naturvida";
        public void pruebaConexion()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexión" + ex.Message);
                return;
            }
            mySqlConnection.Close();
            MessageBox.Show("Conexión exitosa");
        }

    }
}