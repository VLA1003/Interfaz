using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaludJugadorBarra : MonoBehaviour
{
    [SerializeField]
    int saludJugador = 5;

    [SerializeField]
    int saludMaxima = 20;

    [SerializeField]
    Slider barraVida;

    // La primera funci�n nos sirve para indicar que el valor m�ximo que puede tomar la barra de vida est� determinado por la salud
    // m�xima que pueda tener el jugador. La segunda funci�n nos sirve para que la salud 
    void Start()
    {
        barraVida.maxValue = saludMaxima;
        barraVida.value = saludMaxima/2; 
    }

    public void Fill(int valor)
    {
        barraVida.value += valor;
    }
}
