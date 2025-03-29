using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoad : MonoBehaviour
{
    string UserInput = "";

    void Update()
    {}

    public void OnClick_LoadScene(Object SceneObject) // Asset 폴더의 Scene파일을 매개변수로
    {
        SceneManager.LoadScene(SceneObject.name);
    }
}
