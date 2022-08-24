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
        CENatur cENatur = new CENatur();
        public bool ValidarDatos(CENatur producto)
        {
            bool resultado = true;
            if (producto.Nombre == string.Empty)
            {
                MessageBox.Show("Campo nombre esta vacio");
            }
            if (producto.Descripcion == string.Empty)
            {
                MessageBox.Show("Campo descripcion esta vacio");
            }
            if (producto.valor < 0 )
            {
                MessageBox.Show("Campo valor es invalido");
            }
            if (producto.cantidad < 0)
            {
                MessageBox.Show("Campo cantidad es invalido");
            }
            if (producto.Codigo < 0)
            {
                MessageBox.Show("Campo Codigo es invalido");
            }
            return resultado;
        }

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