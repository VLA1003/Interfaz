using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionIntro : MonoBehaviour
{
    [SerializeField]
    GameObject logo;

    [SerializeField]
    GameObject pantallaTitulo;
    void Start()
    {
        //Oculto mi logo (en 0 segundos; de manera inmediata).
        LeanTween.moveLocalY(logo, 1000f, 0f);
        //Hago aparecer mi logo y que se mueva hasta el centro de la pantalla en 2 segundos. El argumento "setEase" sirve para hacer
        //una curva.
        LeanTween.moveLocalY(logo, 0f, 3f).setEaseOutBounce().setOnComplete(Latido);
    }
    void Latido()
    {
        LeanTween.scale(logo, Vector3.one, 0.25f).setEaseOutBounce().setOnComplete(Desvanecer);
    }

    void Desvanecer()
    {
        LeanTween.alphaCanvas(gameObject.GetComponent<CanvasGroup>(), 0.0f, 2.0f).setOnComplete(Desactivar);
    }
    void Desactivar()
    {
        gameObject.SetActive(false);
        pantallaTitulo.SetActive(true);
    }


}
