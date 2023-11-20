using UnityEngine;
using System.Collections;

public class CubeMovement : MonoBehaviour
{
    public float initialSpeed = 1.0f; // ��������� �������� ����
    public float accelerationRate = 0.1f; // ���������� �����������
    private float currentSpeed; // ������� �������� ����

    private bool isMoving = true;
    public float timeBeforeFullSpeed = 5f;
    private int timerCount = 10;
    private int tmpTimerCount;

    void Start()
    {
        tmpTimerCount = timerCount;
        currentSpeed = 0; // ������������ ��������� ��������
        StartCoroutine(RestartTimer());
    }

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);

            // �������� ������� �������� � �����
            currentSpeed += accelerationRate * Time.deltaTime;
        }
    }

    IEnumerator RestartTimer()
    {
        while (tmpTimerCount > 0)
        {
            yield return new WaitForSeconds(timeBeforeFullSpeed / timerCount);
            tmpTimerCount--;
            currentSpeed += initialSpeed / timerCount;
        }
        Debug.Log($"End of slow\ncurrent speed: {currentSpeed}");
    }
}
