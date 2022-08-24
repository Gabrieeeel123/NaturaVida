namespace CapaPresentacion
{
    partial class Producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.insertarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProdructoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlConsultar = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtConsultar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlInsertarProducto = new System.Windows.Forms.Panel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtDescipcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlActualizar = new System.Windows.Forms.Panel();
            this.txtValorAc = new System.Windows.Forms.TextBox();
            this.txtDescAct = new System.Windows.Forms.TextBox();
            this.txtCodigoAc = new System.Windows.Forms.TextBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtActualizar = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlEliminar.SuspendLayout();
            this.pnlInsertarProducto.SuspendLayout();
            this.pnlActualizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionar Productos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Controls.Add(this.pnlConsultar);
            this.groupBox1.Controls.Add(this.pnlEliminar);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "--------------------------";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertarProductoToolStripMenuItem,
            this.consultarProductoToolStripMenuItem,
            this.actualizarProdructoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 19);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // insertarProductoToolStripMenuItem
            // 
            this.insertarProductoToolStripMenuItem.Name = "insertarProductoToolStripMenuItem";
            this.insertarProductoToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.insertarProductoToolStripMenuItem.Text = "Insertar Producto";
            this.insertarProductoToolStripMenuItem.Click += new System.EventHandler(this.insertarProductoToolStripMenuItem_Click);
            // 
            // consultarProductoToolStripMenuItem
            // 
            this.consultarProductoToolStripMenuItem.Name = "consultarProductoToolStripMenuItem";
            this.consultarProductoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.consultarProductoToolStripMenuItem.Text = "Consultar Producto";
            this.consultarProductoToolStripMenuItem.Click += new System.EventHandler(this.consultarProductoToolStripMenuItem_Click);
            // 
            // actualizarProdructoToolStripMenuItem
            // 
            this.actualizarProdructoToolStripMenuItem.Name = "actualizarProdructoToolStripMenuItem";
            this.actualizarProdructoToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.actualizarProdructoToolStripMenuItem.Text = "Actualizar prodructo";
            this.actualizarProdructoToolStripMenuItem.Click += new System.EventHandler(this.actualizarProdructoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // pnlConsultar
            // 
            this.pnlConsultar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlConsultar.Controls.Add(this.dataGridView1);
            this.pnlConsultar.Controls.Add(this.btnConsultar);
            this.pnlConsultar.Controls.Add(this.txtConsultar);
            this.pnlConsultar.Controls.Add(this.label6);
            this.pnlConsultar.Location = new System.Drawing.Point(0, 46);
            this.pnlConsultar.Name = "pnlConsultar";
            this.pnlConsultar.Size = new System.Drawing.Size(765, 307);
            this.pnlConsultar.TabIndex = 10;
            this.pnlConsultar.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(714, 185);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(320, 66);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // txtConsultar
            // 
            this.txtConsultar.FormattingEnabled = true;
            this.txtConsultar.Location = new System.Drawing.Point(352, 32);
            this.txtConsultar.Name = "txtConsultar";
            this.txtConsultar.Size = new System.Drawing.Size(121, 23);
            this.txtConsultar.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Producto :";
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.Controls.Add(this.btnEliminar);
            this.pnlEliminar.Controls.Add(this.txtEliminar);
            this.pnlEliminar.Controls.Add(this.label11);
            this.pnlEliminar.Location = new System.Drawing.Point(0, 46);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(765, 307);
            this.pnlEliminar.TabIndex = 10;
            this.pnlEliminar.Visible = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(320, 169);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtEliminar
            // 
            this.txtEliminar.FormattingEnabled = true;
            this.txtEliminar.Location = new System.Drawing.Point(371, 115);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(121, 23);
            this.txtEliminar.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(216, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Producto :";
            // 
            // pnlInsertarProducto
            // 
            this.pnlInsertarProducto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlInsertarProducto.Controls.Add(this.txtCantidad);
            this.pnlInsertarProducto.Controls.Add(this.txtValor);
            this.pnlInsertarProducto.Controls.Add(this.txtDescipcion);
            this.pnlInsertarProducto.Controls.Add(this.txtCodigo);
            this.pnlInsertarProducto.Controls.Add(this.btnLimpiar);
            this.pnlInsertarProducto.Controls.Add(this.btnGuardar);
            this.pnlInsertarProducto.Controls.Add(this.label5);
            this.pnlInsertarProducto.Controls.Add(this.label4);
            this.pnlInsertarProducto.Controls.Add(this.label3);
            this.pnlInsertarProducto.Controls.Add(this.label2);
            this.pnlInsertarProducto.Location = new System.Drawing.Point(12, 115);
            this.pnlInsertarProducto.Name = "pnlInsertarProducto";
            this.pnlInsertarProducto.Size = new System.Drawing.Size(765, 307);
            this.pnlInsertarProducto.TabIndex = 1;
            this.pnlInsertarProducto.Visible = false;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(373, 157);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtCantidad.TabIndex = 9;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(373, 128);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 23);
            this.txtValor.TabIndex = 8;
            // 
            // txtDescipcion
            // 
            this.txtDescipcion.Location = new System.Drawing.Point(373, 95);
            this.txtDescipcion.Name = "txtDescipcion";
            this.txtDescipcion.Size = new System.Drawing.Size(100, 23);
            this.txtDescipcion.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(373, 61);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 23);
            this.txtCodigo.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(389, 227);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(246, 227);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripción :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            // 
            // pnlActualizar
            // 
            this.pnlActualizar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlActualizar.Controls.Add(this.txtValorAc);
            this.pnlActualizar.Controls.Add(this.txtDescAct);
            this.pnlActualizar.Controls.Add(this.txtCodigoAc);
            this.pnlActualizar.Controls.Add(this.btnGuardarCambios);
            this.pnlActualizar.Controls.Add(this.label10);
            this.pnlActualizar.Controls.Add(this.label9);
            this.pnlActualizar.Controls.Add(this.label8);
            this.pnlActualizar.Controls.Add(this.btnBuscar);
            this.pnlActualizar.Controls.Add(this.txtActualizar);
            this.pnlActualizar.Controls.Add(this.label7);
            this.pnlActualizar.Location = new System.Drawing.Point(12, 115);
            this.pnlActualizar.Name = "pnlActualizar";
            this.pnlActualizar.Size = new System.Drawing.Size(765, 307);
            this.pnlActualizar.TabIndex = 4;
            this.pnlActualizar.Visible = false;
            // 
            // txtValorAc
            // 
            this.txtValorAc.Location = new System.Drawing.Point(332, 187);
            this.txtValorAc.Name = "txtValorAc";
            this.txtValorAc.Size = new System.Drawing.Size(100, 23);
            this.txtValorAc.TabIndex = 9;
            // 
            // txtDescAct
            // 
            this.txtDescAct.Location = new System.Drawing.Point(332, 150);
            this.txtDescAct.Name = "txtDescAct";
            this.txtDescAct.Size = new System.Drawing.Size(100, 23);
            this.txtDescAct.TabIndex = 8;
            // 
            // txtCodigoAc
            // 
            this.txtCodigoAc.Location = new System.Drawing.Point(332, 111);
            this.txtCodigoAc.Name = "txtCodigoAc";
            this.txtCodigoAc.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoAc.TabIndex = 7;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(332, 232);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCambios.TabIndex = 6;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Valor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(221, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 3;
            this.label8.Text = "Codigo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(332, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtActualizar
            // 
            this.txtActualizar.FormattingEnabled = true;
            this.txtActualizar.Location = new System.Drawing.Point(383, 32);
            this.txtActualizar.Name = "txtActualizar";
            this.txtActualizar.Size = new System.Drawing.Size(121, 23);
            this.txtActualizar.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Producto :";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlActualizar);
            this.Controls.Add(this.pnlInsertarProducto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Producto";
            this.Text = "Producto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlConsultar.ResumeLayout(false);
            this.pnlConsultar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlEliminar.ResumeLayout(false);
            this.pnlEliminar.PerformLayout();
            this.pnlInsertarProducto.ResumeLayout(false);
            this.pnlInsertarProducto.PerformLayout();
            this.pnlActualizar.ResumeLayout(false);
            this.pnlActualizar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem insertarProductoToolStripMenuItem;
        private ToolStripMenuItem consultarProductoToolStripMenuItem;
        private ToolStripMenuItem actualizarProdructoToolStripMenuItem;
        private ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private Panel pnlConsultar;
        private DataGridView dataGridView1;
        private Button btnConsultar;
        private ComboBox txtConsultar;
        private Label label6;
        private Panel pnlInsertarProducto;
        private Panel pnlActualizar;
        private TextBox txtValorAc;
        private TextBox txtDescAct;
        private TextBox txtCodigoAc;
        private Button btnGuardarCambios;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnBuscar;
        private ComboBox txtActualizar;
        private Label label7;
        private TextBox txtCantidad;
        private TextBox txtValor;
        private TextBox txtDescipcion;
        private TextBox txtCodigo;
        private Button btnLimpiar;
        private Button btnGuardar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel pnlEliminar;
        private Button btnEliminar;
        private ComboBox txtEliminar;
        private Label label11;
    }
}