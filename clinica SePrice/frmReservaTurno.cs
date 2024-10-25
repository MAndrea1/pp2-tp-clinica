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
        Medico medicoSeleccionado;
        DateTime fechaSeleccionada;
        TimeSpan? horarioSeleccionado;

        public frmReservaTurno()
        {
            InitializeComponent();
            Medicos medicos = new Medicos();
            List<Medico> allMedicos = medicos.BuscarTodosLosMedicos();
            comboBox2.DataSource = allMedicos;
            fechaSeleccionada = DateTime.Today;
            comboBoxHorario.Enabled = false;
            dateTimePicker1.Enabled = false;
            comboBox2.Enabled = false;
            btnGenerarTurno.Enabled = false;
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

            // Define available times
            TimeSpan startMorning = new TimeSpan(9, 0, 0);
            TimeSpan endMorning = new TimeSpan(12, 0, 0);
            TimeSpan startAfternoon = new TimeSpan(13, 30, 0);
            TimeSpan endAfternoon = new TimeSpan(17, 0, 0);

            List<TimeSpan> availableAppointments = new List<TimeSpan>();

            // Generate 15-minute intervals for the morning and afternoon sessions
            TimeSpan interval = TimeSpan.FromMinutes(15);
            for (TimeSpan time = startMorning; time < endMorning; time += interval)
            {
                availableAppointments.Add(time);
            }
            for (TimeSpan time = startAfternoon; time < endAfternoon; time += interval)
            {
                availableAppointments.Add(time);
            }

            // Filter out times that already have appointments
            List<TimeSpan> bookedAppointments = turnosPorMedico.Select(t => t.HorarioTurno).ToList();
            List<TimeSpan> freeAppointments = availableAppointments
                .Where(t => !bookedAppointments.Contains(t))
                .ToList();

            // Check if there are no available appointments
            if (freeAppointments.Count == 0)
            {
                // Clear the ComboBox selection if no appointments are available
                comboBoxHorario.SelectedItem = null; // Assuming comboBox is your ComboBox control
            }
            else
            {
                // Optionally select the first available appointment
                comboBoxHorario.SelectedItem = freeAppointments.First(); // Uncomment this line if you want to select the first available appointment
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

                // Enable the button based on your criteria
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
            int dni;
            if (int.TryParse(textBox1.Text, out dni))
            {
                dniSeleccionado = dni;
                comboBoxHorario.Enabled = false;
                comboBox2.Enabled = false;
            }
            else
            {
                dniSeleccionado = 0;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Pacientes pacientes = new Pacientes();
            Paciente paciente = pacientes.BuscarPaciente(dniSeleccionado);

            if (paciente != null) {
                dateTimePicker1.Enabled = true;
                comboBox2.Enabled = true;
                MessageBox.Show("Patient found", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Patient not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
