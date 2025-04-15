using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D13_Item_Container : MonoBehaviour
{
    public GameObject Item;

    void Start()
    {
        int cloneCount =  10;
        for(int i=0;i<cloneCount;i++){
            Clone_Items(i);
        }
    }

    void Clone_Items(int id){
        Vector3 randomSphere = Random.insideUnitSphere*2.5f; // 일정한 sphere 영역 안에서의 xyz값 랜덤하게 줌
        //sphere의 0-1이내에서 랜덤한 좌표 줌. 원의 반지름 2.5f를 곱함.
        randomSphere.y = 0f;
        Vector3 randomPos = randomSphere + transform.position;
        
        float randomAngle = Random.value * 360;
        Quaternion randomRot = Quaternion.Euler(0, randomAngle, 0); 
        // y축만 랜덤앵글 값 줌 -> 회전치가 됨
        GameObject Clone = Instantiate(Item, randomPos, randomRot); //복제됨, (0,0,0)좌표에 생김, 부모도 설정 ㄴㄴ
 
        Clone.transform.SetParent(transform); //transform이 상속 담당
        Clone.name = "Clone-" + string.Format("{0:D4}", id);
    }
}
