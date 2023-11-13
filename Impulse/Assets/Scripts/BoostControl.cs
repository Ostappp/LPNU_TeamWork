using System.Collections;
using UnityEngine;

public class BoostControl : MonoBehaviour
{
    public float ShieldDurability = 5f;
    public float SlowTimeDurability = 5f;

    public GameObject ShieldPrefab;
    private GameObject shield;

    private bool isShieldActive = false;
    private bool isTimeSlowed = false;
    private bool isPaused = false;

    public void ActivateShield()
    {
        if (!isShieldActive)
        {
            shield = Instantiate(ShieldPrefab, transform);

            StartCoroutine(ShieldTimer());

            isShieldActive = true;
            Debug.Log("Activated shield");
        }
    }

    IEnumerator ShieldTimer()
    {
        float timer = 0;
        while (timer < ShieldDurability)
        {
            while (isPaused)
            {
                yield return null;
            }

            timer += Time.unscaledDeltaTime;
            yield return null;
        }
        DeactivateShield();
    }

    void DeactivateShield()
    {
        Debug.Log($"Shield time out\nShield: {shield}");
        if (shield)
            Destroy(shield);

        isShieldActive = false;
    }

    public void SlowTime()
    {
        if (!isTimeSlowed)
        {
            Time.timeScale = .15f;

            StartCoroutine(SlowTimeTimer());

            isTimeSlowed = true;
            Debug.Log("Slow time");
        }
    }

    IEnumerator SlowTimeTimer()
    {
        float timer = 0;
        while (timer < SlowTimeDurability)
        {
            while (isPaused)
            {
                yield return null;
            }

            timer += Time.unscaledDeltaTime;
            yield return null;
        }
        NormalizeTime();
    }

    void NormalizeTime()
    {
        Debug.Log("Normalize time");
        Time.timeScale = 1;
        isTimeSlowed = false;
    }

    public void PauseTimers()
    {
        isPaused = true;
    }

    public void UnpauseTimers()
    {
        isPaused = false;
    }
}
