using CapaEntidad;
using CapaDatos;
using System.Windows.Forms;
using System.Data;
namespace CapaNegocio
{
    public class CNNatur
    {
        CDNatur cDNatur = new CDNatur();
        public void PruebaMySQL()
        {
            cDNatur.pruebaConexion();
        }
    }
}