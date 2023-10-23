using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float initialSpeed = 1.0f; // Початкова швидкість куба
    public float accelerationRate = 0.1f; // Коефіцієнт прискорення
    private float currentSpeed; // Поточна швидкість куба
    public float stopPositionZ = 50f; // Зупинити гравця при досягненні цієї позиції по осі Z

    private bool isMoving = true;

    void Start()
    {
        currentSpeed = initialSpeed; // Встановлюємо початкову швидкість
    }

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);

            // Збільшуємо поточну швидкість з часом
            currentSpeed += accelerationRate * Time.deltaTime;
            if (transform.position.z >= stopPositionZ)
            {
                isMoving = false;
                // Зупинити гравця
                // Опціонально, ви можете викликати інші функції або виконати інші дії тут, коли гравець зупинився.
            }
        }

    }
}
