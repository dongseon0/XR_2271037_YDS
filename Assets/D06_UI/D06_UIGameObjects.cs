using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D06_UIGameObjects: MonoBehaviour 
{
    //메소드가 public인 이유는 버튼이란 객체가 이 메소드를 참조할 수 있어야 해서임, 반환은 void
    public void OnClick_Destroy(GameObject Target){
        Destroy(Target);
    }

    public void OnClick_LoadScene(){
        SceneManager.LoadScene(0); // 0번째 씬 로드
    }
}
