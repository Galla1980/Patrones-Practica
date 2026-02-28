using System;
using System.Collections.Generic;

namespace Proxy___Streaming_peliculas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pelicula> peliculas = new List<Pelicula>();//Cargo peliculas por defecto
            peliculas.AddRange(new Pelicula[] { new Pelicula("Matrix", "2:16"), new Pelicula("Volver al futuro", "1:56"), new Pelicula("Avatar", "2:42") });

            string opcion = string.Empty;
            while (true)
            {
                Console.WriteLine($"Estado cuenta: {(Session.EstaLogueado ? "Logueado" : "Sin loguear")} Suscripcion: {(Session.TieneSuscripcion ? "Suscrito" : "No suscrito")}");
                Console.WriteLine("1.- Logguear/Desloguear");
                Console.WriteLine("2.- Activar/Desactivar Suscripcion");
                Console.WriteLine("3.- Reproducir pelicula con proxy");
                Console.WriteLine("4.- Reproducir pelicula sin proxy");
                Console.Write("Seleccione su opcion: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        if (Session.EstaLogueado)
                        {
                            Console.WriteLine("Cerrando la sesion");
                            Session.EstaLogueado = false;
                        }
                        else
                        {
                            Console.WriteLine("Iniciando sesion");
                            Session.EstaLogueado = true;
                        }
                        break;
                    case "2":
                        // Invertimos el estado de la suscripción
                        Session.TieneSuscripcion = !Session.TieneSuscripcion;                        
                        break;
                    case "3":
                        VerPeliculas(peliculas, new Proxy());
                        break;
                    case "4":
                        VerPeliculas(peliculas, new ReproductorReal());
                        break;
                }
                Console.WriteLine("Pulse enter para continuar");
                Console.ReadLine();
                Console.Clear();
            }
        }
        //metodo para evitar repetir codigo en el caso de que el usuario elija con o sin proxy. tambien para mostrar que el cliente cree que esta usando un reproductor a pesar de tener un proxy.
        public static void VerPeliculas(List<Pelicula> peliculas, IReproductor reproductor)
        {
            
            int idPelicula = 0;
            while (true)
            {
                int i = 1;
                foreach (Pelicula p in peliculas)
                {
                    Console.WriteLine($"{i}.- {p.Titulo} Duracion: {p.Duracion}");
                    i++;
                }
                Console.WriteLine("Ingrese el numero de pelicula que desea ver: ");
                if (!int.TryParse(Console.ReadLine(), out idPelicula))//si el usuario ingreso un caracter no numerico le informamos que solo se admiten numeros
                {
                    Console.WriteLine("Debe ingresar un numero entero.");
                    continue;
                }
                if(idPelicula > peliculas.Count || idPelicula<= 0)//si el usuario ingresa un id incorrecto solicitamos que lo intente de nuevo
                {
                    Console.WriteLine("El id no corresponde a ninguna pelicula. Intentelo nuevamente.");
                    continue;
                }
                break;
            }
            reproductor.Reproducir(peliculas[idPelicula - 1]);
        }
    }
}
