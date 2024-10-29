using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinica_SePrice.Entidades
{
    public class Turno
    {
        public int CodTurno { get; set; }
        public int Dni { get; set; }
        public int CodUsu { get; set; }
        public DateTime FechaTurno { get; set; }
        public bool Acreditacion { get; set; }
        public TimeSpan HorarioTurno { get; set; }

        public string Display => $"Turno {CodTurno} - {FechaTurno.ToShortDateString()} {HorarioTurno}";
    }
}