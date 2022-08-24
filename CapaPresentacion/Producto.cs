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
            //bool resultado;
            CENatur producto = new CENatur();
            producto.Codigo = int.Parse(txtCodigo.Text);
            producto.Descripcion = txtDescipcion.Text;
            producto.valor = double.Parse(txtValor.Text);
            producto.Nombre = txtNombrePro.Text;
            producto.cantidad = int.Parse(txtCantidad.Text);
            if (producto.Codigo != 0)
            {
                cnNatur.Insertar(producto);
            }
            
        }
    }
}
