using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_resposability___Tickets
{
    internal abstract class Handler//clase handler para definir los metodos necesarios para que las clases contretas sigan con la cadena de responsabilidad
    {
        protected Handler _SiguienteHandler;

        public void SetSiguienteHandler(Handler siguiente)
        {
            _SiguienteHandler = siguiente;
        }

        public abstract void AtenderTicket(Ticket ticket); //metodo abstracto que cada handler concreto implementa para atender el ticket como consideren necesario.
    }
}
