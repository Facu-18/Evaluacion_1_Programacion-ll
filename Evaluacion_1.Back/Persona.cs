namespace Evaluacion_1.Back
{
    public class Persona
    {
        public int Id { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}, DNI: {DNI}, Nombre: {Nombre}");
        }

        public Persona(int id, string dni, string nombre)
        {
            Id = id;
            DNI = dni;
            Nombre = nombre;
        }
    }
}
