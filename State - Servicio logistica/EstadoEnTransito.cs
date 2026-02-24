using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State___Servicio_logistica
{
    public class EstadoEnTransito : IEstadoPaquete
    {
        // El estado en tránsito representa al paquete que ha sido enviado y se encuentra en tránsito hacia su destino.

        public void Cancelar(Paquete paquete)
        {
            paquete.CambiarEstado(new EstadoCancelado());
            Console.WriteLine("El paquete fue cancelado.");
        }

        public void Despachar(Paquete paquete)
        {
            Console.WriteLine("El paquete ya ha sido despachado y se encuentra en tránsito.");
            
        }

        public void Entregar(Paquete paquete)
        {
            paquete.CambiarEstado(new EstadoEntregado());
            Console.WriteLine("El paquete fue entregado.");
        }

        public void Enviar(Paquete paquete)
        {
            Console.WriteLine("El paquete ya ha sido enviado y se encuentra en tránsito.");
        }

        public string ObtenerEstado()
        {
            return "En transito";
        }
    }
}
