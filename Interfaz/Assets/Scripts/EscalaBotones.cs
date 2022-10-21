using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscalaBotones : MonoBehaviour
{
    public void escalaAgrandar()
    {
        LeanTween.scale(gameObject, Vector3.one * 1.5f, 0.2f);
    }

    public void escalaEncoger()
    {
        LeanTween.scale(gameObject, Vector3.one * 1.0f, 0.2f);
    }
}
