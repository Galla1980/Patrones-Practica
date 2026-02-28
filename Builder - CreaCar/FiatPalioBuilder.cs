using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder___CreaCar
{
    //constructor con los atributos de fiat palio
    internal class FiatPalioBuilder : IBuilder
    {
        private Auto _auto;

        public FiatPalioBuilder() 
        {
            Reset();
        }
        public void AgregarPuertas(int puertas)
        {
            _auto.AgregarPuertas(puertas);
        }

        public void ArmarModelo()
        {
            _auto.ArmarModelo("Palio");
        }

        public void ConfigurarMarca()
        {
            _auto.ConfigurarMarca("Fiat");
        }

        public Auto GetAuto()
        {
            return _auto;
        }

        public void InstalarMotor()
        {
            _auto.InstalarMotor(new Motor("1.4", 90));
        }

        public void Reset()
        {
            _auto = new Auto();
        }
    }
}
