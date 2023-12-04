using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndGameEvents : MonoBehaviour
{
    [Min(1)]
    public int Reward;

    public GameObject WinView;
    public GameObject LooseView;

    [SerializeField]
    private PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        WinView?.SetActive(false);
        LooseView?.SetActive(false);


        player.PlayerWin += GameWin;
        player.PlayerLoose += GameLoose;
    }

    void GameLoose()
    {
        LooseView?.SetActive(true);
    }
    void GameWin()
    {
        WinView?.SetActive(true);
        GameObject coinsText = GameObject.Find("CoinsCount");
        coinsText.GetComponent<TMP_Text>().text = Reward.ToString();

        
        RewardPlayer();
    }
    public void RewardPlayer()
    {
        int coins = PlayerPrefs.GetInt("Coins value", 0);
        coins += Reward;
        PlayerPrefs.SetInt("Coins value", coins);

        GameObject bonusText = GameObject.Find("BonusCountInfo");
        bonusText.GetComponent<TMP_Text>().text = $"Available x2 multipliers count: {PlayerPrefs.GetInt("Item_3_Quantity", 0)}";
    }
}
