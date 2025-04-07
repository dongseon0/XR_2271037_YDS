using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D10_Animator1_Door_Controller : MonoBehaviour
{
    public Animator Animator;

    private void OnTriggerEnter(Collider other)
    {
        Animator.SetInteger("status", 1);
    }

    private void OnTriggerExit(Collider other)
    {
        Animator.SetInteger("status", 2);
    }
}
