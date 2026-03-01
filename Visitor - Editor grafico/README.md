# Editor Gráfico – Visitor

Estás desarrollando un editor gráfico que trabaja con diversas figuras geométricas. El objetivo es permitir la extensión de funcionalidades sin alterar la estructura interna de las clases de las figuras.

### Figuras Soportadas
* Círculos
* Rectángulos
* Triángulos

### Requerimiento de Extensibilidad
El sistema debe permitir agregar nuevas operaciones de forma dinámica. Algunos ejemplos de estas operaciones son:
1. **Calcular área:** Obtener la superficie de cada figura.
2. **Calcular perímetro:** Obtener la suma de los lados o longitud de circunferencia.
3. **Exportar a XML:** Generar una representación de la figura en formato de etiquetas.

### Restricción de Diseño
* **Principio de Abierto/Cerrado:** Las clases de las figuras **no deben modificarse** cada vez que se agregue una nueva operación al sistema.
* **Desacoplamiento:** La lógica de las operaciones debe residir fuera de las clases de datos de las figuras.

### Patrón Sugerido
Se debe aplicar el patrón de diseño **Visitor** para separar los algoritmos de las estructuras de objetos sobre las que operan, permitiendo añadir nuevas operaciones simplemente creando nuevas clases "Visitantes".
