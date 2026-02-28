using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder___CreaCar
{
    //builder seteado para crear un ford fiesta
    internal class FordFiestaBuilder : IBuilder
    {
        private Auto _auto;

        public FordFiestaBuilder() 
        {
            Reset();
        }
        public void AgregarPuertas(int puertas)
        {
            _auto.AgregarPuertas(puertas);
        }

        public void ArmarModelo()
        {
            _auto.ArmarModelo("Fiesta");
        }

        public void ConfigurarMarca()
        {
            _auto.ConfigurarMarca("Ford");
        }

        public Auto GetAuto()
        {
            return _auto;
        }

        public void InstalarMotor()
        {
            _auto.InstalarMotor(new Motor("1.6", 120));
        }

        public void Reset()
        {
            _auto = new Auto();
        }
    }
}
