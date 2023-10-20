using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float initialSpeed = 1.0f; // Початкова швидкість куба
    public float accelerationRate = 0.1f; // Коефіцієнт прискорення
    private float currentSpeed; // Поточна швидкість куба

    void Start()
    {
        currentSpeed = initialSpeed; // Встановлюємо початкову швидкість
    }

    void Update()
    {
        // Рухаємо куб вперед
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);

        // Збільшуємо поточну швидкість з часом
        currentSpeed += accelerationRate * Time.deltaTime;
    }
}
