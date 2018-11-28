using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesNegocio
{
    public class Cita
    {
        public string DNI_Paciente { get; set; }
        public string Nombres { get; set; }
        public double Apellidos { get; set; }
        public double COD_Especialidad { get; set; }
        public double COD_Doctor { get; set; }
        public Cita(string codEsp, DateTime fechaAper, double peso, double talla)
        {
            this.CodEsp = codEsp;
            this.FechaAper = fechaAper;
            this.Peso = peso;
            this.Talla = talla;
        }
    }
}
