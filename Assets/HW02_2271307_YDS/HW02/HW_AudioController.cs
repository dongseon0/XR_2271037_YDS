using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW_AudioController : MonoBehaviour
{
    public AudioSource radioAudio; // 라디오 오디오 소스
    public AudioSource ambientAudio; // 일상 소음 오디오 소스
    
    void Start()
    {
        // 오디오 루프 및 자동 재생 설정
        if (radioAudio != null)
            radioAudio.loop = true;
        
        if (ambientAudio != null)
        {
            ambientAudio.loop = true;
            ambientAudio.Play(); // 일상 소음은 기본적으로 실행
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ToggleAudio(radioAudio);
            ToggleAudio(ambientAudio);
        }
    }

    void ToggleAudio(AudioSource audio)
    {
        if (audio != null)
        {
            if (audio.isPlaying)
                audio.Pause();
            else
                audio.Play();
        }
    }

    void ToggleRadio()
    {
        ToggleAudio(radioAudio);
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0)) // 마우스 왼쪽 버튼 클릭 감지
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.CompareTag("Radio")) // "Radio" 태그를 가진 오브젝트 감지
                {
                    ToggleRadio();
                }
            }
        }
    }
}

