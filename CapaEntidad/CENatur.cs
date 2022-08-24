
namespace CapaEntidad
{
    public class CENatur
    {       
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public double valor { get; set; }
        public double cantidad { get; set; }

        public CENatur(int _codigo, string _descripcion, string _nombre, double _valor, double _cantidad)
        {
            this.Codigo = _codigo;
            this.Descripcion = _descripcion;
            this.Nombre = _nombre;
            this.valor = _valor;
            this.cantidad = _cantidad;
        }
        public CENatur()
        {

        }
    }
}