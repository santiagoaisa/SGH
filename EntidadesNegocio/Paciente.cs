using System;
using Enumeraciones;
namespace Entities
{
    public class Paciente : Persona
    {
        public DateTime FechaNac { get; set; }
        public EnumTipo Tipo;
        public Historia HistCli { get; set; }
        public Paciente(string dni, string nombre, string apellidos, DateTime fechaNac, EnumTipo tipo) : base(dni, nombre, apellidos)
        {
            this.FechaNac = fechaNac;
            this.Tipo = tipo;
        }

        public string TipoPaciente
        {
            get{
                return Tipo.ToString();
            }

            set
            {
                if (value.ToUpper()=="A")
                {
                    Tipo = EnumTipo.ASEGURADO;
                }
                else
                {
                    Tipo = EnumTipo.PARTICULAR;
                }
            }
        }

        public void AsignarHistoria(Historia hist)
        {
            this.HistCli = hist;
        }

    }
}
