using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State___Servicio_logistica
{
    //Interfaz para definir las operaciones que se pueden realizar en los estados del paquete
    public interface IEstadoPaquete
    { 
        void Despachar(Paquete paquete);
        void Enviar(Paquete paquete);
        void Entregar(Paquete paquete);
        void Cancelar(Paquete paquete);
        string ObtenerEstado();

    }
}
