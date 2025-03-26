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
    {
        UserInput = InputField.text;
    }

    public void OnClick_Display_UserInput(TMP_Text Message)
    {
        Message.text = $"{UserInput}";
    }

    public void OnClick_DisplayAndSet_UserInput(TMP_Text Message)
    {
        Message.text = $"{UserInput}";
        PlayerPrefs.SetString("Input", Message.text);
    }


    public void OnClick_LoadScene(Object SceneObject)
    {
        SceneManager.LoadScene(SceneObject.name);
    }
}
