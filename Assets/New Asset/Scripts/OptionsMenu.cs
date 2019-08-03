using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour {

    public AudioMixer MainMixer;

    public void SetVolume(float volume)
    {
        MainMixer.SetFloat("volume", volume); //("nama exposed parameter (volume) yang ada di unity", valuenya)
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool isFullScreen)
    {
        Debug.Log("Fullscreen Enabled");
        Screen.fullScreen = isFullScreen;
    }
}
