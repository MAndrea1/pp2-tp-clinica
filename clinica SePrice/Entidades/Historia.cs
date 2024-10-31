using System;

namespace clinica_SePrice.Entidades
{
    public class Historia
    {
        public int CodTurno { get; set; }
        public string Detalles { get; set; }
        public Turno Turno { get; set; }

        public override string ToString()
        {
            return $"CodTurno: {CodTurno}, Detalles: {Detalles}, Turno: {Turno?.Display}";
        }
    }
}
