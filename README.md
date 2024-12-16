RollerBall es un juego 3D en Unity donde el jugador controla una bola que debe recolectar objetos (pickups) para completar niveles evitando obstaculos. El objetivo es recoger todos los objetos en cada nivel y evitar caer del plano.

 Pre-Requisitos
Que cosas necesitas para instalar el software y cómo instalarlas
    • Unity versión 2020.3 o superior. 
    • Un sistema operativo compatible con Unity (Windows, macOS o Linux). 
Ejemplo: Instalar Unity Hub desde [Unity Hub Download](https://unity.com/download)

Instalación:
Una serie de pasos para configurar el entorno de desarrollo
    1. Clona el repositorio:
       git clone https:https://github.com/lorenacabrera/miRollerBall.git
    2. Abre Unity Hub y selecciona la opción Open. Luego, selecciona la carpeta donde se descargó el proyecto.
    3. Espera a que Unity importe todos los recursos necesarios.
Ejemplo: Asegúrate de usar la versión de Unity recomendada al abrir el proyecto.
    4. Abre la escena principal en la carpeta /Scenes/. DAMN
Ejemplo: Haz clic en el archivo `MainScene.unity` para cargar el nivel inicial del juego.
Finaliza el proceso abriendo el proyecto en Unity y ejecutándolo para comprobar que todo está funcionando correctamente

Características: 

- Niveles: El juego incluye dos niveles con diferentes desafíos. 
    En el primer nivel debes recolectar objetos sin caer del plano. Si lo consigues entras al "Level 2"
    En el siguiente nivel encontraras obstaculos y mayor dificultad para recolectar objetos.

- Recolección de Objetos: Los jugadores pueden recolectar objetos para avanzar al siguiente nivel, aparecera un mensaje de next level

- Game Over: Si el jugador cae del plano, se muestra un mensaje de Game Over.

- Interfaz de Usuario: Se muestra la cantidad de objetos recolectados y un mensaje de fin de juego.

-Controles Juego: utiliza los botones direccionales para dirigir la bola y el espacio para saltar

Analice las pruebas end-to-end:
Estas pruebas verifican que el jugador puede mover la esfera, recolectar objetos y ganar puntos correctamente.
Ejemplo: 
1. Ejecuta el juego y mueve la esfera con las teclas WASD o flechas.
2. Verifica que los coleccionables desaparecen al tocarlos y que el puntaje aumenta.

Construido con: 
Herramientas utilizadas para crear este proyecto:
    • Unity - Motor de desarrollo. 
    • C# - Lenguaje de programación.  
    • Visual Studio - Editor de scripts

  Autor:
  Lorena Cabrera
  Si tienes preguntas o comentarios, no dudes en contactarme en marialorenacg@gmail.com
