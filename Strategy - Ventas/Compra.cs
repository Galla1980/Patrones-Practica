using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy___Ventas
{
    internal class Compra //clase compra servira como contexto del strategy
    {
        public Cliente Cliente { get; set; }
        private List<Producto> Productos = new List<Producto>();

        private IMetodoPago metodoPago;

        public Compra(Cliente cliente)
        {
            Cliente = cliente;
        }

        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);
        }

        public void SetMetodoPago(IMetodoPago metodoPago)
        {
            this.metodoPago = metodoPago;
        }

        public bool Pagar()//en el metodo pagar calcularemos el total de la compra y llamamos al metodo pagar de la estrategia de pago seleccionada.
        {
            double total = Productos.Sum(p => p.Precio);
            bool pagoExitoso = false;
            if (metodoPago == null)
            {
                Console.WriteLine("No se ha seleccionado un metodo de pago.");
            }
            else
            {
                pagoExitoso = metodoPago.Pagar(total);
            }
            
            return pagoExitoso;
        }

        public override string ToString() 
        {
            return $"Cliente: {Cliente.Nombre}, {Cliente.Apellido}, DNI: {Cliente.DNI}, Total Compra: {Productos.Sum(p => p.Precio)} \nMetodo de pago: {metodoPago.ToString()}";
        }
    }
}
