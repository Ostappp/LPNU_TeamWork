using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplySkinButton : MonoBehaviour
{
    public Material Skin;
    public void ApplySkin() => SkinManager.Instance.SetSkin(Skin);
}
