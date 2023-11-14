using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static SkinsBuy;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public GameObject Template;
    public Transform Holder;
    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void SetSkin(SkinItem skin)
    {
        GameObject skinItem = Instantiate(Template, Holder);
        skinItem.transform.GetChild(0).GetComponent<RawImage>().texture = skin.Icon;
        skinItem.transform.GetChild(1).GetComponent<ApplySkinButton>().Skin = skin.Skin;
    }
}
