using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float laneWidth = 2f; // Визначте ширину кожної дороги
    public int currentLane = 2; // Початковий ряд, де персонаж розташований
    public int maxLanes = 5; // Кількість доступних рядів 

    private bool isPause;
    public GameObject PauseMenu;

    public AudioClip DestroySound;
    private AudioSource SoundSource;
    private Collider _objCollider;

    public Action PlayerLoose;
    public Action PlayerWin;
    private void Start()
    {
        PauseMenu.SetActive(false);
        _objCollider = GetComponent<Collider>();
        SoundSource = GetComponent<AudioSource>();
        
    }
    private void Update()
    {
        // Переміщення вліво
        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) && currentLane > 0)
        {
            MoveToLane(currentLane - 1);
            Debug.Log("Move left");
        }
        // Переміщення вправо
        if ((Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) && currentLane < maxLanes - 1)
        {
            MoveToLane(currentLane + 1);
            Debug.Log("Move right");
        }
        //пауза
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
            Debug.Log("Move right");
        }
    }

    // Переміщення персонажа на певний ряд
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
    private void StopPlayer()
    {
        if (DestroySound != null)
        {
            SoundSource.clip = DestroySound;
            SoundSource.loop = false;
        }

        GetComponent<CubeMovement>().enabled = false;
        Debug.Log("Player loose");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (_objCollider != null && other.tag == "Obstacle")
        {
            other.gameObject.SetActive(false);
            StopPlayer();
            PlayerLoose?.Invoke();
        }
        else if (_objCollider != null && other.tag == "Teleport")
        {
            StopPlayer();
            PlayerWin?.Invoke();
        }
    }
}
