using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State___Servicio_logistica
{
    public class EstadoDespachado : IEstadoPaquete
    {
        // El estado despachado representa al paquete que ha sido despachado, pero aún no ha sido enviado.
        // En este estado, el paquete no puede ser cancelado ni entregado,
        public void Cancelar(Paquete paquete)
        {
            paquete.CambiarEstado(new EstadoCancelado());
            Console.WriteLine("El paquete fue cancelado.");
        }

        public void Despachar(Paquete paquete)
        {
            Console.WriteLine("El paquete ya fue despachado.");
        }

        public void Entregar(Paquete paquete)
        {
            Console.WriteLine("El paquete no puede entregarse todavia porque no fue enviado.");
        }

        public void Enviar(Paquete paquete)
        {
            paquete.CambiarEstado(new EstadoEnTransito());
            Console.WriteLine("El paquete fue enviado y se encuentra en transito.");
        }

        public string ObtenerEstado()
        {
            return "Despachado";
        }
    }
}
