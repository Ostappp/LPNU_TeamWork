using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float laneWidth = 2f; // Визначте ширину кожної дороги
    public int currentLane = 2; // Початковий ряд, де персонаж розташований
    public int maxLanes = 5; // Кількість доступних рядів 

    private void Update()
    {
        // Переміщення вліво
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && currentLane > 0)
        {
            MoveToLane(currentLane - 1);
            UnityEngine.Debug.Log("Move left");
        }
        // Переміщення вправо
        if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && currentLane < maxLanes - 1)
        {
            MoveToLane(currentLane + 1);
            UnityEngine.Debug.Log("Move right");
        }
    }

    // Переміщення персонажа на певний ряд
    private void MoveToLane(int targetLane)
    {
        float xOffset = (targetLane - currentLane) * laneWidth;
        Vector3 targetPosition = new Vector3(transform.position.x + xOffset, transform.position.y, transform.position.z);
        transform.position = targetPosition;
        currentLane = targetLane;
    }
}
