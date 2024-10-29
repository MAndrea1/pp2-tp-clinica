using MySql.Data.MySqlClient;
using System.Data;
using System;

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using clinica_SePrice.Entidades;

namespace clinica_SePrice.Datos
{
    internal class Pacientes
    {
        public void AgregarPaciente(string nombre, string apellido, int dni, string genero, string nacionalidad, bool prepaga)
        {
            using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
            {
                try
                {
                    using (MySqlCommand comando = new MySqlCommand("InsertarPaciente", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("p_Nombre", nombre);
                        comando.Parameters.AddWithValue("p_Apellido", apellido);
                        comando.Parameters.AddWithValue("p_Dni", dni);
                        comando.Parameters.AddWithValue("p_Genero", genero);
                        comando.Parameters.AddWithValue("p_Nacionalidad", nacionalidad);
                        comando.Parameters.AddWithValue("p_Prepaga", prepaga);

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
        public Paciente BuscarPaciente(int dni)
        {
            Paciente paciente = null;

            using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
            {
                try
                {
                    using (MySqlCommand comando = new MySqlCommand("BuscarPaciente", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("Doc", dni);

                        if (conexion.State == ConnectionState.Open)
                        {
                            conexion.Close();
                        }
                        conexion.Open();

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                paciente = new Paciente
                                {
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Apellido"].ToString(),
                                    Dni = Convert.ToInt32(reader["Dni"]),
                                    Genero = reader["Genero"].ToString(),
                                    Nacionalidad = reader["Nacionalidad"].ToString(),
                                    Prepaga = Convert.ToBoolean(reader["Prepaga"])
                                };
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

            return paciente;
        }
    }
}