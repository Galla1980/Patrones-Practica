using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy___Ventas
{
    internal interface IMetodoPago // La interfaz metodo de pago sera implementada por cada metodo de pago, y cada metodo de pago tendra su propia implementacion del metodo pagar
    {
        bool Pagar(double total); // El metodo pagar recibira el monto a pagar y devolvera un booleano indicando si el pago fue exitoso o no
    }
}
