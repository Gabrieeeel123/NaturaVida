namespace CapaPresentacion
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.txtContraseñas = new System.Windows.Forms.TextBox();
            this.Prueba = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sistema de informacion\r\nNaturVida\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Usuario :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Contraseña :";
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(347, 296);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnIngreso.TabIndex = 3;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.Location = new System.Drawing.Point(322, 151);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(100, 23);
            this.txtUsuarios.TabIndex = 4;
            // 
            // txtContraseñas
            // 
            this.txtContraseñas.Location = new System.Drawing.Point(322, 201);
            this.txtContraseñas.Name = "txtContraseñas";
            this.txtContraseñas.Size = new System.Drawing.Size(100, 23);
            this.txtContraseñas.TabIndex = 5;
            // 
            // Prueba
            // 
            this.Prueba.Location = new System.Drawing.Point(584, 404);
            this.Prueba.Name = "Prueba";
            this.Prueba.Size = new System.Drawing.Size(75, 23);
            this.Prueba.TabIndex = 6;
            this.Prueba.Text = "Prueba";
            this.Prueba.UseVisualStyleBackColor = true;
            this.Prueba.Click += new System.EventHandler(this.Prueba_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Prueba);
            this.Controls.Add(this.txtContraseñas);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnIngreso;
        private TextBox txtUsuarios;
        private TextBox txtContraseñas;
        private Button Prueba;
    }
}