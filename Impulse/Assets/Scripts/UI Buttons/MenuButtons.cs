using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public void OnClickPlayButton()
    {
        Debug.Log("Play button pressed");
    }

    public void OnClickSettingsButton()
    {
        Debug.Log("Settings button pressed");
    }

    public void OnClickStoreButton()
    {
        Debug.Log("Store button pressed");
    }

    public void OnClickExitButton()
    {
        Debug.Log("Exit button pressed");
        Application.Quit();
    }

    public void OnClickAboutButton()
    {
        Debug.Log("About button pressed");
    }
}
