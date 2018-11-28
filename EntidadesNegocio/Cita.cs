using System;
using System.Collections.Generic;
using System.Text;

namespace EntidadesNegocio
{
    public class Cita
    {
        public string DNI_Paciente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public double COD_Especialidad { get; set; }
        public double COD_Doctor { get; set; }
        public string TipoCita { get; set; }
        public string EstadoCita { get; set; }
        public Cita(string DNI_paciente,string nombres,string apellidos,double COD_especialidad,double COD_doctor,string tipocita, string estadocita)
        {
            this.DNI_Paciente = DNI_paciente;
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.COD_Especialidad = COD_especialidad;
            this.COD_Doctor = COD_doctor;
            this.TipoCita = tipocita;
            this.EstadoCita = estadocita;
        }
    }
}
