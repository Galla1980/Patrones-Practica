# Patrón Chain of Responsibility – Sistema de Soporte Técnico



## Consigna



Desarrollar un sistema de soporte técnico que permita procesar tickets a través de distintos niveles de atención.



Cuando un ticket ingresa, debe ser evaluado por el primer nivel de soporte.  

Si no puede resolverlo, debe derivarlo al siguiente nivel, y así sucesivamente hasta que sea resuelto o se determine que no puede solucionarse.



## El sistema debe permitir:



- Crear tickets con número, descripción y nivel de complejidad.

- Procesar los tickets en orden.

- Derivar automáticamente al siguiente nivel si no se resuelve.

- Informar si el ticket fue resuelto o no.



## Niveles implementados:



- Soporte Nivel 1 (problemas básicos)

- Soporte Nivel 2 (problemas intermedios)

- Soporte Nivel 3 (problemas críticos)



## Comportamiento esperado



- Cada nivel intenta resolver el ticket.

- Si no puede, lo pasa al siguiente nivel.

- El flujo continúa hasta que alguien lo resuelva.

- Si ningún nivel puede resolverlo, se informa en consola.

