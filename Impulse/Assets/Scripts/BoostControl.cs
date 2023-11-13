using System.Collections;
using UnityEngine;

public class BoostControl : MonoBehaviour
{
    public float ShieldDurability = 5f;
    public float SlowTimeDurability = 5f;

    private int shieldQuantity;
    private int slowTimeQuantity;

    public GameObject ShieldPrefab;
    private GameObject shield;

    private bool isShieldActive = false;
    private bool isTimeSlowed = false;
    private bool isPaused = false;
    private void Start()
    {
        shieldQuantity = PlayerPrefs.GetInt("Item_1_Quantity", 0);
        slowTimeQuantity = PlayerPrefs.GetInt("Item_2_Quantity", 0);
    }
    public void ActivateShield()
    {
        if (!isShieldActive && shieldQuantity > 0)
        {
            shield = Instantiate(ShieldPrefab, transform);

            StartCoroutine(ShieldTimer());

            isShieldActive = true;
            shieldQuantity--;
            PlayerPrefs.SetInt("Item_1_Quantity", shieldQuantity);
            Debug.Log($"Activated shield\nShields: {shieldQuantity}");
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
        if (!isTimeSlowed && slowTimeQuantity > 0)
        {
            Time.timeScale = .5f;

            StartCoroutine(SlowTimeTimer());

            isTimeSlowed = true;
            slowTimeQuantity--;
            PlayerPrefs.SetInt("Item_2_Quantity", slowTimeQuantity);
            Debug.Log($"Slow time\nBoosts: {slowTimeQuantity}");
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
