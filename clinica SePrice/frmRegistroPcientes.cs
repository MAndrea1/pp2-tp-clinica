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
    public partial class frmRegistroPcientes : Form
    {
        public frmRegistroPcientes()
        {
            InitializeComponent();
        }

        private void btnRegistrarPaciente_Click(object sender, EventArgs e)
        {
            {
 

                // Si todas las validaciones son exitosas, crear el paciente
                var paciente = new Pacientes();
                if (int.TryParse(txtDNIP.Text, out int dni))
                {
                    Paciente resultado = paciente.BuscarPaciente(dni);

                    if (resultado != null)

                        MessageBox.Show("El paciente ya existe con ese DNI");
                }
         
                else
                {
                    MessageBox.Show("Por favor, ingrese un D.N.I. válido.");
                }

                // Validar los campos
                string error = ValidateFields();
                if (error != null)
                {
                    MessageBox.Show(error);
                    return;
                }
                else
                {
                    try
                    {
                        paciente.AgregarPaciente(txtNombreP.Text, txtApellidoP.Text, int.Parse(txtDNIP.Text), cbGeneroP.Text, txtNacionalidadP.Text, rbtnPrepaga.Checked);
                        MessageBox.Show("Paciente registrado con éxito.");
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Hubo un error, vuelva a intentar");
                    }

                }

            }

            string ValidateFields()
            {
                if (string.IsNullOrWhiteSpace(txtNombreP.Text))
                    return "El nombre es obligatorio.";

                if (string.IsNullOrWhiteSpace(txtApellidoP.Text))
                    return "El apellido es obligatorio.";

                if (string.IsNullOrWhiteSpace(txtDNIP.Text))
                    return "El D.N.I. es obligatorio.";

                if (!int.TryParse(txtDNIP.Text, out _))
                    return "Por favor, ingrese un D.N.I. válido.";

                if (string.IsNullOrWhiteSpace(txtNacionalidadP.Text))
                    return "La nacionalidad es obligatoria.";

                if (cbGeneroP.SelectedItem == null)
                    return "El género es obligatorio.";

                if (!rbtnPrepaga.Checked && !rbtnParticular.Checked)
                    return "Debe seleccionar un estado de cobertura";
                else if (rbtnPrepaga.Checked && rbtnParticular.Checked)
                    return "Debe seleccionar un estado de cobertura";

                return null; // Sin errores
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

