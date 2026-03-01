using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor___Editor_grafico
{
    //Cada visitor lo uso para implementar funcionalidades sin afectar a los elementos.
    internal class VisitorCalcularArea : IVisitor
    {
        public void Visitar(Circulo circulo)
        {
            double area = Math.PI * Math.Pow(circulo.Radio, 2);
            Console.WriteLine($"El area del circulo es { area }");
        }

        public void Visitar(Rectangulo rectangulo)
        {
            double area = rectangulo.Base * rectangulo.Altura;
            Console.WriteLine($"El area del rectangulo es {area}");
        }

        public void Visitar(Triangulo triangulo)
        {
            double area = (triangulo.Base * triangulo.Altura)/2;
            Console.WriteLine($"El area del triangulo es {area}");
        }

        public override string ToString()
        {
            return "Calcular Area";
        }
    }
}
