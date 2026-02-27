using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_resposability___Tickets
{
    internal class SoporteIntermedio : Handler
    {
        public override void AtenderTicket(Ticket ticket)//El soporte intermedio atiende los tickets delegados del soporte basico.
        {
            if (ticket.NivelCriticidad <= 2)
            {
                Console.WriteLine($"El ticket ID: {ticket.ID} de criticidad {ticket.NivelCriticidad}, ha sido atendido por el soporte intermedio. El problema ha sido solucionado.");
                ticket.CambiarEstado(Estado.Solucionado);
            }
            else
            {
                Console.WriteLine($"Ticket {ticket.ID} de criticidad {ticket.NivelCriticidad } no puede ser atendido por Soporte Intermedio, delegando al siguiente nivel...");
                _SiguienteHandler?.AtenderTicket(ticket);// Si no puede solucionarlo se delega al soporte critico
            }
        }
    }
}
