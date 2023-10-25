using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float initialSpeed = 1.0f; // ��������� �������� ����
    public float accelerationRate = 0.1f; // ���������� �����������
    private float currentSpeed; // ������� �������� ����
    public float stopPositionZ = 50f; // �������� ������ ��� ��������� ���� ������� �� �� Z

    private bool isMoving = true;

    void Start()
    {
        currentSpeed = initialSpeed; // ������������ ��������� ��������
    }

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);

            // �������� ������� �������� � �����
            currentSpeed += accelerationRate * Time.deltaTime;
            if (transform.position.z >= stopPositionZ)
            {
                isMoving = false;
                // �������� ������
                // �����������, �� ������ ��������� ���� ������� ��� �������� ���� 䳿 ���, ���� ������� ���������.
            }
        }

    }
}
