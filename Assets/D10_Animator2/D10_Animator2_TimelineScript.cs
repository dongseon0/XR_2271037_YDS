using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D10_Animator2_TimelineScript : MonoBehaviour
{
    public void OnFrameEnter_Stop()
    {
        GetComponent<Animator>().speed = 0;
    }
}
