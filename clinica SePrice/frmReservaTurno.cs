using clinica_SePrice.Datos;
using clinica_SePrice.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace clinica_SePrice
{
    public partial class frmReservaTurno : Form
    {
        int dniSeleccionado;
        Especialidad especialidadSeleccionada;
        Medico medicoSeleccionado;
        Paciente pacienteSeleccionado;
        DateTime fechaSeleccionada;
        TimeSpan? horarioSeleccionado;

        public frmReservaTurno()
        {
            InitializeComponent();
            Especialidades especialidades = new Especialidades();
            List<Especialidad> allEspecialidades = especialidades.BuscarTodasLasEspecialidades();
            comboBoxEspecialidad.DataSource = allEspecialidades;
            fechaSeleccionada = DateTime.Today;
            comboBoxHorario.Enabled = false;
            dateTimePicker1.Enabled = false;
            comboBoxMedico.Enabled = false;
            btnGenerarTurno.Enabled = false;
            comboBoxEspecialidad.Enabled = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            medicoSeleccionado = (Medico)((ComboBox)sender).SelectedValue;

            comboBoxHorario.Enabled = medicoSeleccionado != null;

            comboBoxHorario.DataSource = ObtenerTrunosDispoinibles();

        }
        private List<TimeSpan> ObtenerTrunosDispoinibles()
        {
            Turnos turnos = new Turnos();
            List<Turno> turnosPorMedico = turnos.BuscarTurnosPorMedicoYFecha(medicoSeleccionado.CodUsu, fechaSeleccionada);

            // Horarios disponibles
            TimeSpan startMorning = new TimeSpan(9, 0, 0);
            TimeSpan endMorning = new TimeSpan(12, 0, 0);
            TimeSpan startAfternoon = new TimeSpan(13, 30, 0);
            TimeSpan endAfternoon = new TimeSpan(17, 0, 0);

            List<TimeSpan> availableAppointments = new List<TimeSpan>();

            // Generar intervalos según especialidad
            TimeSpan interval = TimeSpan.FromMinutes(especialidadSeleccionada.Intervalo);
            for (TimeSpan time = startMorning; time < endMorning; time += interval)
            {
                availableAppointments.Add(time);
            }
            for (TimeSpan time = startAfternoon; time < endAfternoon; time += interval)
            {
                availableAppointments.Add(time);
            }

            // Filtrar intervalos con turnos registrados
            List<TimeSpan> bookedAppointments = turnosPorMedico.Select(t => t.HorarioTurno).ToList();
            List<TimeSpan> freeAppointments = availableAppointments
                .Where(t => !bookedAppointments.Contains(t))
                .ToList();

            // Limpiar los horarios si no hay turnos disponibles
            if (freeAppointments.Count == 0)
            {
                comboBoxHorario.SelectedItem = null;
            }
            else
            {
                comboBoxHorario.SelectedItem = freeAppointments.First();
            }

            return freeAppointments;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fechaSeleccionada = dateTimePicker1.Value.Date;

            comboBoxHorario.DataSource = ObtenerTrunosDispoinibles();
        }

        private void comboBoxHorario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedItem != null)
            {
                horarioSeleccionado = (TimeSpan)((ComboBox)sender).SelectedItem;
                btnGenerarTurno.Enabled = dniSeleccionado > 0 && medicoSeleccionado != null && horarioSeleccionado != default(TimeSpan);
            }
            else
            {
                horarioSeleccionado = null;
                btnGenerarTurno.Enabled = false;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LabelPacienteEncontrado.Text = "";
            int dni;
            if (int.TryParse(textBox1.Text, out dni))
            {
                dniSeleccionado = dni;
                comboBoxHorario.Enabled = false;
                comboBoxMedico.Enabled = false;
            }
            else
            {
                dniSeleccionado = 0;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Pacientes pacientes = new Pacientes();
            pacienteSeleccionado = pacientes.BuscarPaciente(dniSeleccionado);

            if (pacienteSeleccionado != null) {
                dateTimePicker1.Enabled = true;
                comboBoxEspecialidad.Enabled = true;
                LabelPacienteEncontrado.Text = pacienteSeleccionado.Nombre + " " + pacienteSeleccionado.Apellido;
                MessageBox.Show("Paciente encontrado", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Paciente no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGenerarTurno_Click(object sender, EventArgs e)
        {
            Turnos turnos = new Turnos();
            bool success = turnos.AgregarTurno(dniSeleccionado, medicoSeleccionado.CodUsu, fechaSeleccionada, false, horarioSeleccionado.Value);
            if (success)
            {
                comboBoxHorario.DataSource = ObtenerTrunosDispoinibles();
                horarioSeleccionado = null;
                comboBoxHorario.ResetText();
                MessageBox.Show("Turno agregado exitosamente!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnGenerarTurno.Enabled = false;
            }
            else
            {
                MessageBox.Show("Ocurrió un error al agregar el turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            especialidadSeleccionada = (Especialidad)((ComboBox)sender).SelectedValue;

            comboBoxMedico.Enabled = especialidadSeleccionada != null;

            Medicos medicos = new Medicos();
            List<Medico> allMedicos = medicos.BuscarMedicosPorEspecialidad(especialidadSeleccionada.CodEsp);
            comboBoxMedico.DataSource = allMedicos;

        }
    }
}
