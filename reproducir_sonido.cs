using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reproducir_sonido : MonoBehaviour
{
    public AudioSource sonido;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Objetivo")
        {
            sonido.Play();
        }
    }
}
