using clinica_SePrice.Datos;
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
                // Validar los campos
                string error = ValidateFields();
                if (error != null)
                {
                    MessageBox.Show(error);
                    return;
                }

                // Si todas las validaciones son exitosas, crear el paciente
                var paciente = new Pacientes();
                paciente.AgregarPaciente(txtNombreP.Text, txtApellidoP.Text, int.Parse(txtDNIP.Text), cbGeneroP.Text, txtNacionalidadP.Text, true);

                MessageBox.Show("Paciente registrado con éxito.");
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
    }
}

