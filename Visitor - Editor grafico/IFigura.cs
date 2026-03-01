using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor___Editor_grafico
{
    internal interface IFigura//Interfaz de elemento que define el metodo aceptar, el cual recibe un visitante como parametro para permitir que este opere con el.
    {
        void Aceptar(IVisitor visitante);
    }
}
