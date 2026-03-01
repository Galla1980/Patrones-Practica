using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor___Editor_grafico
{
    internal class VisitorCalcularPerimetro : IVisitor //implemento la interfaz visitor que me trae el metodo visitar con las distintas firmas por cada elemento.
    {
        //En cada una defino lo que deberia hacer mi visitante con ese elemento, como en este caso calculo el perimetro voy a calcular el perimetro de las distintas figuras, en todas es distinto
        public void Visitar(Circulo circulo)
        {
            double perimetro = 2 * Math.PI * circulo.Radio;
            Console.WriteLine($"El perimetro del circulo es de: {perimetro}.");
        }

        public void Visitar(Rectangulo rectangulo)
        {
            double perimetro = (rectangulo.Altura + rectangulo.Base) * 2;
            Console.WriteLine($"El perimetro del rectangulo es de: {perimetro}.");
        }

        public void Visitar(Triangulo triangulo)
        {
            //calcular perimetro de un triangulo
            double perimetro = triangulo.Base + triangulo.Altura + Math.Sqrt(Math.Pow(triangulo.Base, 2) + Math.Pow(triangulo.Altura, 2));
            Console.WriteLine("El perimetro del triangulo rectangulo es de: {0}.", perimetro);
        }

        public override string ToString()
        {
            return "Calcular Perimetro";
        }
    }
}
