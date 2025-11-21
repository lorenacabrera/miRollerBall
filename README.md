Aquí tienes el README completamente en **texto plano**, limpio, sin emoticonos ni símbolos, listo para copiar y pegar en tu GitHub.

---

# RollerBall – Proyecto Unity

RollerBall es un juego 3D desarrollado en Unity donde el jugador controla una esfera que debe moverse por el escenario, recolectar objetos y evitar obstáculos para completar cada nivel sin caer del plano. El proyecto sigue el tutorial Roll-a-Ball de Unity e incluye ampliaciones como salto, Game Over, dos niveles, recolección de objetos, reinicio de partida e integración básica de VR.

---

## Requisitos previos

* Unity 2020.3 o superior
* Unity Hub
* Sistema operativo compatible (Windows, macOS o Linux)

---

## Instalación

1. Clonar el repositorio:

```
git clone https://github.com/lorenacabrera/miRollerBall.git
```

2. Abrir Unity Hub y seleccionar "Open Project".
3. Elegir la carpeta donde se descargó el repositorio.
4. Esperar a que Unity importe todos los recursos.
5. Abrir la escena principal ubicada en:

```
Assets/Scenes/MainScene.unity
```

6. Ejecutar el juego con el botón Play.

---

## Características del juego

### Movimiento del jugador

El jugador controla la esfera mediante las teclas WASD o flechas. El movimiento está basado en física mediante Rigidbody.

### Salto

La esfera puede saltar con la tecla Espacio cuando está en el suelo.

### Recolección de objetos

Al tocar un objeto de tipo Pickup, este desaparece y aumenta el contador de puntuación.

### Sistema de niveles

El juego incluye dos niveles.
El Nivel 1 introduce las mecánicas básicas.
El Nivel 2 añade obstáculos y mayor dificultad.
Cuando se recolectan todos los objetos, aparece el mensaje de pase al siguiente nivel.

### Game Over

Si el jugador cae por debajo del escenario, aparece un mensaje de Game Over y la partida se reinicia automáticamente.

### Reinicio de partida

El jugador puede reiniciar el nivel usando la tecla R.

### Interfaz de usuario

La UI muestra la puntuación, mensajes de avance de nivel y mensajes de fin de juego.

---

## Enemigo con IA

El proyecto incluye un enemigo con un comportamiento básico de seguimiento del jugador mediante un script que utiliza Vector3.MoveTowards.

---

## Integración de VR

El proyecto utiliza elementos básicos de realidad virtual requeridos en la UT6:

* XR Interaction Toolkit instalado.
* XR Rig (Action Based) añadido a la escena.

---

## Pruebas end-to-end

* Verificación del movimiento de la esfera.
* Comprobación de que los objetos se recolectan correctamente.
* El contador se actualiza al recoger objetos.
* Cambio de nivel al completar los objetivos.
* Aparición del mensaje Game Over al caer del escenario.
* Reinicio automático del nivel.

---

## Tecnologías utilizadas

* Unity
* C#
* TextMeshPro
* XR Interaction Toolkit
* Visual Studio

---

## Aspectos destacables de Unity usados en el proyecto

* Sistema de físicas mediante Rigidbody y AddForce.
* UI dinámica con TextMeshPro.
* Gestor de escenas con SceneManager para cambio de nivel y reinicio.
* Implementación de IA sencilla para seguimiento de jugador.
* Integración básica de VR mediante XR Rig.
* Estructura modular a través de scripts individuales para cada sistema del juego.
* Uso del nuevo Input System para el movimiento del jugador.

---

## Autor

Lorena Cabrera
[marialorenacg@gmail.com](mailto:marialorenacg@gmail.com)

---

Si quieres, también te preparo un README reducido específicamente para la entrega de UT4/UT6, o te reviso el repositorio para confirmar que cumple todos los apartados.
