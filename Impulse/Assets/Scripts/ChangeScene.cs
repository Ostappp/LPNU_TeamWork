using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int nextSceneName = 2; // Назва сцени, на яку потрібно перейти
    public PlayerMovement _movement; // Змінено ім'я типу на "PlayerMovement"

    void Update()
    {
        // Перевіряємо зіткнення гравця з кубом в кожному кадрі.
        if (Physics.Raycast(transform.position, _movement.transform.position - transform.position, out RaycastHit hit))
        {
            if (hit.collider.gameObject == _movement.gameObject)
            {
                UnityEngine.Debug.Log("Teleport");
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }
}
