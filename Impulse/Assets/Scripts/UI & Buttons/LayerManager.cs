using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerManager : MonoBehaviour
{
    public GameObject mainMenuLayer;
    public GameObject aboutLayer;
    public GameObject playLayer;
    public GameObject setttingsLayer;
    public GameObject setttingsItems;
    public GameObject controlsLayer;
    public GameObject storeLayer;
    // Start is called before the first frame update
    void Start()
    {
        mainMenuLayer.SetActive(true);
        playLayer.SetActive(false);
        controlsLayer.SetActive(false);
        setttingsLayer.SetActive(false);
        storeLayer.SetActive(false);
        aboutLayer.SetActive(false);
    }

    public void OpenLayer(GameObject layer)
    {
        if (layer != null && mainMenuLayer != null && layer != mainMenuLayer)
        {
            if (layer != controlsLayer)
            {

                mainMenuLayer.SetActive(false);
            }
            else
            {
                setttingsItems.SetActive(false);
            }
            layer.SetActive(true);
        }
    }
    public void CloseLayer(GameObject layer)
    {
        if (layer != null && mainMenuLayer != null && layer != mainMenuLayer)
        {
            if(layer != controlsLayer)
            {

                mainMenuLayer.SetActive(true);
            }
            else
            {
                setttingsItems.SetActive(true);
            }
            layer.SetActive(false);
        }
    }
}
