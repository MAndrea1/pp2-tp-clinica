namespace clinica_SePrice.Entidades
{
    public class Paciente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public string Genero { get; set; }
        public string Nacionalidad { get; set; }
        public bool Prepaga { get; set; }
    }
}
