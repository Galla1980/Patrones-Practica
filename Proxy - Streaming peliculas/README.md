\# Ejercicio 2 – Plataforma de Streaming – Proxy



Estás desarrollando una plataforma de streaming.



Los usuarios pueden reproducir películas, pero antes de acceder al contenido se deben realizar ciertos controles:



1\. Verificar si el usuario está logueado.

2\. Verificar si tiene suscripción activa.

3\. Registrar la visualización en un log.



El objeto que reproduce la película es costoso de crear (consume muchos recursos), por lo que no debería instanciarse innecesariamente.



\### Requisito

El cliente no debe interactuar directamente con el objeto real de reproducción.



\### Restricciones de Diseño

\* \*\*Encapsulamiento:\*\* El cliente debe interactuar con una interfaz común, desconociendo si utiliza el objeto real o el intermediario.

\* \*\*Carga Perezosa (Lazy Initialization):\*\* La instancia del reproductor real solo debe crearse si el usuario cumple con todos los requisitos de acceso.

