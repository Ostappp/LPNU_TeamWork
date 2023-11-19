using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;

public class AudioObjects : MonoBehaviour
{

    public AudioSource LevelMusic;
    public List<AudioElement> ObjectsWithAudio;
    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(WaitForSettingsManager());

    }

    private void ChangeVolumeAndMute()
    {
        Debug.Log($"SettingsManager.Instance != null: {SettingsManager.Instance != null}");

        if (SettingsManager.Instance != null)
        {
            if (LevelMusic != null)
            {
                LevelMusic.mute = SettingsManager.Instance.IsVolumeMuted() || SettingsManager.Instance.IsMusicMuted();
                LevelMusic.volume = SettingsManager.Instance.GetCalulatedMusicValue();
            }

            if (ObjectsWithAudio != null)
            {
                StartCoroutine(WaitForAudioObjects());                
            }

        }


    }
    private IEnumerator WaitForSettingsManager()
    {
        while (SettingsManager.Instance == null)
        {
            yield return null;
        }
        ChangeVolumeAndMute();
        SettingsManager.Instance.ChangedSettings -= ChangeVolumeAndMute;
        SettingsManager.Instance.ChangedSettings += ChangeVolumeAndMute;
    }
    private IEnumerator WaitForAudioObjects()
    {
        while (ObjectsWithAudio.Any(e => e.audio == null))
        {
            yield return null;
        }
        bool muteVolume = SettingsManager.Instance.IsVolumeMuted();
        bool muteEnvironment = SettingsManager.Instance.IsEnvironmentMuted();
        float elementBaseVolume = SettingsManager.Instance.GetCalulatedEnvironmentValue();
        foreach (AudioElement element in ObjectsWithAudio)
        {
            element.audio.mute = muteVolume || muteEnvironment;
            element.audio.volume = elementBaseVolume * element.volume;
        }
    }
    [System.Serializable]
    public struct AudioElement
    {
        [Range(0, 1f)]
        public float volume;
        public AudioSource audio;
    }
}
