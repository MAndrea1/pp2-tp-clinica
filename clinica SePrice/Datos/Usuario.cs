using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace clinica_SePrice.Datos
{
    internal class Usuario
    {

        public DataTable Log_Usu(string L_Usu, string P_Usu, int rolUsu)
        {
            DataTable tabla = new DataTable();
            using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
            {
                try
                {
                    using (MySqlCommand comando = new MySqlCommand("IngresoLogin", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;
                        comando.Parameters.AddWithValue("Usu", L_Usu);
                        comando.Parameters.AddWithValue("Pass", P_Usu);
                        comando.Parameters.AddWithValue("RolUsu", rolUsu);

                        if (conexion.State == ConnectionState.Open)
                        {
                            conexion.Close();
                        }
                        conexion.Open();

                        using (MySqlDataReader resultado = comando.ExecuteReader())
                        {
                            tabla.Load(resultado);
                            return tabla;
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

        }
    }
}