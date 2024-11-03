using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace clinica_SePrice
{
    public partial class frmListadoPacientesAtendidos : Form
    {
        public frmListadoPacientesAtendidos()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListarPacientes_Click(object sender, EventArgs e)
        {
            // Obtener el ID del médico y la especialidad seleccionados
            int medicoId = Convert.ToInt32(cmbMedicos.SelectedValue);
            int especialidadId = Convert.ToInt32(cmbEspecialidades.SelectedValue);

            // Llamar a un método para obtener la lista de pacientes
            ListarPacientes(medicoId, especialidadId);
        }

        private void ListarPacientes(int medicoId, int especialidadId)
        {
            // Conexión a la base de datos
            using (SqlConnection conn = new SqlConnection("tu_cadena_de_conexion"))
            {
                conn.Open();
                string query = @"
                    SELECT p.Nombre, p.Apellido, t.FechaTurno 
                    FROM turnos t
                    JOIN pacientes p ON t.Dni = p.Dni
                    WHERE t.CodUsu = @MedicoId AND e.CodEsp = @EspecialidadId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MedicoId", medicoId);
                cmd.Parameters.AddWithValue("@EspecialidadId", especialidadId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Mostrar los resultados en un DataGridView
                dgvPacientes.DataSource = dt;
            }
        }

        private void cmbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}