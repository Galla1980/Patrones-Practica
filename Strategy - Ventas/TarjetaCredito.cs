using System;
using System.Linq;

namespace Strategy___Ventas
{
    internal class TarjetaCredito : IMetodoPago
    {
        public bool Pagar(double total)// el cliente ingresara los 16 digitos de su tarjeta, la fecha de vencimiento y el codigo de seguridad para procesar el pago. Puede ingresar 0 para cancelar la operacion.
        {
            string nroTarjeta = string.Empty;
            DateTime fechaVencimiento;
            string codigoSeguridad = string.Empty;
            Console.WriteLine($"Pagará el monto de {total} con tarjeta de credito, por favor ingrese los datos de su tarjeta.");

            //----------- Validacion del numero de tarjeta -----------
            while (true)
            {
                Console.WriteLine("Ingrese el numero de tarjeta (16 digitos) o 0 para cancelar la operacion:");
                nroTarjeta = Console.ReadLine();
                if (nroTarjeta == "0")
                {
                    Console.WriteLine("Pago cancelado.");
                    return false;
                }
                if (ValidarNroTarjeta(nroTarjeta))
                {
                    break;
                }
                Console.WriteLine("Numero de tarjeta no valido, por favor intente nuevamente.");
            }

            //----------- Validacion de la fecha de vencimiento -----------
            string fechaVencimientoInput = string.Empty;
            while (true)
            {
                Console.WriteLine("Ingrese la fecha de vencimiento (MM/AA) o 0 para cancelar la operacion:");
                fechaVencimientoInput = Console.ReadLine();
                if (fechaVencimientoInput == "0")
                {
                    return false;
                }
                if (DateTime.TryParseExact(fechaVencimientoInput, "MM/yy", null, System.Globalization.DateTimeStyles.None, out fechaVencimiento) )
                {
                    // Ajustar al ultimo dia del mes
                    fechaVencimiento = new DateTime(
                        fechaVencimiento.Year,
                        fechaVencimiento.Month,
                        DateTime.DaysInMonth(fechaVencimiento.Year, fechaVencimiento.Month)
                    );

                    if (fechaVencimiento >= DateTime.Now)
                        break;

                    Console.WriteLine("La tarjeta esta vencida.");
                }

                Console.WriteLine("Fecha de vencimiento no valida, por favor intente nuevamente.");
            }
            //----------- Validacion del cvv -----------

            while (true)
            {
                Console.WriteLine("Ingrese el codigo de seguridad (CVV) o 0 para cancelar la operacion:");
                codigoSeguridad = Console.ReadLine();
                if (codigoSeguridad == "0")
                {
                    Console.WriteLine("Pago cancelado.");
                    return false;
                }
                if (codigoSeguridad.Length == 3 && codigoSeguridad.All(char.IsDigit))
                {
                    break;
                }
                Console.WriteLine("Codigo de seguridad no valido, por favor intente nuevamente.");
            }
            return true;
        }

        private bool ValidarNroTarjeta(string nroTarjeta)
        {
            bool validar = false;
            if (string.IsNullOrEmpty(nroTarjeta) || nroTarjeta.Length != 16 || !nroTarjeta.All(char.IsDigit))
            {
                validar = false;
            }
            else
            {
                validar = true;
            }
            return validar;
        }

        public override string ToString()
        {
            return "Tarjeta de Credito";
        }
    }
}