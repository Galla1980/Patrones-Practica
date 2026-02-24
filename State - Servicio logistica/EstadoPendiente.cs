using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State___Servicio_logistica
{
    // El estado pendiente representa al paquete apenas es creado, antes de ser despachado. En este estado, el paquete no puede ser enviado ni entregado,
    // pero sí puede ser cancelado o despachado.
    public class EstadoPendiente : IEstadoPaquete 
    {
        public void Cancelar(Paquete paquete)
        {
            paquete.CambiarEstado(new EstadoCancelado());
            Console.WriteLine("El paquete fue cancelado.");
        }

        public void Despachar(Paquete paquete)
        {
            paquete.CambiarEstado(new EstadoDespachado());
            Console.WriteLine("El paquete fue despachado.");
        }

        public void Enviar(Paquete paquete)
        {
            Console.WriteLine("El paquete no puede enviarse porque todavia no fue despachado.");
        }
        public void Entregar(Paquete paquete)
        {
            Console.WriteLine("El paquete no puede entregarse porque se encuentra pendiente de despacho.");
        }

        public string ObtenerEstado()
        {
            return "Pendiente de despacho";
        }
    }
}
