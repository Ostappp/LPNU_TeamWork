using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccessLevelManager : MonoBehaviour
{
    [SerializeField]
    public List<Button> levels;

    private void Start()
    {
        if (levels != null && levels.Count > 1)
        {
            levels[0].interactable = true;
            for (int i = 1; i < levels.Count; i++)
            {
                levels[i].interactable = PlayerPrefs.GetInt($"Level{i + 1}_Access", 0) > 0;
            }
        }
            

    }
}
