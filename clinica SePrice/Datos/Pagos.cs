using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clinica_SePrice.Entidades;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace clinica_SePrice.Datos
{
    internal class Pagos
    {
        
        public (int costo, string mensaje) ObtenerCostoTurno(int dni)
        {
            int costo = 0;
            string mensaje = string.Empty;

            using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
            {
                try
                {
                    using (MySqlCommand comando = new MySqlCommand("SELECT Prepaga FROM pacientes WHERE Dni = @dni", conexion))
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
                                bool prepaga = reader.GetBoolean("Prepaga");
                                costo = prepaga ? 3000 : 10000;
                                mensaje = "Pago procesado correctamente.";
                            }
                            else
                            {
                                mensaje = "Paciente no encontrado.";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    mensaje = $"Error al obtener el costo: {ex.Message}";
                }
            }

            return (costo, mensaje);
        }

        
        public void GenerarPdfPago(int dni, int costo, DateTime fechaTurno, TimeSpan horarioTurno, string nombrePaciente, string apellidoPaciente)
        {
            try
            {
                Document doc = new Document();
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"Pago_{dni}_{fechaTurno.ToString("yyyyMMdd")}.pdf");

                PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

                doc.Open();

               
                doc.Add(new Paragraph("Clínica SePrice - Comprobante de Pago"));

                
                doc.Add(new Paragraph($"Paciente: {nombrePaciente} {apellidoPaciente}"));
                doc.Add(new Paragraph($"DNI: {dni}"));

                
                doc.Add(new Paragraph($"Fecha del Turno: {fechaTurno.ToString("dd/MM/yyyy")}"));
                doc.Add(new Paragraph($"Hora: {horarioTurno.ToString()}"));

                
                doc.Add(new Paragraph($"Monto: ${costo}"));

                doc.Close();

                MessageBox.Show($"PDF generado exitosamente en {filePath}", "Pago Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        public List<Turno> ObtenerTurnosPorPaciente(int dni)
        {
            List<Turno> listaCitas = new List<Turno>();
            using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
            {
              try { 
                using (MySqlCommand comando = new MySqlCommand("BuscarTurnosPorPaciente", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@p_Dni", dni);

                        if (conexion.State == ConnectionState.Open)
                        {
                            conexion.Close();
                        }
                        conexion.Open();

                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaCitas.Add(new Turno
                            {
                                CodTurno = reader.GetInt32("CodTurno"),
                                FechaTurno = reader.GetDateTime("FechaTurno"),
                                HorarioTurno = reader.GetTimeSpan("HorarioTurno"),
                                Acreditacion = reader.GetBoolean("Acreditacion")
                                

                            });
                        }
                    }
                }
              }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }
            return listaCitas;
        }
        public void AcreditarTurno(int codTurno)
        {
            using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
            {

                try { 
                     using (MySqlCommand comando = new MySqlCommand("AcreditarTurno", conexion))
                     {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("@p_CodTurno", codTurno);
                        if (conexion.State == ConnectionState.Open)
                        {
                            conexion.Close();
                        }
                        conexion.Open();
                        comando.ExecuteNonQuery();
                      }
                 }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }
        }
    }
}