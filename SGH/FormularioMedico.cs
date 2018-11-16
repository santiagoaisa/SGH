using System;
using System.Collections.Generic;
using System.Text;

using Entities;
using Enumeraciones;
using LogicaNegocios;

namespace SGH
{
    class FormularioMedico
    {
        private static MedicoBL medicoBL = new MedicoBL();

        public static void MenuMedico()
        {
            Console.Clear();
            Console.WriteLine("********  Menu de Medicos  ********");
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

                Console.WriteLine("Elija Usted una opcion del Menu Medico:");

                int opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        RegistrarMedico();
                        menuValido = true;
                        break;
                    case 2:
                        BuscarDoctor();
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

        public static void RegistrarMedico()
        {
            

            Console.Clear();
            Console.WriteLine("********  Registro de Medicos ********");
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
                        Medico medico = new Medico(dni, nombre, apellido, cmp);
                        medicoBL.InsertMedico(medico);
                        menuValido = true;
                        MenuMedico();
                        break;
                    case 2:
                        MenuMedico();
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


        public static void BuscarDoctor()
        {
            Console.Clear();
            Console.WriteLine("********  Busqueda de Doctores en Base de Datos  ********");
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
                        MenuMedico();
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


    }
}
