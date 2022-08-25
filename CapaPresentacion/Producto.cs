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

namespace CapaPresentacion
{
    public partial class Producto : Form
    {
        CNNatur cnNatur = new CNNatur();
        
        public Producto()
        {
            InitializeComponent();
        }

        private void insertarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlActualizar.Visible=false;
            pnlConsultar.Visible = false;
            pnlEliminar.Visible=false;
            pnlInsertarProducto.Visible = true;
        }

        private void consultarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlActualizar.Visible = false;
            pnlConsultar.Visible = true;
            pnlEliminar.Visible = false;
            pnlInsertarProducto.Visible = false;
        }

        private void actualizarProdructoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlActualizar.Visible = true;
            pnlConsultar.Visible = false;
            pnlEliminar.Visible = false;
            pnlInsertarProducto.Visible = false;
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlActualizar.Visible = false;
            pnlConsultar.Visible = false;
            pnlEliminar.Visible = true;
            pnlInsertarProducto.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool resultado;
            CENatur producto = new CENatur();
            resultado = cnNatur.ValidarDatos(producto);
            producto.Codigo = int.Parse(txtCodigo.Text);
            producto.Descripcion = txtDescipcion.Text;
            producto.valor = double.Parse(txtValor.Text);
            producto.Nombre = txtNombrePro.Text;
            producto.cantidad = int.Parse(txtCantidad.Text);
            if (resultado==false)
            {
                return;
            }
            if (producto.Codigo == 0)
            {
                cnNatur.Insertar(producto);
            }
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
        private void LimpiarForm()
        {
            txtCodigo.Text = string.Empty;
            txtNombrePro.Text = string.Empty;
            txtDescipcion.Text = string.Empty;
            txtValor.Text = string.Empty;
            txtCantidad.Text = string.Empty;            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var Tabla = cnNatur.Listar();
            var NumeroFilas = Tabla.Rows.Count;
            if (NumeroFilas>0)
            {
                for (int i = 0; i < NumeroFilas; i++)
                {
                    String Nombre = Tabla.Rows[i][1].ToString();
                    String Descipcion = Tabla.Rows[i][2].ToString();
                    String Valor = Tabla.Rows[i][2].ToString();
                    String Cantidad = Tabla.Rows[i][3].ToString();            

                    GridConsultar.Rows.Add(Nombre, Descipcion, Valor, Cantidad);
                }

            }
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            var funciones = new CNNatur();
            txtActualizar.DataSource = funciones.ListarProductos();
            txtActualizar.DisplayMember = "proNombre";            
            txtEliminar.DataSource = funciones.ListarProductos();
            txtEliminar.DisplayMember = "proCodigo";            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            /*var EliminarProducto = new CNNatur();
            int Codigo = txtEliminar.Select.ToString();
            EliminarProducto.Deletear(Codigo);*/

            if (txtEliminar.Text == "0") return;
            if (MessageBox.Show("¿Desea eliminar el registro?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CENatur producto = new CENatur();                
                producto.Codigo = int.Parse(txtEliminar.Text);
                cnNatur.Deletear(producto);
                /*CargarDatos();
                LimpiarForm();*/
            }
        }

        
    }
}
