using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State___Servicio_logistica
{
    public class Paquete
    {
        public int Id { get; set; }
        public string NombreDestinatario { get; set; }
        public IEstadoPaquete Estado { get; set; }

        public Paquete(int id, string nombreDestinatario)
        {
            Id = id;
            NombreDestinatario = nombreDestinatario;
            Estado = new EstadoPendiente(); //El estado del paquete siempre comienza como pendiente (de despacho)
        }

        public override string ToString() //sobreescribo el tostring para mostrar la información del paquete de forma más clara
        {
            return $"Paquete ID: {Id}, Destinatario: {NombreDestinatario}, Estado: {Estado.ObtenerEstado()}";
        }

        //método para cambiar el estado del paquete, se utiliza en los métodos de cada estado para actualizar el estado del paquete
        public void CambiarEstado(IEstadoPaquete nuevoEstado) 
        {
            Estado = nuevoEstado;
        }
        //Los siguientes metodos llamadan a las operaciones correspondientes del estado actual del paquete,
        //delegando la lógica de cada acción al estado específico en el que se encuentra el paquete
        public void Despachar()
        {
            Estado.Despachar(this);
        }

        public void Enviar()
        {
            Estado.Enviar(this);
        }

        public void Entregar() 
        {
            Estado.Entregar(this);
        }

        public void Cancelar() 
        {
            Estado.Cancelar(this);
        }
    }
}
