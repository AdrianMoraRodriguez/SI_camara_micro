# Informe de la práctica: Uso de cámara y micrófono en Unity

## Introducción

En esta práctica de Unity, se han implementado diversas funcionalidades que permiten interactuar con los dispositivos de entrada, como el micrófono y la cámara. Se busca familiarizarse con la captura de audio y video en tiempo real, su reproducción y la manipulación de imágenes capturadas. Los objetivos incluyen la integración de audio con la entrada del micrófono, la visualización del video capturado por la cámara en una pantalla dentro de la escena, y la captura de imágenes fijas.

## Objetivos

1. **Reproducir un sonido cuando una araña alcanza un objetivo.**
2. **Capturar audio desde el micrófono y reproducirlo al presionar una tecla.**
3. **Mostrar lo que captura la cámara en una pantalla ubicada en la escena.**
4. **Mostrar el nombre de la cámara utilizada en la consola.**
5. **Capturar fotogramas de la cámara y almacenarlos como imágenes fijas en el sistema.**

## Desarrollo

### 1. Reproducción de un sonido al alcanzar un objetivo

Para este primer paso, se implementó la funcionalidad que permite reproducir un sonido cuando una araña alcanza un objetivo en la escena. Se utilizó un componente de tipo `AudioSource` que permite reproducir un sonido cuando se produce una colisión o interacción con otro objeto. Este componente requiere asignar un `AudioClip`, que es el archivo de sonido a reproducir. En el código, se detecta la colisión con el objetivo y, al alcanzarlo, se reproduce el sonido asociado al objeto `AudioSource`.

### 2. Captura y reproducción de audio desde el micrófono

En este paso, se logró capturar el sonido desde el micrófono del dispositivo y reproducirlo dentro de la aplicación al presionar una tecla específica. Utilizando la clase `Microphone` de Unity, se accedió al dispositivo de entrada de audio (micrófono), y se configuró para grabar durante un periodo de tiempo determinado. El audio capturado se asignó a un objeto `AudioSource`, el cual permitió la reproducción del sonido cuando el usuario presionaba la tecla `R`. Esta funcionalidad es útil para aplicaciones que requieren la interacción del usuario a través del audio en tiempo real.

### 3. Mostrar la imagen capturada por la cámara en una pantalla

El siguiente paso consistió en capturar lo que la cámara veía en tiempo real y mostrarlo en una pantalla dentro de la escena de Unity. Para lograr esto, se utilizó el objeto `WebCamTexture`, que permite acceder al flujo de video desde la cámara del dispositivo. La textura generada por esta cámara se asignó a un material de un objeto en la escena (por ejemplo, un `Quad` o `RawImage`), lo que permitió mostrar la imagen capturada directamente en la interfaz o en un objeto 3D. De esta manera, se pudo visualizar en tiempo real lo que la cámara estaba grabando.

### 4. Mostrar el nombre de la cámara en la consola

Otro objetivo fue mostrar el nombre de la cámara utilizada en la consola de Unity. Utilizando la clase `WebCamTexture`, se pudo acceder a los dispositivos de cámara disponibles en el sistema y obtener el nombre del primer dispositivo de cámara conectado. Este nombre se mostró en la consola de Unity mediante el método `Debug.Log()`, lo que facilita la identificación de la cámara en uso, especialmente cuando se tienen múltiples cámaras conectadas al dispositivo.

### 5. Capturar fotogramas aislados y almacenarlos como imágenes fijas

El último paso consistió en capturar fotogramas aislados de la cámara y almacenarlos como imágenes fijas en el disco. Para esto, se utilizó la función `GetPixels()` de la clase `WebCamTexture` para obtener la información de píxeles del fotograma actual de la cámara. Luego, esos píxeles se almacenaron en un objeto `Texture2D`. Después de aplicar los píxeles a la textura, esta se guardó como un archivo PNG utilizando el método `EncodeToPNG()`, que permite convertir la textura en un archivo de imagen. La imagen se guardó en una carpeta específica del sistema, y cada captura se numeró de manera secuencial.

### Problemas y soluciones

- **Error con las rutas de archivo**: Se presentó un problema relacionado con las rutas de archivo debido al uso de barras invertidas (`\`) en las rutas de acceso a los archivos. Este problema se solucionó utilizando **strings literales** (con el prefijo `@`) para evitar errores de secuencia de escape.
