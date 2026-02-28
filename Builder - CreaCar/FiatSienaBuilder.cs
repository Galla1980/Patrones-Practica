using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder___CreaCar
{
    //Builder seteado para crear un fiat siena
    internal class FiatSienaBuilder : IBuilder
    {
        private Auto _auto;

        public FiatSienaBuilder() 
        {
            Reset();
        }
        public void AgregarPuertas(int puertas)
        {
            _auto.AgregarPuertas(puertas);
        }

        public void ArmarModelo()
        {
            _auto.ArmarModelo("Siena");
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
            _auto.InstalarMotor(new Motor("1.6", 110));
        }

        public void Reset()
        {
            _auto = new Auto();
        }
    }
}
