using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public Transform teleportDestination; // Позиція, куди гравець буде телепортований

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Перевірка, чи об'єкт, що зіткнувся, має тег "Player"
        {
            // Телепортуємо гравця до позиції teleportDestination
            collision.gameObject.transform.position = teleportDestination.position;
        }
    }
}
