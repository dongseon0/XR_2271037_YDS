using UnityEngine;
using UnityEngine.Video;

public class HW_VideoController : MonoBehaviour
{
    public VideoPlayer tvVideo;  // TV 비디오
    public VideoPlayer boardVideo; // 보드 비디오

    void Start()
    {
        if (tvVideo != null)
            tvVideo.isLooping = true;
        
        if (boardVideo != null)
        {
            boardVideo.isLooping = true;
            boardVideo.Play(); // 보드 비디오는 기본적으로 실행
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ToggleVideo(tvVideo);
            ToggleVideo(boardVideo);
        }
    }

    void ToggleVideo(VideoPlayer video)
    {
        if (video != null)
        {
            if (video.isPlaying)
                video.Pause();
            else
                video.Play();
        }
    }

    void ToggleTVVideo()
    {
        ToggleVideo(tvVideo);
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼 클릭 감지
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("TV")) // "TV" 태그를 가진 오브젝트 감지
                {
                    ToggleTVVideo();
                }
            }
        }
    }
}
