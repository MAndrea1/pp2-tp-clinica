using clinica_SePrice.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica_SePrice
{
    public partial class frmMedicoPaciente : Form
    {
        public frmMedicoPaciente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerHistoriaClinica_Click(object sender, EventArgs e)
        {
            var paciente = new Pacientes();
            if (int.TryParse(txtDniPaciente.Text, out int dni))
            {
                DataTable resultado = paciente.BuscarPaciente(dni);

                if (resultado.Rows.Count > 0)
                {
                    frmHistoriaClinica frmHistoriaClinica = new frmHistoriaClinica( resultado);
                    frmHistoriaClinica.ShowDialog();
                    this.Hide();
                }
            }

            else
            {
                MessageBox.Show("El paciente no se encuentra registrado");
            }
        }
    }
}
