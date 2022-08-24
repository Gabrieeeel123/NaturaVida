using CapaEntidad;
using CapaNegocio;
using System.Windows.Forms;
namespace CapaPresentacion
{
    public partial class login : Form
    {
        CNNatur nNatur = new CNNatur();
        string user = "";
        string pass = "";
        public login()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (txtUsuarios.Text == user && txtContraseñas.Text == pass)
            {
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                this.Hide();
                frmMenuPrincipal.ShowDialog(this);
            }
            else 
            {
                MessageBox.Show("Usuario o contraseña incorrecta");
            }
        }

        private void Prueba_Click(object sender, EventArgs e)
        {
            nNatur.PruebaMySQL();
        }
    }
}