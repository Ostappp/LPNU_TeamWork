using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogController : MonoBehaviour
{
    public Color fogColor = Color.gray; // ���� ������
    public float fogDensity = 0.02f; // ������� ������

    void Start()
    {
        RenderSettings.fog = true; // �������� �����
        RenderSettings.fogColor = fogColor; // ���������� ���� ������
        RenderSettings.fogDensity = fogDensity; // ���������� ������� ������
    }
}
