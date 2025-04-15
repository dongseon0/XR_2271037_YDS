using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D06_Bowl_Controller : MonoBehaviour
{
    public GameObject UI_Controller;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            UI_Controller.GetComponent<D06_UI_Controller>().Display_PutCounts();
            Destroy(other.gameObject);
        }
    }
}