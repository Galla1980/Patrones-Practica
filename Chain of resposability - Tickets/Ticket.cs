using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Chain_of_resposability___Tickets
{
    internal class Ticket
    {
        public int ID { get; set; }
        public string DescripcionProblema { get; set; }
        public int NivelCriticidad { get; set; } //Nivel de criticidad del problema para determinar quien maneja el ticket

        public Estado Estado { get; set; } //Estado del ticket para determinar si se ha solucionado o no el problema

        public DateTime FechaCreacion { get; set; }

        public Ticket(int id, string descripcionProblema, int nivelCriticidad)
        {
            ID = id;
            DescripcionProblema = descripcionProblema;
            NivelCriticidad = nivelCriticidad;
            FechaCreacion = DateTime.Today;
            Estado = Estado.SinAtender; //Inicialmente el estado del ticket es SinAtender
        }

        public void CambiarEstado(Estado nuevoEstado)
        {
            Estado = nuevoEstado;
        }

        public override string ToString()
        {
            return $"Ticket ID: {ID}, Descripción: {DescripcionProblema}, Nivel de Criticidad: {NivelCriticidad}, Estado: {Regex.Replace(Estado.ToString(), "(\\B[A-Z])", " $1")}, Fecha: {FechaCreacion.ToString("dd/MM/yyyy")}";
        }
    }
}
