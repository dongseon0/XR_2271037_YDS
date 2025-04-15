using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D12_Bowl_Controller : MonoBehaviour
{
    public GameObject UI_Controller;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Heart")
        {
            print(other.name);
            UI_Controller.GetComponent<D12_UI_Controller>().Increase_PutCounter();
            Destroy(other.gameObject);
        }
    }
}
