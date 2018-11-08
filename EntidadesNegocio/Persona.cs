using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Persona
    {
        public string Dni { get; set; }

        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public Persona(string dni, string nombre, string apellidos)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
        }
    }
}
