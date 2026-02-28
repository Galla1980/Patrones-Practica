using System;
using System.Collections.Generic;

namespace Proxy___Streaming_peliculas
{
    internal class Proxy : IReproductor
    {
        private ReproductorReal _reproductor;
        public Proxy()
        {
        }

        public void Reproducir(Pelicula pelicula)//Metodo en comun con el reproductor, el cliente conoce la misma interfaz y no sabe que esta usando un proxy con pasos adicionales
        {
            if (!Session.EstaLogueado)//Comprobaciones de seguridad
            {
                Console.WriteLine("Debe estar logueado para ver la pelicula");
                return;
            }
            if (!Session.TieneSuscripcion)
            {
                Console.WriteLine("Debe tener una suscripcion activa para ver la pelicula.");
                return;
            }
            if (_reproductor == null) _reproductor = new ReproductorReal();//Una vez se que puede ver la pelicula creo el objeto real 
            _reproductor.Reproducir(pelicula);
            _reproductor = null;
        }
    }
}
