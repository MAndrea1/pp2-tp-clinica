﻿using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using clinica_SePrice.Entidades;

namespace clinica_SePrice.Datos
{
    internal class Turnos
    {
        // Method to add a new appointment
        public bool AgregarTurno(int dni, int codUsu, DateTime fechaTurno, bool acreditacion, TimeSpan horarioTurno)
        {
            using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
            {
                try
                {
                    using (MySqlCommand comando = new MySqlCommand("InsertarTurno", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("p_Dni", dni);
                        comando.Parameters.AddWithValue("p_CodUsu", codUsu);
                        comando.Parameters.AddWithValue("p_FechaTurno", fechaTurno);
                        comando.Parameters.AddWithValue("p_Acreditacion", acreditacion);
                        comando.Parameters.AddWithValue("p_HorarioTurno", horarioTurno);

                        if (conexion.State == ConnectionState.Open)
                        {
                            conexion.Close();
                        }
                        conexion.Open();
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                    return false;
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

        public List<Turno> BuscarTurnosPorMedico(int codUsu)
        {
            List<Turno> listaTurnos = new List<Turno>();

            using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
            {
                try
                {
                    using (MySqlCommand comando = new MySqlCommand("BuscarTurnosPorMedico", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("p_CodUsu", codUsu);

                        if (conexion.State == ConnectionState.Open)
                        {
                            conexion.Close();
                        }
                        conexion.Open();

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Turno turno = new Turno
                                {
                                    CodTurno = Convert.ToInt32(reader["CodTurno"]),
                                    Dni = Convert.ToInt32(reader["Dni"]),
                                    CodUsu = codUsu,
                                    FechaTurno = Convert.ToDateTime(reader["FechaTurno"]),
                                    Acreditacion = Convert.ToBoolean(reader["Acreditacion"]),
                                    HorarioTurno = (TimeSpan)reader["HorarioTurno"]
                                };

                                listaTurnos.Add(turno);
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

            return listaTurnos;
        }
    

        public List<Turno> BuscarTurnosPorMedicoYFecha(int codUsu, DateTime fechaTurno)
        {
            List<Turno> listaTurnos = new List<Turno>();

            using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
            {
                try
                {
                    using (MySqlCommand comando = new MySqlCommand("BuscarTurnosPorMedicoYFecha", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("p_CodUsu", codUsu);
                        comando.Parameters.AddWithValue("p_FechaTurno", fechaTurno);

                        if (conexion.State == ConnectionState.Open)
                        {
                            conexion.Close();
                        }
                        conexion.Open();

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Turno turno = new Turno
                                {
                                    CodTurno = Convert.ToInt32(reader["CodTurno"]),
                                    Dni = Convert.ToInt32(reader["Dni"]),
                                    CodUsu = codUsu,
                                    FechaTurno = Convert.ToDateTime(reader["FechaTurno"]),
                                    Acreditacion = Convert.ToBoolean(reader["Acreditacion"]),
                                    HorarioTurno = (TimeSpan)reader["HorarioTurno"]
                                };

                                listaTurnos.Add(turno);
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

            return listaTurnos;
        }
    }
}