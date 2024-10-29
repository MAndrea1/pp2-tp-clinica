using clinica_SePrice.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica_SePrice
{
    public partial class frmHistoriaClinica : Form
    {
        private Paciente pacienteData;
        public frmHistoriaClinica(Paciente data)
        {
            InitializeComponent();
            pacienteData = data;


            if (pacienteData != null)
            {
                lblNombre.Text = pacienteData.Nombre;
                lblApellido.Text = pacienteData.Apellido;
                lblDNI.Text = pacienteData.Dni.ToString();
                lblGenero.Text = pacienteData.Genero;
                lblPrepaga.Text = (bool)pacienteData.Prepaga ? "Sí" : "No";
            }
        }
    private void btnVolver_Click(object sender, EventArgs e)
        {
            frmMedicoPaciente frmmedicopaciente = new frmMedicoPaciente();

            frmmedicopaciente.Show();
            this.Hide();
        }

        private void lblDNI_Click(object sender, EventArgs e)
        {

        }
    }
}
