using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleEvent : MonoBehaviour
{
    private bool goingToFirst = false; // false: 첫 → 둘째, true: 둘째 → 첫

    public Animator animator;

    // 애니메이션 이벤트에서 호출됨
    public void OnReachStopPoint()
    {
        if (goingToFirst)
        {
            // 첫 장소 도착 → 멈춰야 함
            StopCar();
        }
        else
        {
            // 둘째 장소 도착 → 멈춰야 함
            StopCar();
        }

        // 다음 이동은 반대 방향으로
        goingToFirst = !goingToFirst;
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
