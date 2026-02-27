using System;
using System.Collections.Generic;
using System.Linq;

namespace Chain_of_resposability___Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creo los handlers 
            List<Ticket> tickets = new List<Ticket>();
            Handler soporteBasico = new SoporteBasico();
            Handler soporteIntermedio = new SoporteIntermedio();
            Handler soporteCritico = new SoporteCritico();
            soporteBasico.SetSiguienteHandler(soporteIntermedio);
            soporteIntermedio.SetSiguienteHandler(soporteCritico);

            string opcion = string.Empty;
            while (opcion != "4")
            {
                Console.WriteLine("1.- Crear ticket");
                Console.WriteLine("2.- Ver tickets");
                Console.WriteLine("3.- Atender tickets");
                Console.WriteLine("4.- Salir");
                Console.Write("Ingrese una opcion: ");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        CrearTicket(tickets);
                        break;
                    case "2":
                        if (tickets.Count == 0)
                        {
                            Console.WriteLine("No hay tickets para mostrar...");
                            break;
                        }
                        VerTickets(tickets);
                        break;
                    case "3":
                        if (tickets.Count == 0)
                        {
                            Console.WriteLine("No hay tickets para atender...");
                            break;
                        }
                        AtenderTickets(tickets,soporteBasico);
                        break;
                    case "4":
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static void AtenderTickets(List<Ticket> tickets, Handler soporteBasico)
        {
            VerTickets(tickets);
            int idTicket;
            Ticket ticket;
            while (true) 
            {
                Console.WriteLine("Ingrese el ID del ticket a atender: ");
                if (!int.TryParse(Console.ReadLine(), out idTicket))
                {
                    Console.WriteLine("El ID del ticket debe ser un numero entero...");
                    continue;
                }
                ticket = tickets.FirstOrDefault(t => t.ID == idTicket);
                if (ticket == null)
                {
                    Console.WriteLine("El ID del ticket no existe...");
                    continue;
                }
                break;
            }
            if(ticket.Estado != Estado.SinAtender )
            {
                Console.WriteLine("El ticket ya ha sido atendido...");
                return;
            }
            soporteBasico.AtenderTicket(ticket);

        }

        private static void VerTickets(List<Ticket> tickets)
        {

            
            foreach (var ticket in tickets)
            {
                Console.WriteLine(ticket.ToString());
            }

        }

        public static void CrearTicket(List<Ticket> listaTickets)
        {
            string descripcion;
            while (true)
            {
                Console.Write("Ingrese la descripcion del problema: ");
                descripcion = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(descripcion))
                {
                    break;
                }
                Console.WriteLine("La descripcion del problema no puede estar vacia...");
            }
            int criticidad;
            while (true)
            {
                Console.Write("Ingrese el nivel de criticidad (1-5): ");
                if (!int.TryParse(Console.ReadLine(), out  criticidad)) {
                    Console.WriteLine("El nivel de criticidad debe ser un numero entero...");
                    continue;
                }
                if (criticidad < 1 || criticidad > 5)
                {
                    Console.WriteLine("El nivel de criticidad debe estar entre 1 y 5");
                    continue;
                }
                break;
            }
                
            Ticket ticket = new Ticket(listaTickets.Count + 1, descripcion, criticidad);
            Console.WriteLine("Ticket creado con exito...");
            Console.WriteLine(ticket.ToString());
            listaTickets.Add(ticket);
        }
    }
}
