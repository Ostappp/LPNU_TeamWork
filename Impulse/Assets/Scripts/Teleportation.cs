using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public Transform teleportDestination; // �������, ���� ������� ���� ��������������

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // ��������, �� ��'���, �� ��������, �� ��� "Player"
        {
            // ����������� ������ �� ������� teleportDestination
            collision.gameObject.transform.position = teleportDestination.position;
        }
    }
}
