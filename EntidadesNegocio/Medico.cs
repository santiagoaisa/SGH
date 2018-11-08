﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Medico : Persona
    {
        public string Cmp { get; set; }
        public EnumEspecialidad Espec { get; set; }
        public Medico(string dni, string nombre, string apellidos, string cmp, EnumEspecialidad espec) : base(dni, nombre, apellidos)
        {
            this.Cmp = cmp;
            this.Espec = espec;
        }

    
    }
}
