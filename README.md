# ⚔️ Proyecto Unity -- Shooter Plataforma 2D

Juego 2D desarrollado en Unity (versión 6000.2.10f1) donde controlas a
un personaje que debe eliminar soldados enemigos, evitar caer al abismo
y sobrevivir la mayor cantidad de tiempo posible. El objetivo principal
es destruir 10 soldados para ganar la partida.

## 🎮 Características del Juego

-   👤 **Control de personaje** con movimiento horizontal y salto.
-   🔫 **Sistema de disparo** con proyectiles.
-   🤖 **Enemigos (Soldados)** con aparición aleatoria (spawner).
-   💥 **Soldados con vida** y sistema de daño.
-   🧠 **Game Manager centralizado** para manejar vida, kills y estado
    del juego.
-   🧱 **Detección de suelo mediante Raycast**.
-   ⬇️ **Derrota instantánea al caer al abismo**.
-   🏆 **Victoria al eliminar 10 soldados**.
-   🔁 **Botón de reinicio** al ganar o perder.
-   📊 **Interfaz con TextMeshPro (TMP)** mostrando:
    -   Vida actual del jugador
    -   Soldados eliminados
    -   Mensaje final (victoria/derrota)
-   🎥 **Cámara con seguimiento y límites**.
-   💀 **Sistema de muerte de enemigos y jugador** integrado.

## 🕹️ Controles

| Acción                        | Tecla           |
|------------------------------|------------------|
| Moverse                      | A / D o ← →      |
| Saltar                       | W                |
| Disparar                     | SPACE            |
| Reiniciar (pantalla final)   | Botón UI         |


## 📌 Estructura de Scripts

### **GameManager**

Maneja la vida del jugador, los soldados eliminados, el estado de
victoria/derrota y el reinicio del juego.

### **Personaje**

Controla el movimiento, salto, disparo, daño y muerte por caída al
abismo.

### **SoldadoScript**

Define la lógica del enemigo, su vida, disparos y destrucción.

### **Spawner**

Genera soldados de forma aleatoria en el mapa.

### **UIControllerTMP**

Actualiza texto de vida, kills y mensajes finales.

### **Bala**

Controla el movimiento y el daño de las balas.

### **CamaraScript**

Sigue al personaje con límites configurables.

## 🔧 Requisitos

-   Unity 6000.2.10f1 o superior
-   Windows 10/11
-   4GB RAM mínimo

## 📥 Instalación

1.  Clonar el repositorio:

        git clone https://github.com/CristianDuarte05/VideoJuego2D.git

2.  Abrir el proyecto en Unity Hub.

3.  Abrir la escena principal:

        Assets/Scenes/SampleScene

4.  Presionar **Play**.

## 👤 Autor

Desarrollado por **Cristian Duarte Santos**.

## 📄 Licencia

Uso libre con fines educativos.
