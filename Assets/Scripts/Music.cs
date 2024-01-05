using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    private AudioSource backgroundMusic;
    private float originalVolume;

    void Start()
    {
        backgroundMusic = GetComponent<AudioSource>();
        originalVolume = backgroundMusic.volume;
    }

    public void OnPauseButtonClick()
    {
        PauseMusic();
    }

    public void OnContinueButtonClick()
    {
        ContinueMusic();
    }

    void PauseMusic()
    {
        if (backgroundMusic.isPlaying)
        {
            backgroundMusic.Pause();
        }
    }

    void ContinueMusic()
    {
        if (!backgroundMusic.isPlaying)
        {
            backgroundMusic.UnPause();
        }
    }
}
