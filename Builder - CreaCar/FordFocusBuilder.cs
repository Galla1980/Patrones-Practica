using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder___CreaCar
{
    //builder seteado para crear un ford focus
    internal class FordFocusBuilder : IBuilder
    {
        private Auto _auto;
        public FordFocusBuilder() 
        {
            Reset();
        }
        public void AgregarPuertas(int puertas)
        {
            _auto.AgregarPuertas(puertas);
        }

        public void ArmarModelo()
        {
            _auto.ArmarModelo("Focus");
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
            _auto.InstalarMotor(new Motor("2.0", 150));
        }

        public void Reset()
        {
            _auto = new Auto(); 
        }
    }
}
