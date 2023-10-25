using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogController : MonoBehaviour
{
    public Color fogColor = Color.gray; // Колір туману
    public float fogDensity = 0.02f; // Густота туману

    void Start()
    {
        RenderSettings.fog = true; // Ввімкнути туман
        RenderSettings.fogColor = fogColor; // Встановити колір туману
        RenderSettings.fogDensity = fogDensity; // Встановити густоту туману
    }
}
