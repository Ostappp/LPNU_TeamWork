using System;
using UnityEngine;

public class SettingsManager : MonoBehaviour
{
    public static SettingsManager Instance { get; private set; }
    public event Action ChangedSettings;

    [SerializeField]
    private bool _isVolumeMuted = false;
    [Range(0f, 1f), SerializeField]
    private float _volumeValue = 1;

    [SerializeField]
    private bool _isMusicMuted = false;
    [Range(0f, 1f), SerializeField]
    private float _musicValue = 1;

    [SerializeField]
    private bool _isEnvironmentMuted = false;
    [Range(0f, 1f), SerializeField]
    private float _environmentValue = 1;
    
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        _volumeValue = PlayerPrefs.GetFloat("volumeValue", 1);
        _musicValue = PlayerPrefs.GetFloat("musicValue", 1);
        _environmentValue = PlayerPrefs.GetFloat("environmentValue", 1);

        _isVolumeMuted = PlayerPrefs.GetInt("muteVolume", 0) > 0;
        _isMusicMuted = PlayerPrefs.GetInt("muteMusic", 0) > 0;
        _isEnvironmentMuted = PlayerPrefs.GetInt("muteEnvironment", 0) > 0;
    }

    public void SetVolumeValue(float value)
    {
        _volumeValue = value;
        PlayerPrefs.SetFloat("volumeValue", _volumeValue);
        ChangedSettings?.Invoke();
    }
    public void SetMusicValue(float value)
    {
        _musicValue = value;
        PlayerPrefs.SetFloat("musicValue", _musicValue);
        ChangedSettings?.Invoke();
    }
    public void SetEnvironmentValue(float value)
    {
        _environmentValue = value;
        PlayerPrefs.SetFloat("environmentValue", _environmentValue);
        ChangedSettings?.Invoke();
    }

    public float GetVolumeValue() => _volumeValue;
    public float GetMusicValue() => _musicValue;
    public float GetEnvironmentValue() => _environmentValue;

    public void MuteVolume()
    {
        _isVolumeMuted = !_isVolumeMuted;
        PlayerPrefs.SetInt("muteVolume", _isVolumeMuted ? 1 : 0);
        ChangedSettings?.Invoke();

    }
    public void MuteMusic()
    {
        _isMusicMuted = !_isMusicMuted;
        PlayerPrefs.SetInt("muteMusic", _isMusicMuted ? 1 : 0);
        ChangedSettings?.Invoke();
    }
    public void MuteEnvironment()
    {
        _isEnvironmentMuted = !_isEnvironmentMuted;
        PlayerPrefs.SetInt("muteEnvironment", _isEnvironmentMuted ? 1 : 0);
        ChangedSettings?.Invoke();
    }

    public bool IsVolumeMuted() => _isVolumeMuted;
    public bool IsMusicMuted() => _isMusicMuted;
    public bool IsEnvironmentMuted() => _isEnvironmentMuted;

    public float GetCalulatedMusicValue() => _volumeValue * _musicValue;
    public float GetCalulatedEnvironmentValue() => _volumeValue * _environmentValue;
}
