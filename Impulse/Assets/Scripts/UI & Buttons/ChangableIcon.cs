using UnityEngine;
using UnityEngine.UI;

public class ChangableIcon : MonoBehaviour
{
    public RawImage buttonImage;
    public Texture OriginalIcon;
    public Texture IconForChange;

    private bool isIconChanged = false;

    public void ChangeImage()
    {
        if (isIconChanged)
        {
            buttonImage.texture = IconForChange;
        }
        else
        {
            buttonImage.texture = OriginalIcon;
        }

        isIconChanged = !isIconChanged;
    }
    public void SetOriginalIcon(bool value)
    {
        if (value)
        {
            buttonImage.texture = OriginalIcon;
        }
        else
        {
            buttonImage.texture = IconForChange;
        }

        isIconChanged = value;
    }
}
