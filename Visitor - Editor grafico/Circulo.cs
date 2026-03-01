using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor___Editor_grafico
{
    internal class Circulo : IFigura
    {
        public double Radio { get; set; }
        public Circulo(double radio)
        {
            Radio = radio;
        }

        public void Aceptar(IVisitor visitante)
        {
            Console.WriteLine($"El circulo acepta la visita del visitante: {visitante.ToString()}");
            visitante.Visitar(this);
        }

        public override string ToString()
        {
            return $"Circulo con radio = {Radio}";
        }
    }
}
