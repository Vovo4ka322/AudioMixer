using UnityEngine;
using UnityEngine.Audio;

public class VolumeChanger : MonoBehaviour
{
    private const string OverallVolume = nameof(OverallVolume);
    private const string ButtonVolume = nameof(ButtonVolume);
    private const string BackgroundVolume = nameof(BackgroundVolume);

    [SerializeField] private AudioMixerGroup _mixerGroup;

    private readonly int _minValue = -80;
    private readonly int _maxValue = 20;

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
        _mixerGroup.audioMixer.SetFloat(name, Mathf.Lerp(_minValue, _maxValue, volume));
    }
}
