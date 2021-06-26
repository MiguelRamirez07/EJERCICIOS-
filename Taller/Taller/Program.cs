using System;

namespace Taller
{
    class Automovil
    {
        string placas, dueño, respuesta, respuestas;
        int capadidadTaller, vacio;
        double tarifa, tarifaTotal;
        string[] PlacaAuto;
        string[] NombreDueño;
        double[] Cobro;
        public double Tarifa
        {
            get { return tarifa; }
            set { tarifa = value; }
        }
        public double TarifaTotal
        {
            get { return tarifaTotal; }
            set { tarifaTotal = value; }
        }
        public string Dueño
        {
            get { return dueño; }
            set { dueño = value; }
        }
        public string Placas
        {
            get { return placas; }
            set { placas = value; }
        }
        public string Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; }
        }
        public string RespuestaS
        {
            get { return respuestas; }
            set { respuestas = value; }
        }
        public int CapacidadTaller
        {
            get { return capadidadTaller; }
            set { capadidadTaller = value; }
        }
        public int Vacio
        {
            get { return vacio; }
            set { vacio = value; }
        }
        public void Entrada()
        {
            Console.WriteLine("El taller mecanico");
            Console.WriteLine("aqui capturaremos y se almacena, muestra los autos que se atienden del taller");

            for (int i = 0; i < 5; i++)
            {
                tarifaTotal = -1;
                Console.WriteLine("---------------------------------------------------------");
                Console.Write("Introudce las placas: ");
                Placas = Console.ReadLine().ToString();
                Console.Write("Dueño / propietario: ");
                Dueño = Console.ReadLine().ToString();
                Console.Write("Tarifa a cobrar por la reparación: " + "$");
                Tarifa = double.Parse(Console.ReadLine());
                TarifaTotal = TarifaTotal + Tarifa;
                CapacidadTaller += 1;
                Vacio += 1;

            }
        }
        public void Salida()
        {
            Console.WriteLine("Capacidad taller: " + CapacidadTaller);
            Console.WriteLine("El taller esta en su capacidad máxima. Espere por favor...");

            do
            {
                Console.Write("¿Salio un auto del taller? ");
                Respuesta = Console.ReadLine().ToLower();
                if (Respuesta == "si")
                {

                    Vacio -= 1;
                    TarifaTotal += Tarifa;
                    Console.Write("¿Ingresar el nuevo auto al taller? ");
                    Respuesta = Console.ReadLine().ToLower();
                    if (Respuesta == "si")
                    {
                        Console.WriteLine("---------------------------------------------------------");
                        Console.Write("Introduce las placas: ");
                        Placas = Console.ReadLine().ToString();
                        Console.Write("Dueño y propietario: ");
                        Dueño = Console.ReadLine().ToString();
                        Console.Write("precio a pagar por la reparación: " + "$");
                        Tarifa = double.Parse(Console.ReadLine());
                        CapacidadTaller = CapacidadTaller + 1;
                        Vacio = Vacio + 1;
                        Console.WriteLine("----------" + CapacidadTaller);
                        Console.WriteLine("----------" + Vacio);
                    }
                    else
                    {

                        Console.WriteLine(" esperando...");
                        Console.ReadLine();
                    }


                }
                else
                {

                    Console.WriteLine("Siga esperando...");
                    Console.ReadLine();
                }

            } while (Vacio > 0);


        }
        public void MeterAuto()
        {
            Console.WriteLine("Total de los autos atendidos en el dia: " + CapacidadTaller);
            PlacaAuto = new string[CapacidadTaller];
            NombreDueño = new string[CapacidadTaller];
            Cobro = new double[CapacidadTaller];
            for (int i = 0; i < CapacidadTaller; i++)
            {
                PlacaAuto[i] = Placas;
                NombreDueño[i] = Dueño;
                Cobro[i] = Tarifa;
            }
            Console.WriteLine("se gano al final del día: " + "$" + TarifaTotal);

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Automovil taller = new Automovil();

            taller.Entrada();
            taller.Salida();
            taller.MeterAuto();

        }


    }
}

