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

namespace clinica_SePrice
{
    public partial class frmReservaTurno : Form
    {
        Medico medicoSeleccionado;
        public frmReservaTurno()
        {
            InitializeComponent();
            Medicos medicos = new Medicos();
            List<Medico> allMedicos = medicos.BuscarTodosLosMedicos();
            comboBox2.DataSource = allMedicos;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            medicoSeleccionado = (Medico)((ComboBox)sender).SelectedValue;

            Turnos turnos = new Turnos();
            List<Turno> turnosPorMedico = turnos.BuscarTurnosPorMedico(medicoSeleccionado.CodUsu);

            foreach (Turno turno in turnosPorMedico)
            {
                Console.WriteLine($"{turno.CodTurno}, {turno.Dni}, {turno.FechaTurno}, {turno.HorarioTurno}");
            }

        }
    }
}
