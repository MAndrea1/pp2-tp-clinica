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
    }
}