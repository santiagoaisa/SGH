using System;
using System.Collections.Generic;
using System.Text;

namespace SGH
{
    class FormularioPrincipal
    {

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
                        FormularioPaciente.MenuPaciente();
                        break;
                    case 2:
                        menuValido = true;
                        FormularioMedico.MenuMedico();
                        break;
                    default:
                        menuValido = false;
                        Console.WriteLine("Elija una opcion valida");
                        break;
                }

            }



            Console.ReadLine();
        }

    }
}
