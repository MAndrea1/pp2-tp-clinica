using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using clinica_SePrice.Entidades;

namespace clinica_SePrice.Datos
{
    internal class Medicos
    {
        public List<Medico> BuscarTodosLosMedicos()
        {
            return ObtenerMedicos("BuscarTodosLosMedicos", null);
        }

        public List<Medico> BuscarMedicosPorEspecialidad(int codEsp)
        {
            var parameters = new Dictionary<string, object>
            {
                { "@inputCodEsp", codEsp }
            };
            return ObtenerMedicos("BuscarTodosLosMedicosPorEspecialidad", parameters);
        }

        private List<Medico> ObtenerMedicos(string storedProcedureName, Dictionary<string, object> parameters)
        {
            DataTable medicosData = new DataTable();

            using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
            {
                try
                {
                    using (MySqlCommand comando = new MySqlCommand(storedProcedureName, conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        // Add parameters if any are provided
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
                            medicosData.Load(reader);
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

            List<Medico> medicos = new List<Medico>();
            foreach (DataRow item in medicosData.Rows)
            {
                var especialidad = new Especialidad
                {
                    CodEsp = int.Parse(item["CodEsp"].ToString()),
                    NomEsp = item["NomEsp"].ToString(),
                    Intervalo = int.Parse(item["Intervalo"].ToString())
                };

                medicos.Add(new Medico()
                {
                    CodUsu = int.Parse(item["CodUsu"].ToString()),
                    Nombre = item["Nombre"].ToString(),
                    Apellido = item["Apellido"].ToString(),
                    Especialidad = especialidad
                });
            }

            return medicos;
        }
    }
}
