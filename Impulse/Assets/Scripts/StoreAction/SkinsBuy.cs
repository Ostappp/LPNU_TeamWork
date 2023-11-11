using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System;

public class SkinsBuy : MonoBehaviour
{
    public SkinItem[] skinItems;
    public ShopManagerScr ShopManager;

    void Start()
    {
        LoadToggles();
    }


    void LoadToggles()
    {
        for (int i = 0; i < skinItems.Length; i++)
        {
            int toggleState = PlayerPrefs.GetInt("Item_" + skinItems[i].ID + "_Toggle", 0);
            skinItems[i].Toggle.isOn = toggleState == 1;
        }
    }


    public void Buy(ButtonInfo ButtonRef)
    {
        SkinItem Item = skinItems.FirstOrDefault(x => x.ID == ButtonRef.ItemID);

        if (!Item.Equals(default(SkinItem)) && !Item.Toggle.isOn)
        {
            ShopManager.SpendMoney(Item.Price);
            Item.Toggle.isOn = true;
            PlayerPrefs.SetInt("Item_" + ButtonRef.ItemID + "_Toggle", 1);

        }

    }

    [System.Serializable]
    public struct SkinItem
    {
        public int ID;
        public int Price;
        public Toggle Toggle;
    }

}
