using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D04_Mesh_Renderer : MonoBehaviour
{
    MeshFilter ThisMeshFilter;
    public GameObject Sphere, Capsule;
    //public Material Red, Green;

    void Start()
    {
        ThisMeshFilter = GetComponent<MeshFilter>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("mouse 0");
            ThisMeshFilter.mesh = Sphere.GetComponent<MeshFilter>().mesh;
        }
        if (Input.GetMouseButtonDown(1))
        {
            print("mouse 1");
            ThisMeshFilter.mesh = Capsule.GetComponent<MeshFilter>().mesh;
        }
        //if (Input.GetKeyDown(KeyCode.R))
        //{
        //    GetComponent<MeshRenderer>().material = Red;
        //}
        //if (Input.GetKeyDown(KeyCode.G))
        //{
        //    GetComponent<MeshRenderer>().material = Green;
        //}
    }
}
