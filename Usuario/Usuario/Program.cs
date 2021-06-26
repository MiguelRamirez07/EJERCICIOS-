using System;

namespace Usuario
{
    class Program
    {
        class menor_mayor
        {
            int Numero1, Numero2, Numero3, Numero4, Numero5, Numero6, Numero7, Numero8, Numero9, Numero10, Numero11, Numero12, Numero13, Numero14, Numero15, Numero16, Numero17, Numero18, Numero19, Numero20;

            public void Mayor_Y_Menor()
            {
                Console.WriteLine("Inserte el numero 1");
                Numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 2");
                Numero2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 3");
                Numero3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 4");
                Numero4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 5");
                Numero5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 6");
                Numero6 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 7");
                Numero7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 8");
                Numero8 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 9");
                Numero9 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 10");
                Numero10 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 11");
                Numero11 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 12");
                Numero12 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 13");
                Numero13 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 14");
                Numero14 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 15");
                Numero15 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 16");
                Numero16 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 17");
                Numero17 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 18");
                Numero18 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 19");
                Numero19 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte el numero 20");
                Numero20 = Convert.ToInt32(Console.ReadLine());

                int[] numeros = { Numero1, Numero2, Numero3, Numero4, Numero5, Numero6, Numero7, Numero8, Numero9, Numero10, Numero11, Numero12, Numero13, Numero14, Numero15, Numero16, Numero17, Numero18, Numero19, Numero20 };

                Array.Reverse(numeros);

                Array.Sort(numeros);
                Console.WriteLine("Se ordenaran de menor a mayor");

                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine("Numero: " + numeros[i].ToString());
                }
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            menor_mayor OBJMYM = new menor_mayor();
            OBJMYM.Mayor_Y_Menor();
        }
    }
}
