using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseMoneyBonus : MonoBehaviour
{
    private int bonusQuantity;
    public Button bonusButton;
    public EndGameEvents endGameEvents;
    private void Start()
    {
        bonusQuantity = PlayerPrefs.GetInt("Item_3_Quantity", 0);
        if (bonusQuantity <= 0)
            bonusButton.enabled = false;
    }
    public void UseBonus()
    {
        if (bonusQuantity > 0)
        {
            bonusQuantity--;
            PlayerPrefs.SetInt("Item_3_Quantity", bonusQuantity);
            bonusButton.enabled = false;
            endGameEvents.RewardPlayer();
        }
    }

}
