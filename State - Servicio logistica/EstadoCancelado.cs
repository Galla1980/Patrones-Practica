using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State___Servicio_logistica
{
    public class EstadoCancelado : IEstadoPaquete
    {
        // El estado cancelado representa al paquete que ha sido cancelado, ya sea desde el estado pendiente, despachado o en tránsito.
        // En este estado, el paquete no puede ser despachado, enviado ni entregado.
        public void Cancelar(Paquete paquete)
        {
            Console.WriteLine("El paquete ya ha sido cancelado.");
        }

        public void Despachar(Paquete paquete)
        {
            Console.WriteLine("El paquete fue cancelado, no puede despacharse.");

        }

        public void Entregar(Paquete paquete)
        {
            Console.WriteLine("El paquete fue cancelado, no puede entregarse.");
        }

        public void Enviar(Paquete paquete)
        {
            Console.WriteLine("El paquete fue cancelado, no puede enviarse.");
        }

        public string ObtenerEstado()
        {
            return "Cancelado";
        }
    }
}
