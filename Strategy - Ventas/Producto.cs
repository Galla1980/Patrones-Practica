using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Strategy___Ventas
{
    internal class Producto
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public double Precio { get; set; }

        public Producto() { }
        public Producto(int codigo, string nombre, double precio) 
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"Codigo: {Codigo}, Nombre: {Nombre}, Precio: {Precio}";
        }
    }
}
