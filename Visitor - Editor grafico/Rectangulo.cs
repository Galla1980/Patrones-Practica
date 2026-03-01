using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor___Editor_grafico
{
    internal class Rectangulo : IFigura
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public Rectangulo(double pBase, double pAltura) 
        { 
            Base = pBase;
            Altura = pAltura;
        }
        public void Aceptar(IVisitor visitante)
        {
            Console.WriteLine($"El rectangulo acepta la visita del visitante: {visitante.ToString()}");
            visitante.Visitar(this);
        }
        public override string ToString()
        {
            return $"Rectangulo con base = {Base} y altura = {Altura}";
        }
    }
}
