using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Enumeraciones;
using LogicaNegocios;

namespace SGH
{
    class Prueba
    {
        static void Main(string[] args)
        {
            PacienteBL pacienteBL = new PacienteBL();
         
           // Paciente newPaciente = new Paciente("44216619", "SIXTO SANTIAGO", "AISA INCAPUÑO", DateTime.Parse("06-08-2018"),EnumTipo.ASEGURADO);
        
            
           // pacienteBL.InsertPaciente(newPaciente);
            Console.WriteLine("Insertar Paciente...");
            Console.ReadLine();

        }
       
    }
}
