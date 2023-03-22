using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    private void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        SelectVideoClip();
    }

    public void SelectVideoClip()
    {
        videoPlayer.clip = Resources.Load<VideoClip>("Videos/game_over_" + GameManagerBis.Instance.numGameOver);
    }
}