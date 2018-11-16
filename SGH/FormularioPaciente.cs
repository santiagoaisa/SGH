using System;
using System.Collections.Generic;
using System.Text;

using Entities;
using Enumeraciones;
using LogicaNegocios;

namespace SGH
{
    class FormularioPaciente
    {
        private static PacienteBL pacienteBL = new PacienteBL();

        public static void MenuPaciente()
        {
            Console.Clear();
            Console.WriteLine("********  Menu de Pacientes  ********");
            Console.WriteLine("");
            Console.WriteLine("Elija una opcion:");
            Console.WriteLine("");
            Console.WriteLine("1.Crear paciente");
            Console.WriteLine("2.Buscar pacientes");
            Console.WriteLine("3.Obtener Cita");
            Console.WriteLine("");
            Console.WriteLine("0.Regresar al MENU PRINCIPAL");

            bool menuValido = false;


            while (!menuValido)
            {

                Console.WriteLine("Elija Usted una opcion del Menu Paciente:");

                int opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        RegistrarPaciente();
                        menuValido = true;
                        break;
                    case 2:
                        BuscarPaciente();
                        menuValido = true;
                        break;
                    case 3:
                        ObtenerCita();
                        menuValido = true;
                        break;
                    case 0:
                        FormularioPrincipal.MenuPrincipal();
                        menuValido = true;
                        break;
                    default:
                        menuValido = false;
                        Console.WriteLine("Elija una opcion valida");
                        break;
                }

            }



            Console.ReadKey();

        }

        public static void RegistrarPaciente()
        {
            

            Console.Clear();
            Console.WriteLine("********  Registro de Pacientes  ********");
            Console.WriteLine("");

            Console.WriteLine("Ingrese DNI:");
            string dni = Console.ReadLine();
            Console.WriteLine("Ingrese sus nombres:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese sus apellidos:");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su fecha de nacimiento:");

            Console.WriteLine("Año de Nacimiento:");
            int año = int.Parse(Console.ReadLine());

            Console.WriteLine("Mes de Nacimiento:");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Dia de Nacimiento:");
            int dia = int.Parse(Console.ReadLine());

            DateTime fecnan = DateTime.Parse(dia + "/" + mes + "/" + año);
            Console.WriteLine("");

            Console.WriteLine("Tipo de paciente:");
            Console.WriteLine("A - Asegurado");
            Console.WriteLine("P - Particular");

            string tipo = Console.ReadLine();
            Console.WriteLine("");

            Paciente paciente = new Paciente(dni, nombre, apellido, fecnan, tipo);

            MenuConfirmarRegistro(paciente);
            

        }


        public static void BuscarPaciente()
        {
            Console.Clear();
            Console.WriteLine("********  Busqueda de Pacientes en Base de Datos  ********");
            Console.WriteLine("");
            Console.WriteLine("DNI");

            string dni = Console.ReadLine();
            Paciente paciente = pacienteBL.GetPaciente(dni);

            if (paciente == null)
            {

                Console.WriteLine("");
                Console.WriteLine("No se encontro el DNI indicado");

                MenuNuevaBusqueda();

            }
            else
            {
                PacienteEncontrado(paciente);
            }

           

        }


        public static void ObtenerCita()
        {
            Console.Clear();
            Console.WriteLine("********  Registro de Citas  ********");
            Console.WriteLine("");
            Console.WriteLine("1.Registrar una cita");
            Console.WriteLine("2. Regresar a la pagina anterior");
            Console.WriteLine("0. Volver al MENU PRINCIPAL");
            Console.WriteLine("");

            bool menuValido = false;

            while (!menuValido)
            {

                Console.WriteLine("Elija una opcion para continuar:");

                int opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("Ingrese DNI:");
                        int dni = int.Parse(Console.ReadLine());
                        menuValido = true;
                        break;
                    case 2:
                        MenuPaciente();
                        menuValido = true;
                        break;
                    case 0:
                        FormularioPrincipal.MenuPrincipal();
                        menuValido = true;
                        break;
                    default:
                        menuValido = false;
                        Console.WriteLine("Elija una opcion valida");
                        break;
                }
                Console.ReadKey();
            }

        }


        public static void MenuConfirmarRegistro(Paciente paciente)
        {
            Console.WriteLine("********  CONFIRMACIÓN DE REGISTRO  ********");
            Console.WriteLine("");
            Console.WriteLine("1. Para Registrar");
            Console.WriteLine("2. Para Cancelar y Volver al MENU ANTERIOR");
            Console.WriteLine("0. Para Cancelar y Volver al MENU PRINCIPAL");
            Console.WriteLine("");

            bool menuValido = false;

            while (!menuValido)
            {

                Console.WriteLine("Elija una opcion para continuar:");

                int opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        //                        
                        pacienteBL.InsertPaciente(paciente);                        
                        menuValido = true;
                        MenuPaciente();
                        break;
                    case 2:
                        MenuPaciente();
                        menuValido = true;
                        break;
                    case 0:
                        FormularioPrincipal.MenuPrincipal();
                        menuValido = true;
                        break;
                    default:
                        menuValido = false;
                        Console.WriteLine("Elija una opcion valida");
                        break;
                }
                Console.ReadKey();
            }
        }


        public static void MenuNuevaBusqueda()
        {
            bool menuValido = false;

            while (!menuValido)
            {
                Console.WriteLine("********  NUEVA BUSQUEDA  ********");
                Console.WriteLine("");
                Console.WriteLine("1. Nueva Busqueda");
                Console.WriteLine("2. MENU PACIENTE");
                Console.WriteLine("0. MENU PRINCIPAL");
                Console.WriteLine("");

                int opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        BuscarPaciente();
                        menuValido = true;                        
                        break;
                    case 2:
                        MenuPaciente();
                        menuValido = true;
                        break;
                    case 0:
                        FormularioPrincipal.MenuPrincipal();
                        menuValido = true;
                        break;
                    default:
                        menuValido = false;
                        Console.WriteLine("Elija una opcion valida");
                        break;
                }
                Console.ReadKey();
            }
        }


        public static void PacienteEncontrado(Paciente paciente)
        {            
            Console.Clear();
            Console.WriteLine("********  Paciente Encontrado  ********");
            Console.WriteLine("");

            Console.WriteLine("DNI:" +  paciente.Dni);

            Console.WriteLine("Nombre:"+paciente.Nombre);
            Console.WriteLine("Apellidos:"+paciente.Apellidos);

            Console.WriteLine("F.Nacimiento:"+paciente.FechaNac);
            
            Console.WriteLine("Tipo de Paciente:"+paciente.TipoPaciente);
          
            Console.WriteLine("");

            MenuNuevaBusqueda();
        }

    }
}
