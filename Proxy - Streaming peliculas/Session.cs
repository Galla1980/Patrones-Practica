using System;

namespace Proxy___Streaming_peliculas
{
    internal static class Session
    {
        private static bool _estaLogueado;
        private static bool _tieneSuscripcion;

        public static bool EstaLogueado
        {
            get => _estaLogueado;
            set
            {
                _estaLogueado = value;
                // Si se desloguea, por seguridad
                // no puede quedar una suscripción activa "en el aire".
                if (!_estaLogueado)
                {
                    _tieneSuscripcion = false;
                }
            }
        }

        public static bool TieneSuscripcion
        {
            get => _tieneSuscripcion;
            set
            {
                // No se puede activar suscripción 
                // si ni siquiera hay un usuario logueado.
                if (EstaLogueado)
                {
                    _tieneSuscripcion = value;
                }
                else
                {
                    _tieneSuscripcion = false;
                    Console.WriteLine("No se puede activar suscripción sin iniciar sesión.");
                }
            }
        }
    }
}