using System;
using System.Windows.Forms;
using clinica_SePrice.Datos;
using clinica_SePrice.Entidades;


namespace clinica_SePrice
{
    public partial class frmLoginAdmin : Form
    {
        public frmLoginAdmin()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();

                // Llamar al método Log_Usu que ejecuta el procedure de la DB
                Usuario usuario = usuarios.Log_Usu(txtUsuarioAdmin.Text, txtPasswordAdmin.Text, 120);

            // Validar que devuelva algo
            if (usuario != null)
            {
                // Crear y empezar un nuevo subproceso para abrir del admin
                frmAdministrativoMenu frmAdministrativoMenu = new frmAdministrativoMenu();
                frmAdministrativoMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBienvenida frmBienvenida = new frmBienvenida();
            frmBienvenida.ShowDialog();
        }
    }
}
