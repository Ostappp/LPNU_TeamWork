using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float laneWidth = 2f; // �������� ������ ����� ������
    public int currentLane = 2; // ���������� ���, �� �������� ������������
    public int maxLanes = 5; // ʳ������ ��������� ���� 

    private void Update()
    {
        // ���������� ����
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && currentLane > 0)
        {
            MoveToLane(currentLane - 1);
            UnityEngine.Debug.Log("Move left");
        }
        // ���������� ������
        if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && currentLane < maxLanes - 1)
        {
            MoveToLane(currentLane + 1);
            UnityEngine.Debug.Log("Move right");
        }
    }

    // ���������� ��������� �� ������ ���
    private void MoveToLane(int targetLane)
    {
        float xOffset = (targetLane - currentLane) * laneWidth;
        Vector3 targetPosition = new Vector3(transform.position.x + xOffset, transform.position.y, transform.position.z);
        transform.position = targetPosition;
        currentLane = targetLane;
    }
}
