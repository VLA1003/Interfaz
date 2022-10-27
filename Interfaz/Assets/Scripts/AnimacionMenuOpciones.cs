using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionMenuOpciones : MonoBehaviour
{
    [SerializeField]
    GameObject menuFlotante, tituloOpciones, seleccionIdioma, idiomaSeleccionado, botonVolver;

    public void OnEnable()
    {
        LeanTween.moveLocalY(menuFlotante, 425.0f, 0.0f);
        LeanTween.moveLocalY(menuFlotante, 0.0f, 1.0f).setEaseOutExpo().setOnComplete(ActivarTituloOpciones);
    }

    void ActivarTituloOpciones()
    {
        LeanTween.moveLocalY(tituloOpciones, 425.0f, 0.0f);
        LeanTween.moveLocalY(tituloOpciones, 83.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarSeleccionIdioma);
    }

    void ActivarSeleccionIdioma()
    {
        LeanTween.moveLocalY(seleccionIdioma, 425.0f, 0.0f);
        LeanTween.moveLocalY(seleccionIdioma, 19.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarIdioma);
    }

    void ActivarIdioma()
    {
        LeanTween.moveLocalY(idiomaSeleccionado, 425.0f, 0.0f);
        LeanTween.moveLocalY(idiomaSeleccionado, 19.0f, 0.5f).setEaseOutExpo().setOnComplete(ActivarBotonSalir);
    }

    void ActivarBotonSalir()
    {
        LeanTween.scale(botonVolver, Vector3.one * 1.0f, 0.2f).setEaseOutExpo();
    }
}
