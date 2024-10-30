using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using clinica_SePrice.Entidades;

namespace clinica_SePrice.Datos
{
    internal class Historias
    {
        public List<Historia> BuscarHistoriasPorDniYMedico(int dni, int codUsu)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@patientDni", dni },
                { "@doctorCodUsu", codUsu }
            };
            return ObtenerHistorias("GetHistoriasByDniAndCodUsu", parameters);
        }

        public void ActualizarDetallesHistoria(int codTurno, string nuevosDetalles)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@turnoCod", codTurno },
                { "@newDetalles", nuevosDetalles }
            };
            EjecutarProcedimiento("UpdateHistoriaDetalles", parameters);
        }

        private List<Historia> ObtenerHistorias(string storedProcedureName, Dictionary<string, object> parameters)
        {
            DataTable historiasData = new DataTable();

            using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
            {
                try
                {
                    using (MySqlCommand comando = new MySqlCommand(storedProcedureName, conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                comando.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        if (conexion.State == ConnectionState.Open)
                        {
                            conexion.Close();
                        }
                        conexion.Open();

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            historiasData.Load(reader);
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

            List<Historia> historias = new List<Historia>();
            foreach (DataRow item in historiasData.Rows)
            {
                var turno = new Turno()
                {
                    CodTurno = int.Parse(item["CodTurno"].ToString()),
                    Dni = int.Parse(item["Dni"].ToString()),
                    CodUsu = int.Parse(item["CodUsu"].ToString()),
                    FechaTurno = DateTime.Parse(item["FechaTurno"].ToString()),
                    Acreditacion = bool.Parse(item["Acreditacion"].ToString()),
                    HorarioTurno = TimeSpan.Parse(item["HorarioTurno"].ToString())
                };

                historias.Add(new Historia()
                {
                    CodTurno = turno.CodTurno,
                    Detalles = item["Detalles"].ToString(),
                    Turno = turno
                });
            }

            return historias;
        }

        private void EjecutarProcedimiento(string storedProcedureName, Dictionary<string, object> parameters)
        {
            using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
            {
                try
                {
                    using (MySqlCommand comando = new MySqlCommand(storedProcedureName, conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                comando.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

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
