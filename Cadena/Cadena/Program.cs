using System;

namespace Cadena
{
        class cadena
        {
            string Cadena;
            public void nombre()
            {
                Console.WriteLine("introducir una palabra");
                Cadena = Convert.ToString(Console.ReadLine());
                char[] cArray = Cadena.ToCharArray();
                string Reverse = String.Empty;
                for (int i = cArray.Length - 1; i > -1; i--)
                {
                    Reverse += cArray[i];
                }
                Console.WriteLine(" alreves seria :" + Reverse);
                Console.ReadKey();
            }

            public void Mayus()
            {
                Console.WriteLine("la cadena en  mayusculas seria: {0}", Cadena.ToUpper());
                Console.ReadKey();
                Console.WriteLine("la cadena cambiada seria: {0}", Cadena.Replace("a", "4").Replace("i", "1").Replace("s", "5").Replace("b", "8").Replace("e", "3").Replace("t", "7"));
            }



            static void Main(string[] args)
            {
                cadena objcade = new cadena();
                objcade.nombre();
                cadena objcadesa = new cadena();
                objcade.Mayus();
            }
        }

}
