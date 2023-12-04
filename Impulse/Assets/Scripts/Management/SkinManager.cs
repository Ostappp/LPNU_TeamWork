using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinManager : MonoBehaviour
{
    public static SkinManager Instance;
    public Material DefaultSkin;
    private Material currentSkin;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void SetSkin(Material newSkin) => currentSkin = newSkin ? newSkin : DefaultSkin;

    public Material GetSkin() => currentSkin ? currentSkin : DefaultSkin;
}
