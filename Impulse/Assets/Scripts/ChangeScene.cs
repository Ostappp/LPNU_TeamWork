using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int nextSceneName = 2; // ����� �����, �� ��� ������� �������
    public PlayerMovement _movement; // ������ ��'� ���� �� "PlayerMovement"

    void Update()
    {
        // ���������� �������� ������ � ����� � ������� ����.
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
