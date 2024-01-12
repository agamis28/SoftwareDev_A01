using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    [SerializeField] private AudioSource mainAudioSource;
    public void PlayAudio(AudioClip audio)
    {
        mainAudioSource.clip = audio;
        mainAudioSource.Play();
    }
}
