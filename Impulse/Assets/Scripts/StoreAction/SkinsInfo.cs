//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using TMPro;
//using System.Linq;

//public class SkinsInfo : MonoBehaviour
//{
//    public int ItemID;
//    public TMP_Text Price;
//    public SkinsBuy SkinsManager;


//    void Start()
//    {
//        ShowData();
//    }

//    public void ShowData()
//    {
//        SkinsBuy.SkinsItem Item = SkinsManager.skinItems.Where(x => x.ID == ItemID).ToList()[0];
//        Price.text = Item.Price.ToString() + '₴';
//    }
//}