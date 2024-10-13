using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

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
    }
}