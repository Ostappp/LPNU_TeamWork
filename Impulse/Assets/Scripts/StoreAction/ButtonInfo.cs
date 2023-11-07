using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public TMP_Text Price;
    public TMP_Text Quantity;
    public ShopManagerScr ShopManager;


    void Start()
    {
        DisplayData();
    }

    public void DisplayData()
    {
        ShopManagerScr.ShopItem Item = ShopManager.shopItems.Where(x => x.ID == ItemID).ToList()[0];
        Price.text = Item.Price.ToString() + '₴';
        Quantity.text = Item.Quantity.ToString();
    }
}
