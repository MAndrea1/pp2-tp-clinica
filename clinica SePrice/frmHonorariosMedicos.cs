using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace clinica_SePrice
{
    public partial class frmHonorariosMedicos : Form
    {
        public frmHonorariosMedicos()
        {
            InitializeComponent();
        }

        private void frmHonorariosMedicos_Load(object sender, EventArgs e)
        {
            
            CargarMedicos();
        }

        private void CargarMedicos()
        {
            using (SqlConnection conn = new SqlConnection("tu_cadena_de_conexion"))
            {
                conn.Open();
                string query = "SELECT CodUsu, Nombre FROM medicos";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbMedicos.DataSource = dt;
                cmbMedicos.DisplayMember = "Nombre";
                cmbMedicos.ValueMember = "CodUsu";
            }
        }

        private void btnCalcularHonorarios_Click(object sender, EventArgs e)
        {
            int medicoId = Convert.ToInt32(cmbMedicos.SelectedValue);
            decimal honorarios = CalcularHonorarios(medicoId);
            txtTotal.Text = honorarios.ToString("C");
        }

        private decimal CalcularHonorarios(int medicoId)
        {
            int cantidadPacientes = 0;

            using (SqlConnection conn = new SqlConnection("tu_cadena_de_conexion"))
            {
                conn.Open();
                string query = @"
                    SELECT COUNT(*) 
                    FROM turnos 
                    WHERE CodUsu = @MedicoId AND MONTH(FechaTurno) = MONTH(GETDATE()) AND YEAR(FechaTurno) = YEAR(GETDATE())";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MedicoId", medicoId);
                cantidadPacientes = (int)cmd.ExecuteScalar();
            }

            // Supongamos que el costo por paciente atendido es 6000
            return cantidadPacientes * 6000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int medicoId = Convert.ToInt32(cmbMedicos.SelectedValue);
            string nombreMedico = cmbMedicos.Text;
            decimal honorarios = CalcularHonorarios(medicoId);
            DateTime fecha = DateTime.Now;

            // Ruta y nombre del archivo PDF
            string filePath = $@"C:\Facturas\Factura_Honorarios_{nombreMedico}_{fecha:yyyyMMdd}.pdf";

            // Crea el directorio si no existe
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            // Crear el documento PDF
            Document pdfDoc = new Document(PageSize.A4);
            PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));

            pdfDoc.Open();

            // Encabezado de la factura
            pdfDoc.Add(new Paragraph("Clínica SePrice - Factura de Honorarios Médicos"));
            pdfDoc.Add(new Paragraph("------------------------------------------------"));
            pdfDoc.Add(new Paragraph($"Fecha: {fecha:dd/MM/yyyy}"));
            pdfDoc.Add(new Paragraph($"Médico: {nombreMedico}"));
            pdfDoc.Add(new Paragraph($"Código de Médico: {medicoId}"));
            pdfDoc.Add(new Paragraph($"Total de Pacientes Atendidos: {honorarios / 6000}"));
            pdfDoc.Add(new Paragraph($"Honorarios Totales: {honorarios:C}"));
            pdfDoc.Add(new Paragraph("------------------------------------------------"));

            // Cierre del documento
            pdfDoc.Close();

            MessageBox.Show("PDF generado con éxito en " + filePath);
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}