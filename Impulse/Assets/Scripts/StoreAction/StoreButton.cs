using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreButton : MonoBehaviour
{
    public GameObject storePanel; 
    public GameObject boostsPanel;
    public GameObject inventoryPanel; 
    public GameObject skinsPanel; 

    void Start()
    {
        storePanel.SetActive(true);
        boostsPanel.SetActive(false);
        inventoryPanel.SetActive(false);
        skinsPanel.SetActive(false);
    }

    public void OnClickBackButton()
    {
        Debug.Log("Back button pressed");
    }

    public void OnClickBoostsButton()
    {
        storePanel.SetActive(false);
        boostsPanel.SetActive(true);
    }

    public void OnClickInventoryButton()
    {
        storePanel.SetActive(false);
        inventoryPanel.SetActive(true);
    }

    public void OnClickSkinsButton()
    {
        storePanel.SetActive(false);
        skinsPanel.SetActive(true);
    }

    public void ExitButton()
    {
        storePanel.SetActive(true);
        boostsPanel.SetActive(false);
        inventoryPanel.SetActive(false);
        skinsPanel.SetActive(false);
    }

    public void ApplyButton()
    {
        Debug.Log("Apply button pressed");
    }
}
