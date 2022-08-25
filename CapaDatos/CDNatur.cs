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
        public void Registrar(CENatur cENatur)
        {            
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
            }

            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }            
        }    
        public DataTable Listar()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            DataTable ds = new DataTable();
            mySqlConnection.Open();
            string query = "SELECT * FROM `productos` limit 1000;";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, mySqlConnection);
            adaptador.Fill(ds);
            return ds;
        }
        public DataTable ListarProductos()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            DataTable ds = new DataTable();
            mySqlConnection.Open();
            string query = "SELECT `proCodigo`, `proNombre` FROM `productos` limit 1000;";
            MySqlDataAdapter adaptador = new MySqlDataAdapter(query, mySqlConnection);
            adaptador.Fill(ds);
            return ds;
        }


        public void Deletear(CENatur cENatur)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            mySqlConnection.Open();
            string query = $"DELETE FROM `productos` WHERE (`proCodigo` = '{cENatur.Codigo}'); ";
            MySqlCommand cmd = new MySqlCommand(query,mySqlConnection);
            cmd.ExecuteNonQuery();
            mySqlConnection.Close();
            MessageBox.Show("Registro Eliminado");
        }
        public MySqlDataReader BuscarPorCodigo(int cENatur)
        {           
            string cadenaConexion = "Server=Localhost;User=root;Password=admin;Port=3306;database=naturvida";
            MySqlDataReader reader = null;
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            mySqlConnection.Open();
            string query = $"Select * from productos where (proCodigo = {cENatur});";
            MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
            reader = cmd.ExecuteReader();
            return reader;
            mySqlConnection.Close();
            MessageBox.Show("Registro Encontrado");
            
        }
        public void Actualizar(CENatur cENatur)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            try
            {
                mySqlConnection.Open();
                string Query = $"UPDATE `productos` SET `proNombre` = '{cENatur.Nombre}', `proDescripcion` = '{cENatur.Descripcion}', `proValor` = '{cENatur.valor}', `proCantidad` = '{cENatur.cantidad}' " +
                    $"WHERE (`proCodigo` = '{cENatur.Codigo}');";
                MySqlCommand cmd = new MySqlCommand(Query, mySqlConnection);
                cmd.ExecuteNonQuery();
                mySqlConnection.Close();
                MessageBox.Show("Actualizacion exitosa");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error");
                throw;
            }

            finally
            {
                if (mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }
    }
}