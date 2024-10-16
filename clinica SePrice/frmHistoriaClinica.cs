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
        private DataTable pacienteData;
        public frmHistoriaClinica(DataTable data)
        {
            InitializeComponent();
            pacienteData = data;


            if (pacienteData.Rows.Count > 0)
            {
                lblNombre.Text = pacienteData.Rows[0]["Nombre"].ToString();
                lblApellido.Text = pacienteData.Rows[0]["Apellido"].ToString();
                lblDNI.Text = pacienteData.Rows[0]["Dni"].ToString();
                lblGenero.Text = pacienteData.Rows[0]["Genero"].ToString();
                lblPrepaga.Text = (bool)pacienteData.Rows[0]["Prepaga"] ? "Sí" : "No";
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
