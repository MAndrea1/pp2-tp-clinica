using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinica_SePrice.Entidades
{
    public class Especialidad
    {
        public int CodEsp { get; set; }
        public string NomEsp { get; set; }
        public int Intervalo { get; set; }

        public override string ToString()
        {
            return $"{NomEsp} ({Intervalo} mins)";
        }
    }
}
