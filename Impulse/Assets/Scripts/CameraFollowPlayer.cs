using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{

    public Transform _playerPosition;
    public Vector3 offset;

    void LateUpdate()
    {
        transform.position = new Vector3(0f, 2f, _playerPosition.position.z + offset.z);
        
    }
}
