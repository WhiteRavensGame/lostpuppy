using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;

    private bool isMuted;

    private void Start()
    {
        isMuted = PlayerPrefs.GetInt("Muted") == 1;
        AudioListener.pause = isMuted;
    }
    // Start is called before the first frame update
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        //Debug.Log(volume);
    }

    public void SetFullscreen(bool isFullscreen)

    {
        Screen.fullScreen = isFullscreen;
    }
    public void MuteGame()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        PlayerPrefs.SetInt("Muted", isMuted ? 1 : 0);
    }
}

