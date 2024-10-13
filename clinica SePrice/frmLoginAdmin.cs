using System;
using System.Data;
using System.Windows.Forms;
using clinica_SePrice.Datos;


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
            DataTable dataTable = new DataTable();
            Usuario usuario = new Usuario();

                // Llamar al método Log_Usu que ejecuta el procedure de la DB
                dataTable = usuario.Log_Usu(txtUsuarioAdmin.Text, txtPasswordAdmin.Text, 120);

            // Validar que devuelva algo
            if (dataTable.Rows.Count > 0)
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
    }
}
