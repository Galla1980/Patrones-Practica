using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder___CreaCar
{
    internal class Director
    {
        //metodo en el que se define el orden de construccion del objeto y llamo a cada metodo que se encargara de construir el auto, agrego un parametro puertas ya que puede ser de 3 o 5
        //no importa el builder que le pasemos siempre va a crear un auto ya que usa la interfaz implementada por cada builder
        public void Construir(IBuilder builder, int puertas)
        {
            builder.Reset();//reseteo el auto interno que tiene el builder
            builder.ConfigurarMarca();
            builder.ArmarModelo();
            builder.InstalarMotor();
            builder.AgregarPuertas(puertas);
        }
    }
}
