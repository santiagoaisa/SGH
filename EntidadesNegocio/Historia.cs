using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Historia
    {
        public string CodEsp { get; set; }
        public DateTime FechaAper { get; set; }
        public double Peso { get; set; }
        public double Talla { get; set; }
        public Historia(string codEsp, DateTime fechaAper, double peso, double talla)
        {
            this.CodEsp = codEsp;
            this.FechaAper = fechaAper;
            this.Peso = peso;
            this.Talla = talla;
        }
    }
}
