using EntidadesNegocio;
using Entities;
using LogicaNegocios;
using System;

namespace SGH
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();

        }

        public static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("***** MENU PRINCIPAL *****");
            Console.WriteLine("");
            Console.WriteLine("1. Paciente");
            Console.WriteLine("");
            Console.WriteLine("2. Medicos");
            Console.WriteLine("");
            bool menuValido = false;


            while (!menuValido)
            {

                Console.WriteLine("Elija Usted una opcion del MENU PRINCIPAL:");

                int opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        menuValido = true;
                        MenuPaciente();
                        break;
                    case 2:
                        menuValido = true;
                        MenuMedicos();
                        break;
                    default:
                        menuValido = false;
                        Console.WriteLine("Elija una opcion valida");
                        break;
                }

            }



            Console.ReadLine();
        }

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
                        FormularioRegistrarPaciente();
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
                        MenuPrincipal();
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
                        MenuPrincipal();
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

        public static void FormularioRegistrarPaciente()
        {
            PacienteBL pacienteBL = new PacienteBL(); 

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

            DateTime fecnan = DateTime.Parse(dia+"/"+mes+"/"+año);
            Console.WriteLine("");

            Console.WriteLine("Tipo de asegurado:");
            Console.WriteLine("A - Asegurado");
            Console.WriteLine("P - Particular");
            
            string tipo = Console.ReadLine(); 
            Console.WriteLine("");

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
                        Paciente paciente = new Paciente(dni,nombre,apellido,fecnan,tipo);
                        pacienteBL.InsertPaciente(paciente);


                        menuValido = true;
                        MenuPaciente();
                        break;
                    case 2:
                        MenuPaciente();
                        menuValido = true;
                        break;
                    case 0:
                        MenuPrincipal();
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



        public static void BuscarPaciente()
        {
            Console.Clear();
            Console.WriteLine("********  Busqueda de Pacientes en Base de Datos  ********");
            Console.WriteLine("");
            Console.WriteLine("1.Busqueda");
            Console.WriteLine("2.Regresar a la pagina anterior");
            Console.WriteLine("0. Volver al MENU PRINCIPAL");
            Console.WriteLine("");

            bool menuValido = false;

            while (!menuValido)
            {

                Console.WriteLine("Elija Usted una opcion del Menu para comenzar la busqueda:");

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
                        MenuPrincipal();
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

        public static void MenuMedicos()
        {
            Console.Clear();
            Console.WriteLine("********  Menu de Doctores  ********");
            Console.WriteLine("");
            Console.WriteLine("Elija una opcion:");
            Console.WriteLine("");
            Console.WriteLine("1.Crear doctor");
            Console.WriteLine("2.Buscar doctor");
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
                        FormularioRegistrarDoctor();
                        menuValido = true;
                        break;
                    case 2:
                        BuscarDoctor();
                        menuValido = true;
                        break;
                    case 0:
                        MenuPrincipal();
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
        public static void FormularioRegistrarDoctor()
        {
            DoctorBL doctorBL = new DoctorBL();

            Console.Clear();
            Console.WriteLine("********  Registro de Doctores ********");
            Console.WriteLine("");

            Console.WriteLine("Ingrese DNI:");
            string dni = Console.ReadLine();
            Console.WriteLine("Ingrese Codigo CMP :");
            string cmp = Console.ReadLine();    
            Console.WriteLine("Ingrese sus nombres:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese sus apellidos:");
            string apellido = Console.ReadLine();

            Console.WriteLine("Especialidad:");
            Console.WriteLine("G - para general, luego lo derivaremos a otras especialidades");
            string Espec = Console.ReadLine();
            

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
                        Medico medico = new Medico(dni,nombre, apellido,cmp);
                        doctorBL.InsertMedico(medico);
                        menuValido = true;
                        MenuMedicos();
                        break;
                    case 2:
                        MenuMedicos();
                        menuValido = true;
                        break;
                    case 0:
                        MenuPrincipal();
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

        public static void BuscarDoctor()
        {
            Console.Clear();
            Console.WriteLine("********  Busqueda de Pacientes en Base de Datos  ********");
            Console.WriteLine("");
            Console.WriteLine("1.Busqueda");
            Console.WriteLine("2.Regresar a la pagina anterior");
            Console.WriteLine("0. Volver al MENU PRINCIPAL");
            Console.WriteLine("");

            bool menuValido = false;

            while (!menuValido)
            {

                Console.WriteLine("Elija Usted una opcion del Menu para comenzar la busqueda:");

                int opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("Ingrese DNI:");
                        int dni = int.Parse(Console.ReadLine());
                        menuValido = true;
                        break;
                    case 2:
                        MenuMedicos();
                        menuValido = true;
                        break;
                    case 0:
                        MenuPrincipal();
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


    }
}








/*Ejemplo
 * 
        PacienteBL pacienteBL = new PacienteBL();
        var Pacientes= pacienteBL.GetPacientes();
        Console.WriteLine("Todos los Pacientes...");
        foreach (var item in Pacientes)
        {
            Console.WriteLine($"{item.Dni},{item.Nombre},{item.Apellido}");
        }
        //ACTUALIZAR PACIENTE
        Paciente updatedPaciente = new Paciente("44216617","Jose", "Herrera");
        pacienteBL.UpdatePaciente("44216617", updatedPaciente);
        Console.WriteLine("Actualizacion de Paciente...");
        foreach (var item in PacienteBL.Listpacientes)
        {
            Console.WriteLine($"{item.Dni},{item.Nombre},{item.Apellido}");
        }
        //AGREGAR PACIENTE
        Paciente newPaciente = new Paciente("44216619", "Martin", "Centeno");
        pacienteBL.InsertPaciente(newPaciente);
        Console.WriteLine("Insertar Paciente...");
        foreach (var item in PacienteBL.Listpacientes)
        {
            Console.WriteLine($"{item.Dni},{item.Nombre},{item.Apellido}");
        }
        //ELIMINAR PACIENTE
        pacienteBL.DeletePaciente("44216619");
        Console.WriteLine("Eliminar Paciente...");
        foreach (var item in PacienteBL.Listpacientes)
        {
            Console.WriteLine($"{item.Dni},{item.Nombre},{item.Apellido}");
        }
 * */

