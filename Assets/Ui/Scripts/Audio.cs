using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider sliderVolume;

    void Start()
    {
        audioSource.Play();
    }

    public void SetMusicVolume()
    {
        audioSource.volume = sliderVolume.value;
    }
}
