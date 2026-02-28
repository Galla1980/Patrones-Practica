using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder___CreaCar
{
    internal interface IBuilder//interfaz con los metodos necesarios por cada builder para crear un auto
    {
        void Reset();
        void ConfigurarMarca();
        void ArmarModelo();
        void InstalarMotor();
        void AgregarPuertas(int puertas);
        Auto GetAuto();
    }
}
