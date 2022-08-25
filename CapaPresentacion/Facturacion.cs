using CapaEntidad;
using CapaNegocio;
using MySql.Data.MySqlClient;

namespace CapaPresentacion
{
    public partial class Facturacion : Form
    {
        CNNatur CNNatur = new CNNatur();
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            CNNatur funciones = new CNNatur();
            txtCliente.DataSource = funciones.ListarClientes();
            txtCliente.DisplayMember = "cliDocumento";

            txtProducto.DataSource = funciones.ListarProductos();
            txtProducto.DisplayMember = "proCodigo";
            MySqlDataReader reader = null;
            txtCodigo.Text = "1";
            var Tabla = CNNatur.ListarFactura(int.Parse(txtCodigo.Text));
            var numeroFilas = Tabla.Rows.Count;
            if (numeroFilas > 0)
            {
                for (int i = 0; i < numeroFilas; i++)
                {
                    string iD = Tabla.Rows[i][0].ToString();
                    string facNumero = Tabla.Rows[i][1].ToString();
                    string facProducto = Tabla.Rows[i][2].ToString();
                    string cantidaPro = Tabla.Rows[i][3].ToString();
                    GridFactura.Rows.Add(iD, facNumero, facProducto, cantidaPro);
                }
            }
        }

        private void btnTerminarFactura_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            CENatur produto = new CENatur();
            produto.facNumero = int.Parse(txtCodigo.Text);
            produto.Codigo = int.Parse(txtProducto.Text);
            produto.cantidad = int.Parse(txtCantidad.Text);
            CNNatur.AgregarProducto(produto);
            GridFactura.Rows.Clear();
            ListarProductos();          
            
        }
        private void ListarProductos()
        {
            var Tabla = CNNatur.ListarFactura(int.Parse(txtCodigo.Text));
            var numeroFilas = Tabla.Rows.Count;
            if (numeroFilas > 0)
            {

                for (int i = 0; i < numeroFilas; i++)
                {
                    string iD = Tabla.Rows[i][0].ToString();
                    string facNumero = Tabla.Rows[i][1].ToString();
                    string facProducto = Tabla.Rows[i][2].ToString();
                    string cantidaPro = Tabla.Rows[i][3].ToString();
                    GridFactura.Rows.Add(iD, facNumero, facProducto, cantidaPro);
                }
            }

            else
            {
                MessageBox.Show("No se encontro el registro");
            }
        }
    }
}
