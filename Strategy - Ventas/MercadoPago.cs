using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy___Ventas
{
    internal class MercadoPago : IMetodoPago
    {
        //Simula el pago por qr de mercado pago, en una aplicacion real se integraria con la api de mercado pago para generar el qr y procesar el pago.

        public override string ToString()
        {
            return "Mercado Pago";
        }
        public bool Pagar(double total)
        {
            string opcion = string.Empty;
            bool pagoExitoso = false;
            while (opcion != "1" && opcion != "2")
            {
                Console.WriteLine($"Pagará el monto de {total} a través de mercado pago, por favor escanee el qr.");
                Console.WriteLine("1.- QR escaneado correctamente.");
                Console.WriteLine("2.- Cancelar operación.");
                Console.Write("Ingrese su opción:");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Pago exitoso a través de mercado pago.");
                        pagoExitoso = true;
                        break;
                    case "2":
                        Console.WriteLine("Pago cancelado.");
                        pagoExitoso =false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida, por favor intente nuevamente.");
                        break;
                }
            }
            return pagoExitoso;
        }
    }
}
