using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Crud.Order.Types;

namespace clinica_SePrice.Entidades
{

    public class Medico
    {
        public int CodUsu { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Especialidad { get; set; }

        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido}";
        }
    }
}