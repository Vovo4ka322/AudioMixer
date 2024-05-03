using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class ChangingVolume : MonoBehaviour
{
    private const string OverallVolume = nameof(OverallVolume);
    private const string ButtonVolume = nameof(ButtonVolume);
    private const string BackgroundVolume = nameof(BackgroundVolume);

    [SerializeField] private AudioMixerGroup _mixerGroup;

    public void ChangeOverallVolume(float volume)
    {
        ChangeVolume(volume, OverallVolume);
    }

    public void ChangeButtonVolume(float volume) 
    {
        ChangeVolume(volume, ButtonVolume);
    }

    public void ChangeBackgroundVolume(float volume) 
    {
        ChangeVolume(volume, BackgroundVolume);
    }

    private void ChangeVolume(float volume, string name)
    {
        _mixerGroup.audioMixer.SetFloat(name, Mathf.Lerp(-80, 20, volume));
    }
}
