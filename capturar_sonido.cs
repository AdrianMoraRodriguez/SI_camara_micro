using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capturar_sonido : MonoBehaviour
{
  private AudioSource sonido;
  private string nombre_microfono;
  private AudioClip audio_capturado;
  void Start() {
    sonido = GetComponent<AudioSource>();
    audio_capturado = Microphone.Start(nombre_microfono, true, 10, 44100);
    sonido.clip = audio_capturado;
  }

    // Update is called once per frame
  void Update() {
    if (Input.GetKeyDown(KeyCode.R)) {
      sonido.Play();
    }
  }
}
