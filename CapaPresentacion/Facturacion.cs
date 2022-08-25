using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using MySql.Data.MySqlClient;
using CapaDatos;

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
            var funciones = new CNNatur();
            txtCliente.DataSource = funciones.ListarClientes();
            txtCliente.DisplayMember = "cliDocumento";

            txtProducto.DataSource = funciones.ListarProductos();
            txtProducto.DisplayMember = "proCodigo";
        }

        private void btnTerminarFactura_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            CENatur produto = new CENatur();
            produto.facNumero =int.Parse(txtCodigo.Text);
            produto.Codigo = int.Parse(txtProducto.Text);
            produto.cantidad = int.Parse(txtCantidad.Text);

            MySqlDataReader reader = CNNatur.BuscarPorCodigo(int.Parse(txtCodigo.Text));
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    /*txtCodigoAc.Text = reader.GetString(0);
                    txtNombre.Text = reader.GetString(1);
                    txtDescAct.Text = reader.GetString(2);
                    txtValorAc.Text = reader.GetString(3);
                    txtCanAc.Text = reader.GetString(4);*/
                }
            }
            else
            {
                MessageBox.Show("No se encontro el registro");
            }
        }
    }
}
