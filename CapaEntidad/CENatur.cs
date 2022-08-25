
namespace CapaEntidad
{
    public class CENatur
    {       
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public double valor { get; set; }
        public double cantidad { get; set; }


        public int facNumero { get; set; }
        public DateTime facFecha { get; set; }
        public int facCliente {get; set; }
        public double facValorTotal { get; set; }
        public int facVen {get; set; }
        public int Facturadetalle { get; set; }
        
        public CENatur()
        {

        }
    }
}