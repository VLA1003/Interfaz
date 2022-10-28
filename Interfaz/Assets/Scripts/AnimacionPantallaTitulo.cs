using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionPantallaTitulo : MonoBehaviour
{
    [SerializeField]
    GameObject logo, titulo, empezarPartida, cargarPartida, opciones, salir;

    public void OnEnable()
    {
        LeanTween.moveLocalX(logo, -2000.0f, 0.0f);
        LeanTween.moveLocalX(logo, -473.0f, 1.0f).setEaseOutElastic().setOnComplete(ActivarTitulo);
    }
    void ActivarTitulo()
    {
        LeanTween.moveLocalX(titulo, -2000.0f, 0.0f);
        LeanTween.moveLocalX(titulo, -312.0f, 1.0f).setEaseOutExpo().setOnComplete(ActivarBotonEmpezar);
    }

    void ActivarBotonEmpezar()
    {
        LeanTween.moveLocalX(empezarPartida, 2000.0f, 0.0f);
        LeanTween.moveLocalX(empezarPartida, 438.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarBotonCargar);
    }

    void ActivarBotonCargar()
    {
        LeanTween.moveLocalX(cargarPartida, 2000.0f, 0.0f);
        LeanTween.moveLocalX(cargarPartida, 438.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarBotonOpciones);
    }

    void ActivarBotonOpciones()
    {
        LeanTween.moveLocalX(opciones, 2000.0f, 0.0f);
        LeanTween.moveLocalX(opciones, 438.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarBotonSalir);
    }

    void ActivarBotonSalir()
    {
        LeanTween.moveLocalX(salir, 2000.0f, 0.0f);
        LeanTween.moveLocalX(salir, 438.0f, 0.5f).setEaseOutExpo();
    }
}
