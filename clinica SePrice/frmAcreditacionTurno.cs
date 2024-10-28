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

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmAdministrativoMenu frmAdministrativoMenu = new frmAdministrativoMenu();
            frmAdministrativoMenu.ShowDialog();
           
            this.Close();
                
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int dni))
            {
                var pagos = new Pagos();

                try
                {
                    var (costo, codTurno, fechaTurno, horarioTurno, acreditacion, mensaje) = pagos.ProcesarPago(dni);
                    if (!string.IsNullOrEmpty(mensaje))
                    {
                        MessageBox.Show(mensaje); MessageBox.Show(mensaje);
                    }
                    else
                    {
                        MessageBox.Show($"Pago procesado. Costo: ${costo}\nTurno: {codTurno}\nFecha: {fechaTurno.ToShortDateString()}\nHorario: {horarioTurno}\nAcreditación: {acreditacion}");
                    }
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
    }
}
