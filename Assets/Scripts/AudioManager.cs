using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : Singleton<AudioManager>
{
    public AudioSource wing,hit,ButtonSound,die,point;
    public AudioMixer mixer;
    public Slider musicSlider,sfxSlider;
    private const string MIXER_MUSIC ="MusicVolume";
    private const string MIXER_SFX ="SFXVolume";

    public override void Awake()
    {
        {
            base.Awake();
            musicSlider.onValueChanged.AddListener(SetMusicVolume);
            sfxSlider.onValueChanged.AddListener(SetSFXVolume);
        }
    }

    private void SetMusicVolume(float value)
    {
        mixer.SetFloat(MIXER_MUSIC, Mathf.Log10(value)*20);
    }
    private void SetSFXVolume(float value)
    {
        mixer.SetFloat(MIXER_SFX, Mathf.Log10(value)*20);
    }

    public void PlayWing()
    {
        wing.Play();
    }

    public void PlayPoint()
    {
        point.Play();
    }

    public void PlayDie()
    {
        die.Play();
    }

    public void PlayHit()
    {
        hit.Play();
    }
    public void PlayButton()
    {
        ButtonSound.Play();
    }
}
