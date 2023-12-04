using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{

    public Transform _playerPosition;
    public Vector3 offset;
    private bool _isPlaying = true;
    private void Start()
    {
        _playerPosition.GetComponent<PlayerMovement>().PlayerLoose += StopFollow;
    }
    void LateUpdate()
    {
        if (_isPlaying)
            transform.position = new Vector3(offset.x, offset.y, _playerPosition.position.z + offset.z);
    }
    private void StopFollow()
    {
        _isPlaying = false;
    }
}
