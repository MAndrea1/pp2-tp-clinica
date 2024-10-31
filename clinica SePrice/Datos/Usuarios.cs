using System;
using System.Data;
using clinica_SePrice.Entidades;
using MySql.Data.MySqlClient;

namespace clinica_SePrice.Datos
{
    internal class Usuarios
    {
        public Usuario Log_Usu(string L_Usu, string P_Usu, int rolUsu)
        {
            Entidades.Usuario usuario = null;
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
                            if (resultado.Read())
                            {
                                usuario = new Entidades.Usuario
                                {
                                    CodUsu = Convert.ToInt32(resultado["CodUsu"]),
                                    NombreUsu = L_Usu,
                                    PassUsu = P_Usu,
                                    Rol = new Rol
                                    {
                                        RolUsu = rolUsu,
                                        // You might need to fetch NomRol separately if it's not in this procedure's result set
                                        NomRol = (rolUsu == 120) ? "Administrador" : "Medico"
                                    }
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
            return usuario;
        }
    }
}
