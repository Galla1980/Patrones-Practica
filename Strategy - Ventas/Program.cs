using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy___Ventas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //simulo productos en stock
            List<Producto> listaProductos = new List<Producto>();
            listaProductos.AddRange(new Producto[] {
                new Producto() { Codigo = 1, Nombre = "Leche", Precio = 100 },
                new Producto() { Codigo = 2, Nombre = "Galletitas de agua", Precio = 200 },
                new Producto() { Codigo = 3, Nombre = "Gaseosa", Precio = 300 },
            });
            string opcion = string.Empty;

            //menu de opciones para el usuario  
            while (true)
            {
                Console.WriteLine("1.- Crear una nueva compra.");
                Console.WriteLine("2.- Salir.");
                Console.WriteLine("Ingrese una opción:");
                opcion = Console.ReadLine();
                if (opcion == "2")
                {
                    Console.WriteLine("Saliendo del programa.");
                    return;
                }
                else if (opcion != "1")
                {

                    Console.WriteLine("Opción no válida, vuelva a intentarlo.");
                }

                //creacion de compra y seleccion de productos
                Cliente c = ValidarCliente();
                Compra compra = new Compra(c);
                List<Producto> productosSeleccionados = SeleccionarProductos(listaProductos);
                foreach (Producto producto in productosSeleccionados)//Agrego los productos a la compra.
                {
                    compra.AgregarProducto(producto);
                }
                Console.WriteLine("Presione enter para continuar...");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Productos seleccionados para la compra:");

                
                string opcion2 = string.Empty;
                while(true) {
                    //linq para mostrar los productos seleccionados con su precio y cantidad, utilizando el método Distinct para evitar mostrar productos repetidos
                    var linq = from x in productosSeleccionados select new { Nombre = x.Nombre, Precio = x.Precio, Cant = productosSeleccionados.Count(p => p.Codigo == x.Codigo) };
                    foreach (var item in linq.Distinct())
                    {
                        Console.WriteLine($"Producto: {item.Nombre} - Precio: {item.Precio} - Cantidad: {item.Cant}");
                    }
                    Console.WriteLine();
                    Console.WriteLine("1.- Seleccionar metodo de pago.");
                    Console.WriteLine("2.- Pagar.");
                    Console.WriteLine("Ingrese una opción:");
                    opcion2 = Console.ReadLine();
                    if (opcion2 == "1")
                    {
                        string metodoPago = string.Empty;
                        while (true)
                        {
                            Console.WriteLine("1.- Tarjeta de crédito.");
                            Console.WriteLine("2.- Mercado Pago.");
                            Console.WriteLine("Seleccione un método de pago:");
                            metodoPago = Console.ReadLine();
                            if (metodoPago == "1")
                            {
                                compra.SetMetodoPago(new TarjetaCredito());
                                Console.WriteLine("Método de pago 'Tarjeta de crédito' seleccionado.");
                                break;
                            }
                            else if (metodoPago == "2")
                            {
                                compra.SetMetodoPago(new MercadoPago());
                                Console.WriteLine("Método de pago 'Mercado Pago' seleccionado.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Opción no válida, vuelva a intentarlo.");
                            }
                            Console.WriteLine("Presione enter para continuar...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else if (opcion2 == "2")
                    {
                        if (compra.Pagar())
                        {
                            Console.WriteLine("Pago realizado con éxito. Gracias por su compra.");
                            Console.WriteLine("Detalles de la compra: ");
                            Console.WriteLine(compra.ToString());
                            Console.WriteLine("presione enter para continuar...");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No se pudo procesar el pago. Por favor, seleccione un método de pago válido antes de intentar pagar.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida, vuelva a intentarlo.");


                    }
                    Console.WriteLine("presione enter para continuar...");
                    Console.ReadLine();
                    Console.Clear();
                } 
            }
        }
        private static List<Producto> SeleccionarProductos(List<Producto> listaProductos)
        {
            string codigoProducto = string.Empty;
            List<Producto> productosSeleccionados = new List<Producto>();
            while (true)
            {
                Console.WriteLine("Productos existentes: ");
                foreach (Producto producto in listaProductos)// muestra los codigos de productos creados en el sistema para que el usuario pueda elegir
                {
                    Console.WriteLine(producto.ToString());
                }
                Console.WriteLine("Ingrese el código del producto que desea agregar a su compra (o '0' para finalizar):");
                codigoProducto = Console.ReadLine();
                if (codigoProducto == "0")
                {
                    if (productosSeleccionados.Count == 0)
                    {
                        Console.WriteLine("Debe seleccionar al menos un producto para finalizar la compra.");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Producto productoSeleccionado = listaProductos.FirstOrDefault(p => p.Codigo.ToString() == codigoProducto);
                    if (productoSeleccionado != null)//Si encuentra un producto con el código ingresado, lo agrega a la lista de productos seleccionados sino pide que lo intente de nuevo
                    {
                        productosSeleccionados.Add(productoSeleccionado);
                        Console.WriteLine($"Producto '{productoSeleccionado.Nombre}' agregado a la compra.");
                    }
                    else
                    {
                        Console.WriteLine("Código de producto no válido, vuelva a intentarlo.");
                    }
                }
            }
            
            return productosSeleccionados;
        }

        private static Cliente ValidarCliente()
        {
            string dni = string.Empty;
            while (true)
            {
                Console.WriteLine("Ingrese su DNI: ");
                dni = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(dni) || dni.Length != 8 || !dni.All(char.IsDigit))
                {
                    Console.WriteLine("DNI no válido, vuelva a intentarlo.");
                }
                else
                {
                    Console.WriteLine("DNI ingresado correctamente.");
                    break;
                }
            }
            string nombre = string.Empty;
            while (true)
            {
                Console.WriteLine("Ingrese su nombre: ");
                nombre = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nombre) || !nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    Console.WriteLine("Nombre no válido, vuelva a intentarlo.");
                }
                else
                {
                    Console.WriteLine("Nombre ingresado correctamente.");
                    break;
                }
            }
            string apellido = string.Empty;
            while (true)
            {
                Console.WriteLine("Ingrese su apellido: ");
                apellido = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(apellido) || !apellido.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
                {
                    Console.WriteLine("Apellido no válido, vuelva a intentarlo.");
                }
                else
                {
                    Console.WriteLine("Apellido ingresado correctamente.");
                    break;
                }
            }

            Console.WriteLine("Cliente validado correctamente.");
            Console.WriteLine("Presione enter para continuar...");
            Console.ReadLine();
            Console.Clear();
            return new Cliente(dni, nombre, apellido);

        }
    }
}
