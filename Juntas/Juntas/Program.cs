using System;

namespace Juntas
{
    class Program
    {
        class Salas
        {

            double opcion_menu;
            char tecla;
            String em1, emp2, emp3, dia1, dia2, dia3, h1, h2, h3;
            string respuesta, respuesta2;
            public void caso()
            {

                do
                {
                    Console.Clear();
                    Console.SetCursorPosition(30, 0);
                    Console.WriteLine("**Ramirez **");
                    Console.SetCursorPosition(13, 1);
                    Console.WriteLine("**Agenda empresarial Altamirano**");
                    do
                    {
                        Console.SetCursorPosition(1, 2);
                        if (opcion_menu == 1)
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("sala 1");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(30, 2);
                        if (opcion_menu == 2)
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("sala 2");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(60, 2);
                        if (opcion_menu == 3)
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("sala 3");

                        Console.ForegroundColor = ConsoleColor.White;
                        tecla = (char)Console.ReadKey().Key;
                        switch (tecla)
                        {
                            case (char)ConsoleKey.LeftArrow:
                                if (opcion_menu == 1) opcion_menu = 3; else opcion_menu--;
                                break;
                            case (char)ConsoleKey.RightArrow:
                                if (opcion_menu == 3) opcion_menu = 1; else opcion_menu++;
                                break;
                        }
                    } while (tecla != (char)ConsoleKey.Escape && tecla != (char)ConsoleKey.Enter);
                    if (tecla == (char)ConsoleKey.Escape)
                        opcion_menu = 0;
                    Console.WriteLine("" + opcion_menu);

                    if (opcion_menu == 1)
                    {
                        Console.WriteLine("**ingreso a sala 1**");
                        Console.WriteLine("Registre su empresa: ");
                        em1 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("HORA citada: ");
                        h1 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("DIA citado: ");
                        dia1 = Convert.ToString(Console.ReadLine());
                        if (dia1 == "domingo")
                        {
                            Console.WriteLine("“La sala sobrepaso el horario de servicio");
                        }
                        Console.WriteLine("aqui puede ver el horario DE LAS CITAS INTRODUZCA -horario-");
                        respuesta = Convert.ToString(Console.ReadLine());
                        if (respuesta == "horario")
                        {
                            Console.WriteLine(" ------------------------------------------------------------------");
                            Console.WriteLine(" sala 1 agenda");
                            Console.WriteLine("EMPRESA :" + em1);
                            Console.WriteLine("HORA :" + h1);
                            Console.WriteLine("DIA :" + dia1);
                            Console.WriteLine(" ------------------------------------------------------------------");
                        }
                        Console.WriteLine("¿DESEA AGENDAR OTRA VEZ?");
                        respuesta2 = Convert.ToString(Console.ReadLine());
                    }
                    else if (opcion_menu == 2)
                    {
                        Console.WriteLine("**ingreso a la sala 2**");
                        Console.WriteLine("registre su empresa: ");
                        emp2 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("HORA  citado: ");
                        h2 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("DIA citado: ");
                        dia2 = Convert.ToString(Console.ReadLine());
                        if (dia2 == "domingo")
                        {
                            Console.WriteLine("“La sala sobrepasa el horario de servicio");
                        }
                        Console.WriteLine("aqui puede ver el horario DE LAS CITAS INTRODUZCA -horario-");
                        respuesta = Convert.ToString(Console.ReadLine());
                        if (respuesta == "horario")
                        {
                            Console.WriteLine(" ------------------------------------------------------------------");
                            Console.WriteLine(" sala 2 agenda");
                            Console.WriteLine("EMPRESA :" + emp2);
                            Console.WriteLine("HORA :" + h2);
                            Console.WriteLine("DIA :" + dia2);
                            Console.WriteLine(" ------------------------------------------------------------------");
                        }
                        Console.WriteLine("¿DESEA AGENDAR OTRA VEZ?");
                        respuesta2 = Convert.ToString(Console.ReadLine());
                    }

                    else
                    {
                        Console.WriteLine("**ingresaste a la sala 3**");
                        Console.WriteLine("registre su EMPRESA: ");
                        emp3 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("HORA citada: ");
                        h3 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("DIA citado: ");
                        dia3 = Convert.ToString(Console.ReadLine());
                        if (dia3 == "domingo")
                        {
                            Console.WriteLine("“La sala sobrepasa el  horario de servicio");
                        }
                        Console.WriteLine("aqui puede ver el horario DE LAS CITAS INTRODUZCA -horario-");
                        respuesta = Convert.ToString(Console.ReadLine());
                        if (respuesta == "horario")
                        {
                            Console.WriteLine(" ------------------------------------------------------------------");
                            Console.WriteLine(" sala 1 agenda");
                            Console.WriteLine("EMPRESA :" + emp3);
                            Console.WriteLine("HORA :" + h3);
                            Console.WriteLine("DIA :" + dia3);
                            Console.WriteLine(" ------------------------------------------------------------------");
                        }
                        Console.WriteLine("¿DESEA AGENDAR OTRA VEZ?");
                        respuesta2 = Convert.ToString(Console.ReadLine());
                    }




                } while (respuesta2 == "si");

            }
        }
        static void Main(string[] args)
        {
            Salas objcasos = new Salas();
            objcasos.caso();
        }

    }
}

