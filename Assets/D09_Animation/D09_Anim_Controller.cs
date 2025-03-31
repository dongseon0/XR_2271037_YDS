using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class D09_Anim_Controller : MonoBehaviour
{
    public Animator animator;
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
        }
        if(Input.GetKeyDown(KeyCode.O)){
            animator.speed = 0f;        // 공 정지
        }
    }
}
