using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using clinica_SePrice.Entidades;
using clinica_SePrice.Datos;
using System.Collections.Generic;

namespace clinica_SePrice
{
    public partial class frmHonorariosMedicos : Form
    {
        int mesSeleccionado;
        int yearSeleccionado = 2024; // Se debería reemplazar por un método dinámico, pero lo dejamos asi para poder tener resultados de los valores de muestra en la base de datos
        Medico medicoSeleccionado;
        List<Turno> turnosSeleccionados;

        public frmHonorariosMedicos()
        {
            InitializeComponent();
            List<int> listaDeMeses = new List<int>(new int[] { 11,10,9,8,7,6 }); // Se debería reemplazar por un método dinámico, pero lo dejamos asi para poder tener resultados de los valores de muestra en la base de datos
            cmbMes.DataSource = listaDeMeses;
        }

        private void frmHonorariosMedicos_Load(object sender, EventArgs e)
        {
            Medicos medicos = new Medicos();
            List<Medico> allMedicos = medicos.BuscarTodosLosMedicos();
            cmbMedicos.DataSource = allMedicos;
        }

        private void btnCalcularHonorarios_Click(object sender, EventArgs e)
        {
            decimal honorarios = CalcularHonorarios();
            txtTotal.Text = honorarios.ToString("C");
        }

        private decimal CalcularHonorarios()
        {
            Turnos turnos = new Turnos();
            turnosSeleccionados = turnos.BuscarTurnosPorMedicoYMes(medicoSeleccionado.CodUsu, yearSeleccionado, mesSeleccionado);

            // Supongamos que el costo por paciente atendido es 6000
            return turnosSeleccionados.Count * 6000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal honorarios = CalcularHonorarios();
            string fechaComprobante = $@"{mesSeleccionado}-{yearSeleccionado}";

            // Ruta y nombre del archivo PDF
            string filePath = $@"C:\Facturas\Factura_Honorarios_{medicoSeleccionado.ToString()}_{fechaComprobante}.pdf";

            // Crea el directorio si no existe
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));

            // Crear el documento PDF
            Document pdfDoc = new Document(PageSize.A4);
            PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));

            pdfDoc.Open();

            // Encabezado de la factura
            pdfDoc.Add(new Paragraph("Clínica SePrice - Factura de Honorarios Médicos"));
            pdfDoc.Add(new Paragraph("------------------------------------------------"));
            pdfDoc.Add(new Paragraph($"Fecha: {fechaComprobante}"));
            pdfDoc.Add(new Paragraph($"Médico: {medicoSeleccionado.ToString()}"));
            pdfDoc.Add(new Paragraph($"Código de Médico: {medicoSeleccionado.CodUsu}"));
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

        private void cmbMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            medicoSeleccionado = (Medico)((ComboBox)sender).SelectedValue;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            mesSeleccionado = (int)((ComboBox)sender).SelectedValue;
        }
    }
}