using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clinica_SePrice.Datos;
using clinica_SePrice.Entidades;
using MySql.Data.MySqlClient;

namespace clinica_SePrice
{
    public partial class frmAcreditacionTurno : Form
    {
        public frmAcreditacionTurno()
        {
            InitializeComponent();
            btnConfirmarTurno.Enabled = false;
        }

        private void btnConfirmarTurno_Click(object sender, EventArgs e)
        {
            if (cbxTurnos.SelectedValue != null)
            {
                int codCita = (int)cbxTurnos.SelectedValue;
                var pagos = new Pagos();

                try
                {
                    
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

        private void btnPagarBono_Click(object sender, EventArgs e)
        {
            try
            {
              
                int dni = int.Parse(textBox1.Text);  
                if (cbxTurnos.SelectedValue != null)
                {
                   
                    int codTurno = (int)cbxTurnos.SelectedValue;

                    var pagos = new Pagos();

                    var turnoSeleccionado = pagos.ObtenerTurnosPorPaciente(dni).FirstOrDefault(t => t.CodTurno == codTurno);

                    if (turnoSeleccionado != null)
                    {
                        string nombrePaciente = string.Empty;
                        string apellidoPaciente = string.Empty;

                        using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
                        {
                            using (MySqlCommand comando = new MySqlCommand("SELECT Nombre, Apellido FROM pacientes WHERE Dni = @dni", conexion))
                            {
                                comando.Parameters.AddWithValue("@dni", dni);
                                if (conexion.State == ConnectionState.Open)
                                {
                                    conexion.Close();
                                }
                                conexion.Open();
                                using (MySqlDataReader reader = comando.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        
                                        nombrePaciente = reader.GetString("Nombre");
                                        apellidoPaciente = reader.GetString("Apellido");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Paciente no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                        }

                        
                        var resultado = pagos.ObtenerCostoTurno(dni);
                        int costo = resultado.costo;
                        string mensaje = resultado.mensaje;

                        
                        if (mensaje == "Pago procesado correctamente.")
                        {
                           pagos.GenerarPdfPago(dni, costo, turnoSeleccionado.FechaTurno, turnoSeleccionado.HorarioTurno, nombrePaciente, apellidoPaciente);
                           btnConfirmarTurno.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el turno seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un turno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
