using UnityEngine;
using UnityEngine.Video;

public class HW_VideoController : MonoBehaviour
{
    public VideoPlayer[] Videos; 

    void Start()
    {
        foreach (var video in Videos)
        {
            video.Play();
            video.isLooping = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            foreach (var video in Videos)
            {
                if (video.isPlaying)
                {
                    video.Pause();
                }
                else
                {
                    video.Play();
                }
            }
        }
    }
}
