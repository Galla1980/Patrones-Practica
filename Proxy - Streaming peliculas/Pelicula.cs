using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy___Streaming_peliculas
{
    internal class Pelicula
    {
        public string Titulo { get; set; }
        public string Duracion { get; set; }

        public Pelicula(string titulo, string duracion) 
        {
            Titulo = titulo;
            Duracion = duracion;
        }
    }
}
