using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using clinica_SePrice.Entidades;
using MySqlX.XDevAPI.Relational;

namespace clinica_SePrice.Datos
{
    internal class Medicos
    {
        public List<Medico> BuscarTodosLosMedicos()
        {
            DataTable medicosData = new DataTable();

            using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
            {
                try
                {
                    using (MySqlCommand comando = new MySqlCommand("BuscarTodosLosMedicos", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

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
                medicos.Add(new Medico()
                {
                    CodUsu = int.Parse(item["CodUsu"].ToString()),
                    Nombre = item["Nombre"].ToString(),
                    Apellido = item["Apellido"].ToString(),
                    Especialidad = item["Especialidad"].ToString(),
                });
            }

            return medicos;
        }
    }
}
