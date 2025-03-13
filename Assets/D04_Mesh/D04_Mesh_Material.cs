using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class D04_Mesh_Material : MonoBehaviour
{
    MeshFilter ThisMeshFilter;
    public GameObject Sphere, Capsule; //이러고 유니티 안에서 스크립트 inspector에 비활성화한 sphere와 capsule을 드래그드롭해준다.

    // Start is called before the first frame update
    void Start()
    {
        ThisMeshFilter = GetComponent<MeshFilter>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){//0은 왼쪽 버튼, 1은 오른쪽(sub) 버튼
            ThisMeshFilter.mesh = Sphere.GetComponent<MeshFilter>().mesh; //ThisMeshFilter의 매쉬를 스피어의 매쉬필터 컴포넌트를 가져와서 할당
        } 
        if(Input.GetMouseButtonDown(1)){
            ThisMeshFilter.mesh = Capsule.GetComponent<MeshFilter>().mesh; //ThisMeshFilter의 매쉬를 스피어의 매쉬필터 컴포넌트를 가져와서 할당
        } 
    }
}
