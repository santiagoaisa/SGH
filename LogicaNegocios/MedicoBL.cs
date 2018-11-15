using AccesoDatos;
using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Enumeraciones;

namespace LogicaNegocios
{
    public class MedicoBL
    {
        public static List<Medico> Listmedicos;
        public List<Medico> GetMedicos()
        {
            string path = MedicosDAL.ConexionMedicos();

            Console.WriteLine($"{path}\\BD\\Medicos.txt");
            Console.ReadLine();

            string[] lines = System.IO.File.ReadAllLines($"{path}\\BD\\Medicos.txt");
            Listmedicos = new List<Medico>();
            foreach (var item in lines)
            {
                string Dni = item.Split('|')[0];
                string Cmp = item.Split('|')[1];
                string Nombre = item.Split('|')[2];
                string Apellido = item.Split('|')[3];
                


                // Paciente p = new Paciente(Dni,Nombre,Apellido,FechaNacimiento,TipoPaciente);
                // Listpacientes.Add(p);
            }
            return Listmedicos;
        }
        public void UpdateMedicos(string dni, Medico medicos) {
            foreach (Medico item in Listmedicos)
            {
                if (item.Dni == dni)
                {
                    item.Nombre = medicos.Nombre;
                    item.Apellidos = medicos.Apellidos;
                    
                 

                }
            }
            UpdateDataBase();
        }
        public void InsertMedico(Medico medicos) {
            string path = MedicosDAL.ConexionMedicos();
            using (StreamWriter outputFile = File.AppendText($"{path}\\BD\\Medicos.txt"))
            {
                string line = $"{medicos.Dni}|{medicos.Nombre}|{medicos.Apellidos}|{medicos.Cmp}";
                outputFile.WriteLine(line);
            }



        }

        public int DeletePaciente(string Dni)
        {
           int elementsRemoved= Listmedicos.RemoveAll(x => x.Dni == Dni);
           UpdateDataBase();
           return elementsRemoved;
        }
        private int UpdateDataBase() {
            string path = MedicosDAL.ConexionMedicos();
            int updatedLines = 0;
            using (StreamWriter outputFile = new StreamWriter($"{path}\\BD\\Medicos.txt"))
            {
                foreach (var item in Listmedicos)
                {
                    string line = $"{item.Dni}|{item.Cmp}|{item.Nombre}|{item.Apellidos}";
                    outputFile.WriteLine(line);
                    updatedLines++;
                }
            }
            return updatedLines;
        }
    }
}
