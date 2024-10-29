using clinica_SePrice.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinica_SePrice.Datos
{
    internal class Especialidades
    {
        public List<Especialidad> BuscarTodasLasEspecialidades()
        {
            DataTable especialidadesData = new DataTable();

            using (MySqlConnection conexion = Conexion.GetInstancia().Conectar())
            {
                try
                {
                    using (MySqlCommand comando = new MySqlCommand("BuscarTodasLasEspecialidades", conexion))
                    {
                        comando.CommandType = CommandType.StoredProcedure;

                        if (conexion.State == ConnectionState.Open)
                        {
                            conexion.Close();
                        }
                        conexion.Open();

                        using (MySqlDataReader reader = comando.ExecuteReader())
                        {
                            especialidadesData.Load(reader);
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

            List<Especialidad> especialidades = new List<Especialidad>();
            foreach (DataRow item in especialidadesData.Rows)
            {
                especialidades.Add(new Especialidad()
                {
                    CodEsp = int.Parse(item["CodEsp"].ToString()),
                    NomEsp = item["NomEsp"].ToString(),
                    Intervalo = int.Parse(item["Intervalo"].ToString())
                });
            }

            return especialidades;
        }
    }
}
