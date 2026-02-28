using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy___Streaming_peliculas
{
    internal class ReproductorReal : IReproductor
    {
        public ReproductorReal() 
        {
            Console.WriteLine("Cargando reproductor...");
        }


        public void Reproducir(Pelicula pelicula)
        {
            Console.WriteLine($"Reproduciendo {pelicula.Titulo} duracion: {pelicula.Duracion}");
            Console.WriteLine("Pulse enter para cerrar el reproductor");
            Console.ReadLine();
        }
    }
}
