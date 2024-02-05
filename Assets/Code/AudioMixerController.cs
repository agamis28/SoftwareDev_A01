using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerController : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void SetBruhVolume(float sliderValue)
    {
        audioMixer.SetFloat("BruhVolume", Mathf.Log10(sliderValue) * 20);
    }
    public void SetBruhDistortion(float sliderValue)
    {
        audioMixer.SetFloat("BruhDistortion", sliderValue);
    }
    public void SetBruhPitch(float sliderValue)
    {
        audioMixer.SetFloat("BruhPitch", sliderValue);
    }
}
