using UnityEngine;
using UnityEngine.UI;

public class AudioManager : Singleton<AudioManager>
{
    [Header("UI")]
    public Slider volumeSlider;
    public Toggle backgroundMusicToggle;

    [Header("Audio Sources")]
    public AudioSource backgroundMusic;

    public void PlayBackgroundMusic(bool enable)
    {
        if (enable)
        {
            backgroundMusic.Play();
        }

        else
        {
            backgroundMusic.Stop();
        }
    }

    void Update()
    {
        backgroundMusic.volume = volumeSlider.value;
    }
}
