﻿using CapaEntidad;
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
        public DataTable Listar()
        {
            return cDNatur.Listar();
        }
        public DataTable ListarProductos()
        {
            return cDNatur.ListarProductos();
        }
        public void Deletear(CENatur cENatur)
        {
            cDNatur.Deletear(cENatur);
        }
        public MySqlDataReader BuscarPorCodigo(int cENatur)
        {
            return cDNatur.BuscarPorCodigo(cENatur);
        }
        public void ActualizarDatos(CENatur cENatur)
        {
            cDNatur.Actualizar(cENatur);
        }
        public DataTable ListarClientes()
        {
            return cDNatur.ListarClientes();
        }
        public void Facturar(CENatur cENatur)
        {
            cDNatur.Facturar(cENatur);
        }
        public void AgregarProducto(CENatur cENatur)
        {
            cDNatur.AgregarProductoFactura(cENatur);
        }
        public MySqlDataReader ListarFactura(int cENatur)
        {
            return cDNatur.ListarFactura(cENatur);
        }
        
    }
}