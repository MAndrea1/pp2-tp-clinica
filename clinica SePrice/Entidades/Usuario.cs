namespace clinica_SePrice.Entidades
{
    public class Usuario
    {
        public int CodUsu { get; set; }
        public string NombreUsu { get; set; }
        public string PassUsu { get; set; }
        public Rol Rol { get; set; }

        public override string ToString()
        {
            return $"{NombreUsu} - {Rol.NomRol}";
        }
    }

    public class Rol
    {
        public int RolUsu { get; set; }
        public string NomRol { get; set; }

        public override string ToString()
        {
            return NomRol;
        }
    }
}
