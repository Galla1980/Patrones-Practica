using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor___Editor_grafico
{
    internal class Triangulo : IFigura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public Triangulo(double pBase, double pAltura) 
        {
            Base = pBase;
            Altura = pAltura;
        }

        public void Aceptar(IVisitor visitante)
        {
            Console.WriteLine($"El triangulo acepta la visita del visitante: {visitante.ToString()}");
            visitante.Visitar(this);
        }

        public override string ToString()
        {
            return $"Triangulo rectangulo con base = {Base} y altura = {Altura}";
        }
    }
}
