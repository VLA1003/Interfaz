using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaJugador : MonoBehaviour
{
    Image image;

    void Start()
    {
        image = GetComponent<Image>();
    }

    // Función que modifica la cantidad de imagen que se ve al pulsar los botones de ataque o vida.

    public void Fill(float valor)
    {
        image.fillAmount += valor;
    }
}
