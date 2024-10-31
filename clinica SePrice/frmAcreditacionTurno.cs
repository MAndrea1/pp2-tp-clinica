using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clinica_SePrice.Datos;
using clinica_SePrice.Entidades;

namespace clinica_SePrice
{
    public partial class frmAcreditacionTurno : Form
    {
        public frmAcreditacionTurno()
        {
            InitializeComponent();
        }

        private void btnConfirmarTurno_Click(object sender, EventArgs e)
        {
            if (cbxTurnos.SelectedValue != null)
            {
                int codCita = (int)cbxTurnos.SelectedValue;
                var pagos = new Pagos();

                try
                {
                    // Actualizar la acreditación del turno
                    pagos.AcreditarTurno(codCita);
                    MessageBox.Show("Acreditación realizada con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al acreditar el turno: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un turno.");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int dni))
            {
                var pagos = new Pagos();

                try
                {
                    var listaCitas = pagos.ObtenerTurnosPorPaciente(dni);
                    cbxTurnos.DataSource = listaCitas;
                    cbxTurnos.DisplayMember = "Display";
                    cbxTurnos.ValueMember = "CodTurno"; 
                    if (listaCitas.Count == 0)
                    {
                        MessageBox.Show("No hay turnos para el paciente.");
                    }
                    ActualizarListaDeTurnos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al procesar el pago: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un D.N.I. válido.");
            }
        }

        private void btnCancelarTuno_Click(object sender, EventArgs e)
        {
            if (cbxTurnos.SelectedValue != null)
            {
                int codTurno = (int)cbxTurnos.SelectedValue;
                var pagos = new Pagos();
                Turnos turnos = new Turnos();
                try
                {
                    turnos.EliminarTurno(codTurno);
                    MessageBox.Show("Turno cancelado con éxito.");

                    ActualizarListaDeTurnos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cancelar el turno: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un turno.");
            }
        }
        private void ActualizarListaDeTurnos()
        {
            if (int.TryParse(textBox1.Text, out int dni))
            {
                var pagos = new Pagos();
                try
                {
                    var listaCitas = pagos.ObtenerTurnosPorPaciente(dni);
                    cbxTurnos.DataSource = listaCitas;
                    cbxTurnos.DisplayMember = "Display";
                    cbxTurnos.ValueMember = "CodTurno";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar la lista de turnos: {ex.Message}");
                }
            }
        }


    }
}
