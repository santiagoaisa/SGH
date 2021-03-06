﻿using AccesoDatos;
using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Enumeraciones;

namespace LogicaNegocios
{
    public class PacienteBL
    {
        public static List<Paciente> Listpacientes;

        public Paciente GetPaciente(String dni)
        {
            string path = PacientesDAL.ConexionPacientes();
            

            string[] lines = System.IO.File.ReadAllLines($"{path}\\BD\\Pacientes.txt");
            Paciente paciente=null;
            foreach (var item in lines)
            {
                string Dni = item.Split('|')[0];

                if (Dni== dni)
                {
                    string Nombre = item.Split('|')[1];
                    string Apellido = item.Split('|')[2];
                    DateTime FechaNacimiento = DateTime.Parse(item.Split('|')[3]); ;
                    string TipoPaciente = item.Split('|')[4];

                    //EnumTipo TipoPaciente = (EnumTipo)Enum.Parse(typeof(EnumTipo), item.Split('|')[4], true);

                    paciente = new Paciente(Dni,Nombre,Apellido,FechaNacimiento, TipoPaciente.Substring(0, 1));
                   
                }
                
                
            }

           

            return paciente;
        }


        public List<Paciente> GetPacientes()
        {
            string path = PacientesDAL.ConexionPacientes();
            

            string[] lines = System.IO.File.ReadAllLines($"{path}\\BD\\Pacientes.txt");
            Listpacientes = new List<Paciente>();
            foreach (var item in lines)
            {
                string Dni=item.Split('|')[0];
                string Nombre = item.Split('|')[1];
                string Apellido = item.Split('|')[2];
                DateTime FechaNacimiento = DateTime.Parse(item.Split('|')[3]); ;
                EnumTipo TipoPaciente = (EnumTipo)Enum.Parse(typeof(EnumTipo), item.Split('|')[4], true);

               // Paciente p = new Paciente(Dni,Nombre,Apellido,FechaNacimiento,TipoPaciente);
               // Listpacientes.Add(p);
            }
            return Listpacientes;
        }
        public void UpdatePaciente(string dni, Paciente paciente) {
            foreach (Paciente item in Listpacientes)
            {
                if (item.Dni == dni)
                {
                    item.Nombre = paciente.Nombre;
                    item.Apellidos = paciente.Apellidos;
                    item.FechaNac = paciente.FechaNac;
                    item.Tipo = paciente.Tipo;

                }
            }
            UpdateDataBase();
        }
        public void InsertPaciente(Paciente paciente) {
            string path = PacientesDAL.ConexionPacientes();
            using (StreamWriter outputFile = File.AppendText($"{path}\\BD\\Pacientes.txt"))
            {
                string line = $"{paciente.Dni}|{paciente.Nombre}|{paciente.Apellidos}|{paciente.FechaNac}|{paciente.Tipo.ToString()}";
                outputFile.WriteLine(line);
            }

                
           
        }

        public int DeletePaciente(string Dni)
        {
           int elementsRemoved= Listpacientes.RemoveAll(x => x.Dni == Dni);
           UpdateDataBase();
           return elementsRemoved;
        }
        private int UpdateDataBase() {
            string path = PacientesDAL.ConexionPacientes();
            int updatedLines = 0;
            using (StreamWriter outputFile = new StreamWriter($"{path}\\BD\\Pacientes.txt"))
            {
                foreach (var item in Listpacientes)
                {
                    string line = $"{item.Dni}|{item.Nombre}|{item.Apellidos}|{item.FechaNac}|{item.Tipo.ToString()}"; 
                    outputFile.WriteLine(line);
                    updatedLines++;
                }
            }
            return updatedLines;
        }
    }
}
