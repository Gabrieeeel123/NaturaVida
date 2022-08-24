using CapaEntidad;
using CapaDatos;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace CapaNegocio
{
    public class CNNatur
    {
        CDNatur cDNatur = new CDNatur();
        
        //string cadenaConexion = "Server=Localhost;User=root;Password=admin;Port=3306;database=naturvida";
        CENatur cENatur = new CENatur();

        public void PruebaMySQL()
        {
            cDNatur.pruebaConexion();
        }
        public void Insertar(CENatur cENatur)
        {
            cDNatur.Registrar(cENatur);
        }
    }
}