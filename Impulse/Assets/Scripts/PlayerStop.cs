using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStop : MonoBehaviour
{
    public PlayerMovement _movement;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            _movement.enabled = false;
        }
    }
}
