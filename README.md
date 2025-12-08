# 🐉 XR Adventure: Pokémon 3D en la Nube ☁️  
### Realidad Aumentada con Unity + AR Foundation

¡Bienvenido a **XR Adventure**! 🚀  
Una experiencia de **Realidad Aumentada (AR)** donde tus Pokémon favoritos cobran vida en el mundo real.  
La aplicación aprovecha la **potencia de la nube** para cargar modelos 3D dinámicamente y permitir un despliegue escalable, flexible y moderno.

Explora tu entorno, detecta superficies reales y coloca Pokémon 3D que puedes **mover, girar e inspeccionar desde cualquier ángulo**.

👥 Proyecto desarrollado en colaboración por **David Jiménez Villena** y **Francisco Torres Puche** alumnos del Curso de Especialización en Desarrollo de videojuegos y realidad virtual

---

## ✨ Características Principales

✅ **Detección de Planos Avanzada**  
Detecta automáticamente superficies horizontales (suelos, mesas, escritorios) en tiempo real para una colocación estable de los modelos.

✅ **Pokémon 3D de Alta Fidelidad**  
Modelos 3D intercambiables con gran nivel de detalle listos para AR.

✅ **Interacción AR Intuitiva**  
- 🖐️ **Mover:** Arrastra el Pokémon sobre el plano detectado  
- 🔄 **Rotar:** Gesto de pinza con dos dedos para girarlo libremente

✅ **Carga Dinámica desde la Nube (Live Content)**  
- ☁️ **Modelos 3D Remotos:** Descarga de Pokémon en tiempo de ejecución desde Google Drive  
- 📄 **Configuración con JSON:** Un archivo JSON decide qué Pokémon aparecen y sus propiedades sin recompilar la app  

✅ **Captura y Compartición Social**  
- 📸 Captura imágenes del Pokémon integrado en el mundo real  
- 📤 Comparte fotos fácilmente con tus amigos en cualquier red social  

---

## 🛠️ Tecnologías Utilizadas

| Categoría | Tecnología | Uso |
|--------|-----------|-----|
| 🎮 Motor AR | **Unity 3D + AR Foundation** | Tracking AR, detección de planos y renderizado |
| 💻 Lenguaje | **C#** | Lógica de la app e interacción 3D |
| 🎨 Assets | **Modelos Pokémon 3D** | Recursos visuales |
| ☁️ Nube | **Google Drive** | Hosting de modelos y configuración dinámica |

---

## 🚀 Instalación y Ejecución

Tienes **dos formas** de probar XR Adventure:

---

### 🔥 Opción 1: Ejecutar la APK (Recomendada)

La forma más rápida ✅

1. Ve a la carpeta `apk/` del repositorio  
2. Descarga el archivo **XRAdventure.apk**  
3. Pásalo a tu dispositivo Android compatible con **ARCore**  
4. Habilita *Instalar apps de fuentes desconocidas*  
5. Instala y abre la aplicación  
6. 🎉 ¡Listo! Empieza a colocar Pokémon en el mundo real  

---

### 🛠️ Opción 2: Compilar desde Unity

Ideal si quieres **ver el código o modificar el proyecto**.

#### 🔧 Requisitos Previos

- **Unity 6.0** (6000.0.60f1) o superior  
- Dispositivo compatible con **ARCore o ARKit**  
- Módulos de compilación para **Android o iOS**

#### 📥 Pasos

Clona el repositorio:

```bash
git clone https://github.com/FTorrent-63/XRAdventure.git
cd XRAdventure
```
## 🛠️ Compilación del Proyecto (Unity)

1. **Abrir el proyecto**
   - Abre **Unity Hub**
   - Selecciona el proyecto **XRAdventure**

2. **Verificar paquetes AR**
   - Abre `Window > Package Manager`
   - Asegúrate de tener instalados:
     - ✅ **AR Foundation**
     - ✅ **ARCore XR Plugin** (Android)

3. **Compilar la aplicación**
   - Abre la escena principal:  
     `Scenes/MainScene.unity`
   - Ve a `File > Build Settings`
   - Selecciona tu plataforma: 📱 **Android**
   - Pulsa **Build and Run**

---

## 🕹️ Guía de Uso

📸 **Inicio**  
Abre la aplicación y concede permisos de cámara cuando se soliciten.

🟦 **Detección de Planos**  
Mueve lentamente el dispositivo alrededor de tu entorno hasta que aparezcan puntos o una malla indicando una superficie válida.

⚪ **Abrir la Pokéball**  
Una vez detectada una superficie:
- Pulsa el botón de la **Pokéball** en pantalla
- Se mostrará el menú de Pokémon disponibles

🐉 **Selección de Pokémon**  
- Explora la lista de Pokémon cargados desde la nube
- Selecciona el Pokémon que deseas utilizar

👆 **Colocación del Pokémon**  
Toca la pantalla sobre la superficie detectada para colocar el Pokémon seleccionado en el mundo real.

🎮 **Interacción**
- **Mover:** toca y arrastra el Pokémon sobre el plano  
- **Rotar:** utiliza un gesto de pinza con dos dedos para girarlo y ajustarlo a tu perspectiva

📤 **Captura y Compartir**
- Usa el botón de **captura** con el icono de una **Camara Pokémon** para tomar una foto del Pokémon en AR
- Comparte la imagen directamente con tus amigos en redes sociales o apps de mensajería
---

## ✉️ Contacto

👤 **Autor:**  
- David Jiménez Villena  
- Francisco Torres Puche  

🐙 **GitHub:**  
- [djsekai34](https://github.com/djsekai34)  
- [FTorrent-63](https://github.com/FTorrent-63)  

---
