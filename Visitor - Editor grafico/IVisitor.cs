using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor___Editor_grafico
{
    internal interface IVisitor//Interfaz de visitante que define un metodo sobrecargado con los distintos elementos que pueden aceptar la visita
    {
        void Visitar(Circulo circulo);//Cuando quiera crear un visitante implemento cada uno segun el elemento que recibe.
        void Visitar(Rectangulo rectangulo);
        void Visitar(Triangulo triangulo);
    }
}
