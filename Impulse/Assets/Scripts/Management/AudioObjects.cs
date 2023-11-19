using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioObjects : MonoBehaviour
{

    public AudioSource LevelMusic;
    public List<AudioElement> ObjectsWithAudio;
    // Start is called before the first frame update
    void Start()
    {
        ChangeVolumeAndMute();
        SettingsManager.Instance.ChangedSettings += ChangeVolumeAndMute;
    }


    private void ChangeVolumeAndMute()
    {
        if (LevelMusic != null)
        {
            LevelMusic.mute = SettingsManager.Instance.IsVolumeMuted() || SettingsManager.Instance.IsMusicMuted();
            LevelMusic.volume = SettingsManager.Instance.GetCalulatedMusicValue();
        }

        if (ObjectsWithAudio != null)
            foreach (AudioElement element in ObjectsWithAudio)
            {
                element.audio.mute = SettingsManager.Instance.IsVolumeMuted() || SettingsManager.Instance.IsEnvironmentMuted();
                element.audio.volume = SettingsManager.Instance.GetCalulatedEnvironmentValue() * element.volume;
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
