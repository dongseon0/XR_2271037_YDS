using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class D08_Scene02_Controller : MonoBehaviour
{
    string UserInput;
    public TMP_Text Message;

    void Start()
    {
        UserInput = PlayerPrefs.GetString("Input"); // 넣을 땐 SetString, 가져올 땐 GetString
        if (string.IsNullOrEmpty(UserInput)) 
        {
            Message.text = "PlayerPrefs에 저장한 데이터가 없습니다.";
        }
        else
        {
            Message.text = UserInput;
        }
    }

    public void OnClick_LoadScene(Object SceneObject)
    {
        SceneManager.LoadScene(SceneObject.name);
    }
}
