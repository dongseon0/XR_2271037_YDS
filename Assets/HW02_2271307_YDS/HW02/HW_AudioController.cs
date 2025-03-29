using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW_AudioController : MonoBehaviour
{
    public AudioSource[] Audio; // 두 개 이상의 AudioSource를 저장할 배열

    void Start()
    {   
            foreach (var audio in Audio)
            {
                audio.loop = true;  // 각 오디오에 반복 설정
                audio.Play();       // 각 오디오 재생
            }
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            foreach (var audio in Audio)
            {
                if (audio.isPlaying)
                {
                    audio.Pause(); // 오디오가 재생 중이면 일시 정지
                }
                else
                {
                    audio.Play(); // 오디오가 정지 상태이면 재생
                }
            }
        }
    }
}
