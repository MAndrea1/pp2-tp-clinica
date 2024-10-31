using clinica_SePrice.Datos;
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
        private Medico medico;
        private Historia historiaSeleccionada;
        private Turno turnoSeleccionado;
        private Medico turnoMedico;
        public frmHistoriaClinica(Paciente data, Medico medico)
        {
            InitializeComponent();
            pacienteData = data;
            this.medico = medico;

            if (pacienteData != null)
            {
                lblNombre.Text = pacienteData.Nombre;
                lblApellido.Text = pacienteData.Apellido;
                lblDNI.Text = pacienteData.Dni.ToString();
                lblGenero.Text = pacienteData.Genero;
                lblPrepaga.Text = (bool)pacienteData.Prepaga ? "Sí" : "No";
            }

            Historias historias = new Historias();

            grpTurnoData.Visible = false;

            dataGridViewHistoriaClinica.DataSource = historias.BuscarHistoriasPorDniYMedico(pacienteData.Dni, medico.CodUsu);
            dataGridViewHistoriaClinica.ReadOnly = true;
            btnActualizar.Enabled = false;
            txtActualizarDiagnostico.Visible = false;
        }
    private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblDNI_Click(object sender, EventArgs e)
        {


        }

        private void dataGridViewHistoriaClinica_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                var selectedRow = dataGridViewHistoriaClinica.Rows[e.RowIndex];

                var selectedHistoria = selectedRow.DataBoundItem as Historia;

                if (selectedHistoria != null)
                {
                    historiaSeleccionada = selectedHistoria;
                    turnoSeleccionado = selectedHistoria.Turno;

                    Medicos medicos = new Medicos();
                    turnoMedico = medicos.BuscarMedicoPorId(turnoSeleccionado.CodUsu);

                    grpTurnoData.Visible = true;
                    labelTurnoFechaValor.Text = turnoSeleccionado.FechaTurno.ToString("dd/MM/yyyy");
                    labelProfesionalValor.Text = turnoMedico.Nombre + " " + turnoMedico.Apellido;
                    labelEspecialidadValor.Text = turnoMedico.Especialidad.NomEsp;
                    labelDiagnosticoValor.Text = historiaSeleccionada.Detalles;
                    btnActualizar.Enabled = true;
                    txtActualizarDiagnostico.Visible = true;
                    txtActualizarDiagnostico.Text = historiaSeleccionada.Detalles;
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Historias historias = new Historias();
            historias.ActualizarDetallesHistoria(historiaSeleccionada.CodTurno, txtActualizarDiagnostico.Text);
            dataGridViewHistoriaClinica.DataSource = historias.BuscarHistoriasPorDniYMedico(pacienteData.Dni, medico.CodUsu);
            labelDiagnosticoValor.Text = txtActualizarDiagnostico.Text;
            historiaSeleccionada =  null;
            turnoSeleccionado = null;
            turnoMedico = null;
            btnActualizar.Enabled = false;
            txtActualizarDiagnostico.Visible = false;
            grpTurnoData.Visible = false;
        }
    }

}
