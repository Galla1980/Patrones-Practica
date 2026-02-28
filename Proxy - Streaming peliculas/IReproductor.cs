using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy___Streaming_peliculas
{
    internal interface IReproductor//Interfaz comun entre el reproductor real y el proxy con el metodo para ver la pelicula
    {
        void Reproducir(Pelicula pelicula);
    }
}
