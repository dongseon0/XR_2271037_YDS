using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class D08_Scene01_Controller : MonoBehaviour
{
    string UserInput = "";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            PlayerPrefs.DeleteAll();
        }
    }

    public void OnClick_AssignData(TMP_InputField InputField)
    {   //InputField에 입력하고 Onclick을 하면 
        UserInput = InputField.text; // 그 데이터를 UserInput에 할당
    }

    public void OnClick_Display_UserInput(TMP_Text Message)
    {
        Message.text = $"{UserInput}"; // UserInput 변수를 display
    }

    public void OnClick_DisplayAndSet_UserInput(TMP_Text Message)
    {
        Message.text = $"{UserInput}"; // UserInput 변수를 display
        PlayerPrefs.SetString("Input", Message.text); 
        // PlayerPrefs에 저장 --> 다음 Scene에서 읽을 수 있음
    }


    public void OnClick_LoadScene(Object SceneObject) // Asset 폴더의 Scene파일을 매개변수로
    {
        SceneManager.LoadScene(SceneObject.name);
    }
}
