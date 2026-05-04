using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluacion_1.Back
{
    public class Empleado: Persona, IPersona
    {
        public string Cuil { get; set; }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Id: {Id}, Cuil: {Cuil}, nombre: {Nombre}");
        }

        public Empleado(int id, string cuil, string nombre): base(id, cuil, nombre)
        {
            Cuil = cuil;
            MostrarInformacion();
        }
    }
}
