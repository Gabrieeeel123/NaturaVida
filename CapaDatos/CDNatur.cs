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
        public int Registrar(CENatur cENatur)
        {
            int estado = 0;
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            try
            {
                mySqlConnection.Open();
                string Query = $"INSERT INTO `productos` (`proCodigo`,`proDescripcion`, `proValor`, `proCantidad`, `proNombre`) VALUES ('{cENatur.Codigo}','{cENatur.Descripcion}', '{cENatur.valor}', '{cENatur.cantidad}', '{cENatur.Nombre}');";
                MySqlCommand cmd = new MySqlCommand(Query, mySqlConnection);
                cmd.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Registro exitoso");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error");
                throw;
                estado = 1;
            }

            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
            return estado;
        }

    }
}