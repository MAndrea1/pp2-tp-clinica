using System;
using System.Data;
using System.Windows.Forms;
using clinica_SePrice.Datos;


namespace clinica_SePrice
{
    public partial class FrmLoginMedico : Form
    {
        public FrmLoginMedico()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            Usuario usuario = new Usuario();

            // Llamar al método Log_Usu que ejecuta el procedure de la DB
            dataTable = usuario.Log_Usu(txtUsuarioMedico.Text, txtPasswordMedico.Text, 121);

            // Validar que devuelva algo
            if (dataTable.Rows.Count > 0)
            {
                // Crear y empezar un nuevo subproceso para abrir el menú del médico
                frmMedicoPaciente frmMedicoPaciente = new frmMedicoPaciente();
                frmMedicoPaciente.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecto");
            }
        }
    }
}
