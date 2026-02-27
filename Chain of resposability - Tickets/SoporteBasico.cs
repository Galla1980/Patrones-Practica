using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_resposability___Tickets
{
    internal class SoporteBasico : Handler
    {
        public override void AtenderTicket(Ticket ticket)//Este sera el primer nivel de soporte, por lo que se encargara de los tickets con nivel de criticidad 1 o menor
        {
            if(ticket.NivelCriticidad <= 1)
            {
                Console.WriteLine($"Ticket {ticket.ID} de criticidad { ticket.NivelCriticidad }atendido por Soporte Básico: {ticket.DescripcionProblema}");
                ticket.CambiarEstado(Estado.Solucionado);
            }
            else
            {
                Console.WriteLine($"Ticket {ticket.ID} de criticidad { ticket.NivelCriticidad } no puede ser atendido por Soporte Básico, delegando al siguiente nivel...");
                _SiguienteHandler?.AtenderTicket(ticket); //En caso de recibir un ticket con nivel de criticidad mayor a 1, se delega al siguiente handler en la cadena
            }
        }
    }
}
