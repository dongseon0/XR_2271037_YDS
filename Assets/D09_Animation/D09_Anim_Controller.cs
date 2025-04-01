using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class D09_Anim_Controller : MonoBehaviour
{
    public Animator animator;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        animator.speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            animator.speed = 1f;        // 공 재생
            slider.value = 1f;
        }
        if(Input.GetKeyDown(KeyCode.O)){
            animator.speed = 0f;        // 공 정지
            slider.value = 0f;
        }
    }

    public void OnSlider_SetSpeed(){
        animator.speed = slider.value; // 공의 속도 = 슬라이더의 속도
    }
}
