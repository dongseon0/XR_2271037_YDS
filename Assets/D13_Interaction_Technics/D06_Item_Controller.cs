using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D06_Item_Controller : MonoBehaviour
{
    public GameObject PickController;   // Step03 (D06_Pick_Controller.cs를 갖고 있는 게임 오브젝트용 변수)
    private void OnMouseDown()
    {
        PrintInfo();                    // Step01
        PickController.GetComponent<D06_Pick_Controller>().Add_Click(gameObject); // Step03
    }

    // Step01: 게임 오브젝트의 이름 출력
    void PrintInfo()
    {
        print($"{gameObject.name}을/를 클릭했습니다.");
    }
}
