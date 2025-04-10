using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleEvent : MonoBehaviour
{
    public Animator animator;

    // 애니메이션 이벤트에서 호출됨
    public void OnReachStopPoint()
    {
        StopCar();
    }

    // 애니메이션 정지
    public void StopCar()
    {
        animator.speed = 0f;
    }

    // 애니메이션 재개
    public void ResumeCar()
    {
        animator.speed = 1f;
    }
}
