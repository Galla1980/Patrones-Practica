using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor___Editor_grafico
{
    internal class VisitorExportarXML : IVisitor//Para exportar a XML, cada figura se exporta de una forma distinta, por eso defino el metodo visitar con distintas firmas para cada figura.
    {
        public void Visitar(Circulo circulo)
        {
            Console.WriteLine($"<Circulo><Radio>{circulo.Radio}</Radio></Circulo>");//Imprime el circulo en formato XML, con su radio dentro de la etiqueta <Circulo>.
        }

        public void Visitar(Rectangulo rectangulo)
        {
            Console.WriteLine($"<Rectangulo><Base>{rectangulo.Base}</Base><Altura>{rectangulo.Altura}</Altura></Rectangulo>");
        }

        public void Visitar(Triangulo triangulo)
        {
            Console.WriteLine($"<Triangulo><Base>{triangulo.Base}</Base><Altura>{triangulo.Altura}</Altura></Triangulo>");
        }

        public override string ToString()
        {
            return "Exportar XML";
        }
    }
}
