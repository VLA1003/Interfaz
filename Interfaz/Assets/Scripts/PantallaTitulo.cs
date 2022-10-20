using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class PantallaTitulo : MonoBehaviour
{
    [SerializeField]
    GameObject pantallaIntroduccion, pantallaPrincipal, jugador;

    [SerializeField]
    TMP_InputField nombreJugadorJuego;
    
    [SerializeField]
    TextMeshProUGUI nombreJugador;


    void Start()
    {
        pantallaIntroduccion.SetActive(true);
        pantallaPrincipal.SetActive(false);
        jugador.SetActive(false);
    }

    public void EmpezarJuego()
    {
        pantallaIntroduccion.SetActive(false);
        pantallaPrincipal.SetActive(true);
        jugador.SetActive(true);
        nombreJugador.text = nombreJugadorJuego.text;
        Debug.Log(nombreJugador.text);
    }
}

