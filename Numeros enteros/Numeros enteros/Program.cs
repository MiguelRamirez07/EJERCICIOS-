using System;

namespace Numeros_enteros
{
    class Program
    {
        class Numerosenteros
        {
            public int Numero1, Numero2, Numero3, Numero4, Numero5, Numero6, Numero7, Numero8, Numero9, Numero10, suma, promedio;

            public void sumar()
            {
                //A
                Console.WriteLine("Insertar el numero 1");
                Numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 2");
                Numero2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 3");
                Numero3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 4");
                Numero4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 5");
                Numero5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 6");
                Numero6 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 7");
                Numero7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 8");
                Numero8 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 9");
                Numero9 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 10");
                Numero10 = Convert.ToInt32(Console.ReadLine());

                suma = Numero1 + Numero2 + Numero3 + Numero4 + Numero5 + Numero6 + Numero7 + Numero8 + Numero9 + Numero10;
                Console.WriteLine("M) Suma de los  digitos  " + suma);

            }
            public void PROMEDIO()
            {
                promedio = suma / 10;
                Console.WriteLine("N) Promedio de los digitos " + promedio);
            }

            public void Numerogrande()
            {
                if (Numero1 > Numero2 && Numero1 > Numero3 && Numero1 > Numero4 && Numero1 > Numero5 && Numero1 > Numero6 && Numero1 > Numero7 && Numero1 > Numero8 && Numero1 > Numero9 && Numero1 > Numero10)
                {
                    Console.WriteLine(" F) El numero mayor de los numeros es el " + Numero1);
                }
                if (Numero2 > Numero1 && Numero2 > Numero3 && Numero2 > Numero4 && Numero2 > Numero5 && Numero2 > Numero6 && Numero2 > Numero7 && Numero2 > Numero8 && Numero2 > Numero9 && Numero2 > Numero10)
                {
                    Console.WriteLine(" F) El numero mayor de los numeros es el " + Numero2);
                }
                if (Numero3 > Numero1 && Numero3 > Numero2 && Numero3 > Numero4 && Numero3 > Numero5 && Numero3 > Numero6 && Numero3 > Numero7 && Numero3 > Numero8 && Numero3 > Numero9 && Numero3 > Numero10)
                {
                    Console.WriteLine(" F) El numero mayor de los numeros es el " + Numero3);
                }
                if (Numero4 > Numero1 && Numero4 > Numero2 && Numero4 > Numero3 && Numero4 > Numero5 && Numero4 > Numero6 && Numero4 > Numero7 && Numero4 > Numero8 && Numero4 > Numero9 && Numero4 > Numero10)
                {
                    Console.WriteLine(" F) El numero mayor de los numeros es el " + Numero4);
                }
                if (Numero5 > Numero1 && Numero5 > Numero2 && Numero5 > Numero3 && Numero5 > Numero4 && Numero5 > Numero6 && Numero5 > Numero7 && Numero5 > Numero8 && Numero5 > Numero9 && Numero5 > Numero10)
                {
                    Console.WriteLine(" F) El numero mayor de los numeros es el " + Numero5);
                }
                if (Numero6 > Numero1 && Numero6 > Numero2 && Numero6 > Numero3 && Numero6 > Numero4 && Numero6 > Numero5 && Numero6 > Numero7 && Numero6 > Numero8 && Numero6 > Numero9 && Numero6 > Numero10)
                {
                    Console.WriteLine(" F) El numero mayor de los numeros es el " + Numero6);
                }
                if (Numero7 > Numero1 && Numero7 > Numero2 && Numero7 > Numero3 && Numero7 > Numero4 && Numero7 > Numero5 && Numero7 > Numero6 && Numero7 > Numero8 && Numero7 > Numero9 && Numero5 + 7 > Numero10)
                {
                    Console.WriteLine(" F) El numero mayor de los numeros es el " + Numero7);
                }
                if (Numero8 > Numero1 && Numero8 > Numero2 && Numero8 > Numero3 && Numero8 > Numero4 && Numero8 > Numero5 && Numero8 > Numero6 && Numero8 > Numero7 && Numero8 > Numero9 && Numero8 > Numero10)
                {
                    Console.WriteLine(" F) El numero mayor de los numeros es el " + Numero8);
                }
                if (Numero9 > Numero1 && Numero9 > Numero2 && Numero9 > Numero3 && Numero9 > Numero4 && Numero9 > Numero5 && Numero9 > Numero6 && Numero9 > Numero7 && Numero9 > Numero8 && Numero9 > Numero10)
                {
                    Console.WriteLine(" F) El numero mayor de los numeros es el " + Numero9);
                }
                if (Numero10 > Numero1 && Numero10 > Numero2 && Numero10 > Numero3 && Numero10 > Numero4 && Numero10 > Numero5 && Numero10 > Numero6 && Numero10 > Numero7 && Numero10 > Numero8 && Numero10 > Numero9)
                {
                    Console.WriteLine(" F) El numero mayor de los numeros es el " + Numero10);
                }

            }

