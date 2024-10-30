namespace clinica_SePrice.Entidades
{
    public class Medico
    {
        public int CodUsu { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Especialidad Especialidad { get; set; }

        public override string ToString()
        {
            return $"{this.Nombre} {this.Apellido} - {this.Especialidad}";
        }
    }
}