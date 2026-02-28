using System;
using System.Security.AccessControl;

namespace Builder___CreaCar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            IBuilder builder;
            string opcion = string.Empty;
            while (true)
            {
                //Primero el usuario decide que marca y modelo quiere.
                Console.WriteLine("1.- Ford Fiesta");
                Console.WriteLine("2.- Ford Focus");
                Console.WriteLine("3.- Fiat Palio");
                Console.WriteLine("4.- Fiat Siena");
                Console.WriteLine("5.- Salir");
                Console.Write("Seleccione su opcion: ");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        builder = new FordFiestaBuilder();
                        break;
                    case "2":
                        builder = new FordFocusBuilder();
                        break;
                    case "3":
                        builder = new FiatPalioBuilder();
                        break;
                    case "4":
                        builder = new FiatSienaBuilder();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Ingrese una opcion valida.");
                        Console.WriteLine("Enter para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                }
                int cantPuertas;
                while (true)
                {
                    //luego elige que version quiere 3 o 5 puertas
                    Console.WriteLine("Ingrese la cantidad de puertas (3 o 5)");
                    if(!int.TryParse(Console.ReadLine(), out cantPuertas))
                    {
                        Console.WriteLine("Debe ingresar un numero entero");
                        continue;
                    }
                    if(cantPuertas != 3 && cantPuertas != 5)
                    {
                        Console.WriteLine("La cantidad de puertas debe ser 3 o 5");
                        continue;
                    }
                    break;
                }
                //Llamo al director para que construya el auto
                director.Construir(builder, cantPuertas);
                //Una vez se construye el auto en el builder lo obtengo
                Auto autoArmado = builder.GetAuto();
                //muestro el auto por consola
                Console.WriteLine("");
                Console.WriteLine("Auto armado con exito!!!!");
                Console.WriteLine(autoArmado.ToString());
                Console.WriteLine("");
                Console.WriteLine("Presione enter para continuar");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
