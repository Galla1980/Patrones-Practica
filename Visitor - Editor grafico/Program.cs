using System;

namespace Visitor___Editor_grafico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcionFigura = string.Empty;
            IFigura figura = null;
            //menu de figura
            while (opcionFigura != "4")
            {
                Console.WriteLine("1. Circulo");
                Console.WriteLine("2. Rectangulo");
                Console.WriteLine("3. Triangulo rectangulo");
                Console.WriteLine("4. Salir");
                Console.Write("Elija su figura: ");
                opcionFigura = Console.ReadLine();

                
                switch (opcionFigura)
                {
                    case "1":
                        double radio = LeerDouble("Ingrese el radio del circulo: ");
                        figura = new Circulo(radio);
                        break;
                    case "2":
                        double baseRec = LeerDouble("Ingrese la base del rectangulo:  ");
                        double alturaRec = LeerDouble("Ingrese la altura del rectangulo: ");
                        figura = new Rectangulo(baseRec, alturaRec);
                        break;
                    case "3":
                        double baseTri = LeerDouble("Ingrese la base del triangulo rectangulo: ");
                        double alturaTri = LeerDouble("Ingrese la altura del triangulo rectangulo: ");
                        figura = new Triangulo(baseTri, alturaTri);
                        break;
                    case "4":
                        Console.WriteLine("Saliendo...");
                        Console.WriteLine("Presione enter para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    default:
                        Console.WriteLine("Opcion no valida");
                        continue;
                }
                Console.Clear();
                //Menu de operaciones
                string opcionVisitor = string.Empty;
                IVisitor visitor = null;
                while (opcionVisitor != "4")
                {
                    Console.WriteLine($"Figura elegida: {figura.ToString()}");
                    Console.WriteLine("1.- Calcular area");
                    Console.WriteLine("2.- Calcular Perimetro");
                    Console.WriteLine("3.- Exportar a XML");
                    Console.WriteLine("4.- Volver al menu anterior");
                    Console.WriteLine("Ingrese una opcion: ");
                    opcionVisitor = Console.ReadLine();
                    switch (opcionVisitor) 
                    {
                        case "1":
                            visitor = new VisitorCalcularArea();
                            figura.Aceptar(visitor);
                            break;
                        case "2":
                            visitor = new VisitorCalcularPerimetro();
                            figura.Aceptar(visitor);
                            break;
                        case "3":
                            visitor = new VisitorExportarXML();
                            figura.Aceptar(visitor);
                            break;
                        case "4":
                            Console.Clear();
                            continue;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
        static double LeerDouble(string mensaje)
        {
            double numero = 0;
            while (true)
            {
                Console.WriteLine(mensaje);
                if(!double.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Debe ingresar un numero decimal.");
                    continue;
                }
                if(numero <= 0)
                {
                    Console.WriteLine("El numero debe ser mayor a 0.");
                }
                break;
            }
            return numero;
        }
    }
}
