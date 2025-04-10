using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ride_Controller : MonoBehaviour
{
    public Animator animator;
    public GameObject vehicleObject;

    private VehicleEvent vehicleEvent;
    public bool isRiding = false;
    

    private void Start()
    {
        vehicleEvent = vehicleObject.GetComponent<VehicleEvent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Vehicle")){
            Debug.Log($"Vehicle: {other.name}");
            isRiding = true;
            transform.SetParent(other.transform);
            transform.position = other.transform.position + Vector3.up*2f;

            animator.SetTrigger("StartCar");
            vehicleEvent.ResumeCar(); // 자동차 애니메이션 재개
        }
    }

    private void OnTriggerExit(Collider other) 
    {   
        if(other.CompareTag("Vehicle")){
            isRiding = false;
            transform.SetParent(null);
            
            vehicleEvent.StopCar();
        }
    }
}
