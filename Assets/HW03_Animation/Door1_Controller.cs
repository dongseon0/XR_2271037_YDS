using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door1_Controller : MonoBehaviour
{
    public Animator animator;
    public bool isPlayerInside = false;
    public bool isOpen = false;

    public void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        isPlayerInside = true;
        
        Vector3 toPlayer = (other.transform.position - transform.position).normalized; //문에서 플레이어를 향한 방향 벡터 계산
        Vector3 doorForward = transform.forward;
        float dot = Vector3.Dot(doorForward, toPlayer);

        if (dot < 0) //내적 계산으로 방향 확인
        {
            animator.SetTrigger("OpenForward");
            
            
        }
        else
        {
            animator.SetTrigger("OpenBackward");
        }

        isOpen = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (!other.CompareTag("Player")) return;
            animator.SetTrigger("Keep");
    }

    public void OnTriggerExit(Collider other) {
        if (!other.CompareTag("Player")) return;

        isPlayerInside = false;
        animator.SetTrigger("Close");
        isOpen = false;
    }

}