using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State___Servicio_logistica
{
    public class EstadoEntregado : IEstadoPaquete
    {
        // En este estado, el paquete ya ha sido entregado, por lo que no se pueden realizar acciones adicionales.
        public void Cancelar(Paquete paquete)
        {
            Console.WriteLine("No se puede cancelar un paquete que ya ha sido entregado.");
        }

        public void Despachar(Paquete paquete)
        {
            Console.WriteLine("No se puede despachar un paquete que ya ha sido entregado.");
        }

        public void Entregar(Paquete paquete)
        {
            Console.WriteLine("El paquete ya fue entregado.");
        }

        public void Enviar(Paquete paquete)
        {
            Console.WriteLine("No se puede enviar un paquete que ya ha sido entregado.");
        }

        public string ObtenerEstado()
        {
            return "Entregado";
        }
    }
}
