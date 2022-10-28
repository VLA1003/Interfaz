using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class CambiarIdioma : MonoBehaviour
{
    int idiomaActual = 0;
    void Awake()
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[4];
    }

    public void IdiomaAnterior()
    {
        idiomaActual--;
        if (idiomaActual < 0)
            idiomaActual = 4;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idiomaActual];
    }

    public void IdiomaSiguiente()
    {
        idiomaActual++;
        if (idiomaActual > 4)
            idiomaActual = 0;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[idiomaActual];
    }

    // Array con los diferentes idiomas del juego
    // LocalizationSettings.AvailableLocales.Locales;

    // Idioma seleccionado
    // LocalizationSettings.SelectedLocale;

    // int idiomaActual = 0;                             -> Número preestablecido 
    // int idiomaAleatorio = Random.Range(0, 5);         -> Número aleatorio
}
