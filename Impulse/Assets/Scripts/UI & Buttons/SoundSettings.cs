using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SoundSettings : MonoBehaviour
{
    public SoundOption Volume;
    public SoundOption Music;
    public SoundOption Environment;

    private void Start()
    {
        Volume.Slider.value = SettingsManager.Instance.GetVolumeValue();
        Music.Slider.value = SettingsManager.Instance.GetMusicValue();
        Environment.Slider.value = SettingsManager.Instance.GetEnvironmentValue();

        Volume.InputField.text = SettingsManager.Instance.GetVolumeValue().ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        Music.InputField.text = SettingsManager.Instance.GetMusicValue().ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        Environment.InputField.text = SettingsManager.Instance.GetEnvironmentValue().ToString("F2", System.Globalization.CultureInfo.InvariantCulture);


        Volume.MuteButton.SetOriginalIcon(!SettingsManager.Instance.IsVolumeMuted());
        Music.MuteButton.SetOriginalIcon(!SettingsManager.Instance.IsMusicMuted());
        Environment.MuteButton.SetOriginalIcon(!SettingsManager.Instance.IsEnvironmentMuted());

    }

    public void InputValue_Volume()
    {
        ChangeValueFromInputField(Volume.InputField, Volume.Slider);
        SettingsManager.Instance.SetVolumeValue(Volume.Slider.value);
    }
    public void InputValue_Music()
    {
        ChangeValueFromInputField(Music.InputField, Music.Slider);
        SettingsManager.Instance.SetMusicValue(Music.Slider.value);
    }
    public void InputValue_Environment()
    {
        ChangeValueFromInputField(Environment.InputField, Environment.Slider);
        SettingsManager.Instance.SetEnvironmentValue(Environment.Slider.value);
    }

    public void ChangeValue_Volume()
    {
        ChangeValueFromSlider(Volume.Slider, Volume.InputField);
        SettingsManager.Instance.SetVolumeValue(Volume.Slider.value);
    }
    public void ChangeValue_Music()
    {
        ChangeValueFromSlider(Music.Slider, Music.InputField);
        SettingsManager.Instance.SetMusicValue(Music.Slider.value);
    }
    public void ChangeValue_Environment()
    {
        ChangeValueFromSlider(Environment.Slider, Environment.InputField);
        SettingsManager.Instance.SetEnvironmentValue(Environment.Slider.value);
    }

    public void Mute_Volume()
    {
        Volume.MuteButton.ChangeImage();
        SettingsManager.Instance.MuteVolume();
    }
    public void Mute_Music()
    {
        Music.MuteButton.ChangeImage();
        SettingsManager.Instance.MuteMusic();
    }
    public void Mute_Environment()
    {
        Environment.MuteButton.ChangeImage();
        SettingsManager.Instance.MuteEnvironment();
    }
    private void ChangeValueFromInputField(TMP_InputField textField, Slider slider)
    {
        float value;
        if (float.TryParse(textField.text, out value))
        {
            textField.text = value.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }

        slider.value = value;

        Debug.Log(value);
    }
    private void ChangeValueFromSlider(Slider slider, TMP_InputField textField)
    {
        textField.text = slider.value.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
    }

    [System.Serializable]
    public struct SoundOption
    {
        public ChangableIcon MuteButton;
        public Slider Slider;
        public TMP_InputField InputField;
    }
}
