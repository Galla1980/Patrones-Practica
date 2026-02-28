using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder___CreaCar
{
    internal class Motor
    {
        public string Numero { get; set; }
        public int  Potencia { get; set; }

        public Motor(string numero, int potencia) 
        {
            Numero = numero;
            Potencia = potencia;
        }
    }
}
