namespace Hospital
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; } // Podrías cambiar esto a un enum
        public string Telefono { get; set; }

        public Persona(string nombre, string apellidos, string sexo, string telefono)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Sexo = sexo;
            Telefono = telefono;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellidos} - Teléfono: {Telefono}";
        }
    }
}
