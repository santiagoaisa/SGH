using System;
using Enumeraciones;
namespace Entities
{
    public class Paciente : Persona
    {
        public DateTime FechaNac { get; set; }
        public EnumTipo Tipo { get; set; }
        public Historia HistCli { get; set; }
        public Paciente(string dni, string nombre, string apellidos, DateTime fechaNac, EnumTipo tipo) : base(dni, nombre, apellidos)
        {
            this.FechaNac = fechaNac;
            this.Tipo = tipo;
        }


        public void AsignarHistoria(Historia hist)
        {
            this.HistCli = hist;
        }

    }
}
