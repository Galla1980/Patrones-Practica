# Patrón State – Servicio Logístico

## Consigna

Desarrollar un sistema de gestión de envíos donde un paquete pueda cambiar de estado a lo largo de su ciclo de vida.

El sistema debe permitir que un paquete pase por los siguientes estados:

- Pendiente
- Despachado
- En tránsito
- Entregado
- Cancelado

Cada estado debe definir su propio comportamiento y reglas de transición.

## Objetivo del patrón

Aplicar el patrón State para que el objeto `Paquete` modifique su comportamiento dinámicamente según su estado actual, evitando estructuras condicionales extensas.

## Implementación

- `Paquete` actúa como contexto.
- `EstadoPaquete` define la abstracción.
- Cada estado concreto implementa su comportamiento específico.