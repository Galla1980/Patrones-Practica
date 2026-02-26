# Patrón Strategy – Sistema de Ventas

## Consigna



Desarrollar un sistema de ventas que permita procesar pagos utilizando distintos métodos de pago intercambiables.



El sistema debe permitir:



- Seleccionar el método de pago.

- Procesar el pago según la estrategia elegida.

- Permitir cancelar la operación.



Métodos implementados:



- Tarjeta de Crédito

- Mercado Pago



## Objetivo del patrón



Aplicar el patrón Strategy para encapsular distintos algoritmos de pago y permitir su intercambio dinámico sin modificar la clase principal.



## Implementación



- `IMetodoPago` define la estrategia.

- `TarjetaCredito` y `MercadoPago` implementan estrategias concretas.

- `Compra` utiliza la estrategia seleccionada.

