using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D10_Animator2_Door_Controller : MonoBehaviour
{
    public Animator animator;


    private void OnTriggerEnter(Collider other)
    {
        animator.speed = 1;
    }

    private void OnTriggerExit(Collider other)
    {
        animator.speed = 1;
    }
}


