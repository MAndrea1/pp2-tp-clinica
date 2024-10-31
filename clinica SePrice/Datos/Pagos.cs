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
namespace clinica_SePrice.Datos
{
    internal class Pagos
    {

        public (int costo, int codTurno, DateTime fechaTurno, TimeSpan horarioTurno, bool acreditacion, string mensaje) ProcesarPago(int dni)
        {
            int costo = 0;
            int codTurno = 0;
            DateTime fechaTurno = DateTime.MinValue;
            TimeSpan horarioTurno = TimeSpan.Zero;
            bool acreditacion = false;
            string mensaje = string.Empty;
            using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
            {
                try
                {
                    using (MySqlCommand comando = new MySqlCommand("ProcesarPago", conexion))
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
                            if (reader.Read())
                            {
                                if (reader["Mensaje"] != DBNull.Value)
                                {
                                    mensaje = reader.GetString("Mensaje");
                                }
                                else
                                {
                                    costo = reader.GetInt32("Costo");
                                    codTurno = reader.GetInt32("CodTurno");
                                    fechaTurno = reader.GetDateTime("FechaTurno");
                                    horarioTurno = reader.GetTimeSpan("HorarioTurno");
                                    acreditacion = reader.GetBoolean("Acreditacion");
                                }
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

            return (costo, codTurno, fechaTurno, horarioTurno, acreditacion, mensaje);
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
                                // Aquí puedes agregar otras propiedades que necesites

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