using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using System;

public class ShopManagerScr : MonoBehaviour
{
    public ShopItem[] shopItems;
    public int coins;
    public TMP_Text CoinsTXT;

    void Start()
    {
        coins = PlayerPrefs.GetInt("Coins value", 10000);
        CoinsTXT.text = "Coins:" + coins.ToString();

        LoadQuantities();
    }

    void LoadQuantities()
    {
        for (int i = 0; i < shopItems.Length; i++)
        {
            int quantity = PlayerPrefs.GetInt("Item_" + shopItems[i].ID + "_Quantity", 0);
            shopItems[i].Quantity = quantity;

        }
    }

    public void SpendMoney(int CoinsToSpend)
    {
        if (coins >= CoinsToSpend)
        {
            coins -= CoinsToSpend;
            PlayerPrefs.SetInt("Coins value", coins);
            CoinsTXT.text = "Coins:" + coins.ToString();
        }
    }

    public void Buy(ButtonInfo ButtonRef)
    {
        ShopItem Item = shopItems.FirstOrDefault(x => x.ID == ButtonRef.ItemID);

        if (!Item.Equals(default(ShopItem)) && coins >= Item.Price)
        {
            SpendMoney(Item.Price);
            IncreaseQuantity(ButtonRef.ItemID);
            ButtonRef.Quantity.text = PlayerPrefs.GetInt("Item_" + ButtonRef.ItemID + "_Quantity").ToString();

        }
    }

    public void IncreaseQuantity(int ItemID)
    {
        int index = System.Array.FindIndex(shopItems, x => x.ID == ItemID);

        if (index != -1)
        {
            shopItems[index].Quantity++;
            PlayerPrefs.SetInt("Item_" + ItemID + "_Quantity", shopItems[index].Quantity);

        }
    }
  
    [System.Serializable]
    public struct ShopItem
    {
        public int ID;
        public int Price;
        public int Quantity;
    }
   
}