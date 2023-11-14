using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float laneWidth = 2f; // �������� ������ ����� ������
    public int currentLane = 2; // ���������� ���, �� �������� ������������
    public int maxLanes = 5; // ʳ������ ��������� ���� 

    private bool isPause;
    public GameObject PauseMenu;

    private void Start()
    {
        GetComponent<Renderer>().material = SkinManager.Instance.GetSkin();
        PauseMenu.SetActive(false);
    }
    private void Update()
    {
        // ���������� ����
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && currentLane > 0)
        {
            MoveToLane(currentLane - 1);
            Debug.Log("Move left");
        }
        // ���������� ������
        if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && currentLane < maxLanes - 1)
        {
            MoveToLane(currentLane + 1);
            Debug.Log("Move right");
        }
        //�����
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
            Debug.Log("Move right");
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
    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseMenu.SetActive(true);
        isPause = !isPause;
    }
    public void UnPauseGame()
    {
        PauseMenu.SetActive(false);
        isPause = !isPause;
        Time.timeScale = 1;
    }
}
