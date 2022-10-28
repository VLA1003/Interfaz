using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionMenuOpciones : MonoBehaviour
{
    [SerializeField]
    GameObject menuFlotante, tituloOpciones, seleccionIdioma, idiomaSeleccionado, bandera, botonVolver, botonIzquierda, botonDerecha;


    public void OnEnable()
    {
        LeanTween.moveLocalY(menuFlotante, 1000.0f, 0.0f);
        LeanTween.moveLocalY(menuFlotante, 0.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarTituloOpciones);
    }

    void ActivarTituloOpciones()
    {
        LeanTween.moveLocalY(tituloOpciones, 1000.0f, 0.0f);
        LeanTween.moveLocalY(tituloOpciones, 83.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarSeleccionIdioma);
    }

    void ActivarSeleccionIdioma()
    {
        LeanTween.moveLocalY(seleccionIdioma, 1000.0f, 0.0f);
        LeanTween.moveLocalY(seleccionIdioma, 19.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarIdioma);
    }

    void ActivarIdioma()
    {
        LeanTween.moveLocalY(idiomaSeleccionado, 1000.0f, 0.0f);
        LeanTween.moveLocalY(idiomaSeleccionado, 19.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarBotones);
    }

    void ActivarBotones()
    {
        LeanTween.moveLocalY(botonIzquierda, 1000.0f, 0.0f);
        LeanTween.moveLocalY(botonIzquierda, -24.0f, 0.5f).setEaseOutExpo();
        LeanTween.moveLocalY(botonDerecha, 1000.0f, 0.0f);
        LeanTween.moveLocalY(botonDerecha, -24.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarBotonSalir);
    }

    void ActivarBotonSalir()
    {
        LeanTween.scale(botonVolver, Vector3.one * 1.0f, 0.2f).setEaseOutExpo().setOnComplete(ActivarBandera);
    }

    void ActivarBandera()
    {
        LeanTween.scale(bandera, Vector3.one * 0.5f, 0.2f).setEaseOutExpo();
    }

}
