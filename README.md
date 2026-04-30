Diseño y Modelado de "QuickShip" con PlantUML

Introducción

El modelado de software no es simplemente dibujar "cajitas"; es un proceso analítico
que permite visualizar la estructura de un sistema antes de escribir una sola línea de
código. En esta actividad, actuarás como arquitecto de software utilizando la filosofía
"Diagrams as Code" mediante PlantUML para diseñar una solución de logística
profesional.
Requisitos del Cliente (Narrativa Técnica)
Deberás analizar el siguiente texto para extraer los componentes del sistema:
"QuickShip necesita gestionar sus Envíos. Todo envío tiene un código único, una
dirección de destino y un peso. Existen dos tipos específicos: los Nacionales (con
un coste de seguro) y los Internacionales (con código de aduana y país).
Los envíos son transportados por Repartidores (DNI, nombre, teléfono). Un
repartidor puede tener asignados muchos envíos, pero un envío solo pertenece a
un repartidor.
El sistema requiere una Interfaz de Usuario para la entrada de datos y un Gestor
de Logística que coordine la asignación de rutas. Además, los repartidores deben
poder 'ActualizarEstado' y el gestor debe 'CalcularCoste'."
Actividad 5. Elaboración de diagramas de clases.
Revisión 1 – 22/4/2026

Instrucciones de la Actividad

Fase 1: Análisis Textual (Metodología UML)

Antes de codificar el diagrama, identifica y documenta en un archivo de texto:
• Clases (Sustantivos): Aplica el filtro de relevancia para descartar términos
genéricos.
• Atributos y Métodos: Clasifica los datos simples y las acciones (verbos).
• Patrón BCE: Clasifica cada clase como Frontera, Control o Entidad.

Fase 2: Modelado en PlantUML

Crea un archivo .puml que represente el Diagrama de Clases Estructural. Debes incluir:
1. Jerarquía de Herencia: Representa la relación entre el envío genérico y sus tipos
específicos (Nacional e Internacional) usando la flecha de generalización <|--.
2. Visibilidad y encapsulamiento: Usa - para privado y + para público.
3. Multiplicidad: Indica claramente la relación 1 a * entre Repartidor y Envío.
4. Estereotipos: Etiqueta las clases según el patrón BCE (ej. <<control>>).

Fase 3: Implementación en C#

Tras validar el diagrama, escribe el esqueleto del código en C# aplicando las reglas de
mapeo técnico:
• Convierte la generalización UML en herencia de C# (:).
• Implementa la multiplicidad de "muchos" utilizando la clase List<T>.
• Asegura que el código sea un reflejo exacto del diseño (Forward Engineering).
Entrega
Entregar informe con el nombre del alumno y URL del repositorio del proyecto, además
de describir cada una de las fases realizadas.
