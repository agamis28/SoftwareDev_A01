using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField] private AudioSource mainAudioSource;
    public void PlayAudio(AudioClip audio)
    {
        mainAudioSource.clip = audio;
        mainAudioSource.Play();
    }
}
