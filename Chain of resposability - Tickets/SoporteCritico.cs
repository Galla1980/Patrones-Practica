using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_resposability___Tickets
{
    internal class SoporteCritico : Handler
    {
        public override void AtenderTicket(Ticket ticket)//El nivel mas alto de soporte, si obtiene criticidad mayor a 3 el problema no tiene solucion
        {
            if(ticket.NivelCriticidad > 3)
            {
                Console.WriteLine($"El ticket con ID {ticket.ID} de criticidad {ticket.NivelCriticidad}, ha sido atendido por el soporte crítico. Pero este no tiene solución.");
                ticket.CambiarEstado(Estado.SinSolucion);
            }
            else//Si el nivel de criticidad es menor o igual a 3, el problema se soluciona
            {
                Console.WriteLine($"El ticket con ID {ticket.ID} ha sido atendido por el soporte crítico. El problema ha sido solucionado.");
                ticket.CambiarEstado(Estado.Solucionado);
            }
        }
    }
}
