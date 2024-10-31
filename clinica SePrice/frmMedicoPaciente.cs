using clinica_SePrice.Datos;
using clinica_SePrice.Entidades;
using System;
using System.Windows.Forms;

namespace clinica_SePrice
{
    public partial class frmMedicoPaciente : Form
    {
        private Medico medico;
        public frmMedicoPaciente(Medico medico)
        {
            InitializeComponent();
            this.medico = medico;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerHistoriaClinica_Click(object sender, EventArgs e)
        {
            var paciente = new Pacientes();
            if (int.TryParse(txtDniPaciente.Text, out int dni))
            {
                Paciente resultado = paciente.BuscarPaciente(dni);

                if (resultado != null)
                {
                    frmHistoriaClinica frmHistoriaClinica = new frmHistoriaClinica(resultado, medico);
                    frmHistoriaClinica.ShowDialog();
                }
            }

            else
            {
                MessageBox.Show("El paciente no se encuentra registrado");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDniPaciente.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frmBienvenida frmBienvenida = new frmBienvenida();
            frmBienvenida.Show();


        }
    }
}
