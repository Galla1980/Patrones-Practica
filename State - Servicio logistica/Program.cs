using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State___Servicio_logistica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Paquete> paquetes = new List<Paquete>(); //lista de paquetes para almacenar los paquetes creados durante la ejecución del programa
            string opcion = string.Empty;
            while (opcion != "0")
            {
                try
                {
                    Console.WriteLine("1.- Crear paquete");
                    Console.WriteLine("2.- Seleccionar paquete");
                    Console.WriteLine("0.- Salir");
                    Console.WriteLine("Seleccione su opcion: ");
                    opcion = Console.ReadLine();
                    switch (opcion)
                    {

                        case "1":
                            Console.WriteLine("Ingrese el nombre del destinatario: ");
                            string nombreDes = Console.ReadLine();//verifico que el nombre del destinatario no esté vacío o solo contenga espacios en blanco
                            if (string.IsNullOrWhiteSpace(nombreDes))
                            {
                                throw new Exception("El nombre del destinatario no puede estar vacío.");
                            }
                            Paquete nuevoPaquete = new Paquete(paquetes.Count() + 1, nombreDes);// creo un nuevo paquete con un ID único basado en la cantidad de paquetes existentes + 1 simulando un auto incremental
                            paquetes.Add(nuevoPaquete);
                            Console.WriteLine("Paquete creado exitosamente.");
                            break;
                        case "2":
                            if (paquetes.Count == 0) //verifico que haya paquetes para seleccionar y evitar un error al intentar mostrar una lista vacía
                            {
                                throw new Exception("No hay paquetes disponibles. Por favor, cree un paquete primero.");
                            }
                            foreach (var p in paquetes)// muestro paquetes disponibles para seleccionar
                            {
                                Console.WriteLine(p.ToString());
                            }
                            Console.WriteLine("Ingrese el ID del paquete que desea seleccionar: ");
                            if (!int.TryParse(Console.ReadLine(), out int idSeleccionado)) //verifico que el ID ingresado sea un número válido
                            {
                                throw new Exception("ID inválido. Por favor, ingrese un número.");
                            }
                            Paquete paquete = paquetes.FirstOrDefault(p => p.Id == idSeleccionado);// busco el paquete con el ID ingresado
                            if (paquete == null) //verifico que el paquete seleccionado exista
                            {
                                throw new Exception("Paquete no encontrado. Por favor, ingrese un ID válido.");
                            }
                            string opcion2 = string.Empty;
                            while (opcion2 != "0")// segundo menu con las opciones del paquete seleccionado
                            {
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine($"Paquete seleccionado: {paquete.ToString()}");
                                    Console.WriteLine("1.- Despachar");
                                    Console.WriteLine("2.- Enviar");
                                    Console.WriteLine("3.- Entregar");
                                    Console.WriteLine("4.- Cancelar");
                                    Console.WriteLine("0.- Volver al menú principal");
                                    Console.WriteLine("Seleccione su opcion: ");
                                    opcion2 = Console.ReadLine();
                                    // ejecuto la acción correspondiente según la opción seleccionada para el paquete, la logica de cada accion se encuentra en el estado
                                    switch (opcion2) 
                                    {
                                        case "1":
                                            paquete.Despachar();
                                            break;
                                        case "2":
                                            paquete.Enviar();
                                            
                                            break;
                                        case "3":
                                            paquete.Entregar();
                                            break;
                                        case "4":
                                            paquete.Cancelar();
                                            break;
                                        case "0":
                                            Console.WriteLine("Volviendo al menú principal...");
                                            continue;
                                        default:
                                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
                                            break;
                                    }
                                    Console.WriteLine("Presione cualquier tecla para continuar...");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Error: {ex.Message}");
                                }
                            }
                            break;
                        case "0":
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción del menú.");
                            break;
                    }
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
