using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public int ItamID = 4;
    public TMP_Text Price;
    public TMP_Text Quantity;
    public ShopManagerScr ShopManager;
    public SkinsBuy SkinsManager;


    void Start()
    {
        DisplayData();
        ShowData();
    }

    public void DisplayData()
    {
        ShopManagerScr.ShopItem Item = ShopManager.shopItems.FirstOrDefault(x => x.ID == ItemID);
        Price.text = Item.Price.ToString() + '₴';
        Quantity.text = Item.Quantity.ToString();
    }

    public void ShowData()
    {

        SkinsBuy.SkinItem Itam = SkinsManager.skinItems.FirstOrDefault(x => x.ID == ItamID);
        Price.text = Itam.Price.ToString() + '₴';
        if (!ReferenceEquals(Itam, null))
        {
            if (Itam.Toggle != null)
            {
                int toggleValue = PlayerPrefs.GetInt("Item_" + ItamID + "_Toggle", 0);
                Itam.Toggle.isOn = toggleValue == 1;
            }
            else
            {
                Debug.LogError("Toggle is null for SkinItem with ID: " + ItamID);
            }
            Price.text = Itam.Price.ToString() + '₴';
        }
        else
        {
            Debug.LogError("No SkinItem found with ID: " + ItamID);
        }
    }
}
