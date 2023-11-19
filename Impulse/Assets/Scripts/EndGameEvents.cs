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
        GameObject coinsText = GameObject.Find("CoinsCount");
        coinsText.GetComponent<TextMeshProUGUI>().text = Reward.ToString();


        WinView?.SetActive(true);
    }
}
