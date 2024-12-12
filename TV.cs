using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TV : MonoBehaviour
{
  private WebCamTexture webcamTexture;
  private int captureCounter = 1;
  void Start() {
    webcamTexture = new WebCamTexture(); 
    Renderer renderer = GetComponent<Renderer>();
    renderer.material.mainTexture = webcamTexture;
    string cameraName = WebCamTexture.devices[0].name;
    Debug.Log("Camera: " + cameraName);
  }

    // Update is called once per frame
  void Update() {
    if (Input.GetKey("s")) {
      webcamTexture.Play();
    }
    if (Input.GetKey("p")) {
      webcamTexture.Pause();
    }
    if (Input.GetKey("x")) {
      // Tomar fotogramas
      Texture2D snapshot = new Texture2D(webcamTexture.width, webcamTexture.height);
      snapshot.SetPixels(webcamTexture.GetPixels());
      snapshot.Apply();
      string savePath = @"C:\Users\morad\Downloads\";
      System.IO.File.WriteAllBytes(savePath + "captura" + captureCounter.ToString() + ".png", snapshot.EncodeToPNG());
      captureCounter++;
      Debug.Log("Captura guardada en: " + savePath);
    }
  }
}
