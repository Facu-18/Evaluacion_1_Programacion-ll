using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Evaluacion_1.Back
{
    public class Alumno: Persona
    {
        public string Materia { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Materia: {Materia}");
        }

        public Alumno(int id, string dni, string nombre, string materia): base(id, dni, nombre)
        {
            Materia = materia;
            MostrarInformacion();
        }
    }

}
