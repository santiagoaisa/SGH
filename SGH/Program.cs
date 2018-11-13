using EntidadesNegocio;
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
                Console.ReadKey();
            }

        }

        public static void FormularioRegistrarPaciente()
        {
            Console.Clear();
            Console.WriteLine("********  Registro de Pacientes  ********");
            Console.WriteLine("");
            Console.WriteLine("1.Registro de paciente");
            Console.WriteLine("2.Regresar a la pagina anterior");
            Console.WriteLine("0. Volver al MENU PRINCIPAL");
            Console.WriteLine("");


            bool menuValido = false;

            while (!menuValido)
            {

                Console.WriteLine("Elija Usted una opcion del Menu Paciente:");

                int opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("Ingrese DNI:");
                        int dni = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese sus nombres:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese sus apellidos:");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese su fecha de nacimiento:");
                        int fecnac = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tipo de asegurado:");
                        string tipo = Console.ReadLine(); ;
                        menuValido = true;
                        break;
                    case 2:
                        FormularioRegistrarPaciente();
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
                        BuscarPaciente();
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

