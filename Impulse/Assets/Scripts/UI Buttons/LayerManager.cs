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
        OpenLayer(aboutLayer);
    }

    public void ClosePlayLayer()
    {
        CloseLayer(aboutLayer);
    }

    public void OpenSettingsLayer()
    {
        OpenLayer(aboutLayer);
    }

    public void CloseSettingsLayer()
    {
        CloseLayer(aboutLayer);
    }
    public void OpenStoreLayer()
    {
        OpenLayer(aboutLayer);
    }

    public void CloseStoreLayer()
    {
        CloseLayer(aboutLayer);
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
