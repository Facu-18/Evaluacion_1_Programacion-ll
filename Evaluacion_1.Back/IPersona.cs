using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluacion_1.Back
{
    public interface IPersona
    {
        public int Id { get; set; }
        
        public string DNI { get; set; }
        public string Nombre { get; set; }
        void MostrarInformacion();
    }
}
