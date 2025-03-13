using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D04_Mesh_Renderer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(" hello world ");
        Debug.Log(gameObject.name); //Debug.Log == print   (?)
                // gameObject 클래스는 이 script를 갖고 있는 object를 가리킴. 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){ //Input -> 키 감지
                                            //GetKey --> 키를 꾹 눌러도 1번만 감지, GetKeyUp --> 키를 꾹 누르다가 떼면 감지
                                            //KeyCode.UpArrow --> 위쪽 방향키 코드 누르면 
            transform.Translate(0, 0, 1); // Translate --> 이동
        } 

        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0, 0, -1);
        }

        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Rotate(0, -1, 0); // Rotate -> 회전, 360도 단위로, -는 반시계 방향
        }

        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Rotate(0, 1, 0); 
        }

    }
}
