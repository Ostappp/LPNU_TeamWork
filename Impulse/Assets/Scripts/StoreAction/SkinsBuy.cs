//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.EventSystems;
//using UnityEngine.UI;
//using TMPro;
//using System.Linq;
//using System;

//public class SkinsBuy : MonoBehaviour
//{
//    public Toggle[] skinToggles; // ����� Toggle ��� ������� ���� 
//    public SkinsItem[] skinItems;
//    public TMP_Text CoinsTXT;
//    public int coins;


//    void Start()
//    {
//        coins = PlayerPrefs.GetInt("Coins value", 10000);
//        CoinsTXT.text = "Coins:" + coins.ToString();
//        // ������������ ������� �������� ���� ��� ����������� ���
//        for (int i = 0; i < skinToggles.Length; i++)
//        {
//            if (PlayerPrefs.GetInt("Skin_" + i, 0) == 1)
//            {
//                skinToggles[i].isOn = true; // ������������ Toggle � ��������� "��������"
//                skinToggles[i].interactable = false; // �������� ���� ������� �������
//            }
//        }
//    }
//    public void SpendMoney(int CoinsToSpend)
//    {
//        if (coins >= CoinsToSpend)
//        {
//            coins -= CoinsToSpend;
//            PlayerPrefs.SetInt("Coins value", coins);
//            CoinsTXT.text = "Coins:" + coins.ToString();
//        }
//    }
//    public void BuySkin(SkinsInfo ButtonRef)
//    {
//        SkinsItem Item = skinItems.FirstOrDefault(x => x.ID == ButtonRef.ItemID);
//        if (!Item.Equals(default(SkinsItem)) && coins >= Item.Price && PlayerPrefs.GetInt("Skin_" + Item.ID, 0) != 1)
//        {

//            SpendMoney(Item.Price);
//            PlayerPrefs.SetInt("Skin_" + Item.ID, 1); // ���������� ������� ����
//            UpdateSkinToggles();

//        }
//    }

//    public void UpdateSkinToggles()
//    {
//        for (int i = 0; i < skinToggles.Length; i++)
//        {
//            if (PlayerPrefs.GetInt("Skin_" + skinItems[i].ID, 0) == 1)
//            {
//                skinToggles[i].isOn = true;
//                skinToggles[i].interactable = false;
//            }
//        }
//    }

//    [System.Serializable]
//    public struct SkinsItem
//    {
//        public int ID;
//        public int Price;
//    }
//}