            public void Numeromenor()
            {
                if (Numero1 < Numero2 && Numero1 < Numero3 && Numero1 < Numero4 && Numero1 < Numero5 && Numero1 < Numero6 && Numero1 < Numero7 && Numero1 < Numero8 && Numero1 < Numero9 && Numero1 < Numero10)
                {
                    Console.WriteLine(" Z) El numero menor de los numeros es el " + Numero1);
                }
                if (Numero2 < Numero1 && Numero2 < Numero3 && Numero2 < Numero4 && Numero2 < Numero5 && Numero2 < Numero6 && Numero2 < Numero7 && Numero2 < Numero8 && Numero2 < Numero9 && Numero2 < Numero10)
                {
                    Console.WriteLine("Z) El numero menor de los nuemros es el " + Numero2);
                }
                if (Numero3 < Numero1 && Numero3 < Numero2 && Numero3 < Numero4 && Numero3 < Numero5 && Numero3 < Numero6 && Numero3 < Numero7 && Numero3 < Numero8 && Numero3 < Numero9 && Numero3 < Numero10)
                {
                    Console.WriteLine(" Z) El numero menor de los numeros es el " + Numero3);
                }
                if (Numero4 < Numero1 && Numero4 < Numero2 && Numero4 < Numero3 && Numero4 < Numero5 && Numero4 < Numero6 && Numero4 < Numero7 && Numero4 < Numero8 && Numero4 < Numero9 && Numero4 < Numero10)
                {
                    Console.WriteLine("Z) El numero menor de los numeros es el " + Numero4);
                }
                if (Numero5 < Numero1 && Numero5 < Numero2 && Numero5 < Numero3 && Numero5 < Numero4 && Numero5 < Numero6 && Numero5 < Numero7 && Numero5 < Numero8 && Numero5 < Numero9 && Numero5 < Numero10)
                {
                    Console.WriteLine("Z) El numero menor de los numeros es el " + Numero5);
                }
                if (Numero6 < Numero1 && Numero6 < Numero2 && Numero6 < Numero3 && Numero6 < Numero4 && Numero6 < Numero5 && Numero6 < Numero7 && Numero6 < Numero8 && Numero6 < Numero9 && Numero6 < Numero10)
                {
                    Console.WriteLine(" Z) El numero menor de los numeros es el " + Numero6);
                }
                if (Numero7 < Numero1 && Numero7 < Numero2 && Numero7 < Numero3 && Numero7 < Numero4 && Numero7 < Numero5 && Numero7 < Numero6 && Numero7 < Numero8 && Numero7 < Numero9 && Numero7 < Numero10)
                {
                    Console.WriteLine(" Z) El numero menor de los numeros es el " + Numero7);
                }
                if (Numero8 < Numero1 && Numero8 < Numero2 && Numero8 < Numero3 && Numero8 < Numero4 && Numero8 < Numero5 && Numero8 < Numero6 && Numero8 < Numero7 && Numero8 < Numero9 && Numero8 < Numero10)
                {
                    Console.WriteLine(" Z) El numero menor de los numeros es el " + Numero8);
                }
                if (Numero9 < Numero1 && Numero9 < Numero2 && Numero9 < Numero3 && Numero9 < Numero4 && Numero9 < Numero5 && Numero9 < Numero6 && Numero9 < Numero7 && Numero9 < Numero8 && Numero9 < Numero10)
                {
                    Console.WriteLine(" Z) El numero menor de los numeros es el " + Numero9);
                }
                if (Numero10 < Numero1 && Numero10 < Numero2 && Numero10 < Numero3 && Numero10 < Numero4 && Numero10 < Numero5 && Numero10 < Numero6 && Numero10 < Numero7 && Numero10 < Numero8 && Numero10 < Numero9)
                {
                    Console.WriteLine(" Z) El numero menor de los numeros es el " + Numero10);
                }

            }




        }



        static void Main(string[] args)
        {
            Numerosenteros ObjNUM = new Numerosenteros();
            ObjNUM.sumar();
            Numerosenteros ObjNUMP = new Numerosenteros();
            ObjNUM.PROMEDIO();
            Numerosenteros ObjNUMM = new Numerosenteros();
            ObjNUM.Numerogrande();
            Numerosenteros ObjNUMMENOR = new Numerosenteros();
            ObjNUM.Numeromenor();
        }
    }
}

}
