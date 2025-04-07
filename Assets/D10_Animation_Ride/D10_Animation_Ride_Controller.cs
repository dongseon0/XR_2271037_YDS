using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D10_Animation_Ride_Controller : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Vehicle")
        {
            transform.SetParent(other.transform);
            transform.position = other.transform.position + Vector3.up * 2f;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Vehicle")
        {
            transform.SetParent(null);
        }
    }
}
