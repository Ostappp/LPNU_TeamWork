using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerManager : MonoBehaviour
{
    public GameObject mainMenuLayer;
    public GameObject aboutLayer;
    public GameObject playLayer;
    public GameObject setttingsLayer;
    public GameObject storeLayer;
    // Start is called before the first frame update
    void Start()
    {
        mainMenuLayer.SetActive(true);
        playLayer.SetActive(false);
        setttingsLayer.SetActive(false);
        storeLayer.SetActive(false);
        aboutLayer.SetActive(false);
    }

    

    public void OpenPlayLayer()
    {
        OpenLayer(playLayer);
    }

    public void ClosePlayLayer()
    {
        CloseLayer(playLayer);
    }

    public void OpenSettingsLayer()
    {
        OpenLayer(setttingsLayer);
    }

    public void CloseSettingsLayer()
    {
        CloseLayer(setttingsLayer);
    }
    public void OpenStoreLayer()
    {
        OpenLayer(storeLayer);
    }

    public void CloseStoreLayer()
    {
        CloseLayer(storeLayer);
    }
    public void OpenAboutLayer()
    {
        OpenLayer(aboutLayer);
    }

    public void CloseAboutLayer()
    {
        CloseLayer(aboutLayer);
    }
    private void OpenLayer(GameObject layer)
    {
        if (layer != null && mainMenuLayer != null && layer != mainMenuLayer)
        {
            mainMenuLayer.SetActive(false);
            layer.SetActive(true);
        }
    }
    private void CloseLayer(GameObject layer)
    {
        if (layer != null && mainMenuLayer != null && layer != mainMenuLayer)
        {
            mainMenuLayer.SetActive(true);
            layer.SetActive(false);
        }
    }
}
