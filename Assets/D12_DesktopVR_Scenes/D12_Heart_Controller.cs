using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D12_Heart_Controller : MonoBehaviour
{
    public GameObject Pick_Controller;
    //public GameObject UI_Controller;

    private void OnMouseDown()
    {
        Pick_Controller.GetComponent<D12_Pick_Controller>().OnHeartClicked(gameObject);
        print($"clicked {gameObject.name}");
    }
}
