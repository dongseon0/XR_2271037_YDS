using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW_StreetLamp : MonoBehaviour
{
    int state;
    public GameObject StreetLamp;



    void Start()
    {
        state = 0;
        StreetLamp.SetActive(true);
;    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.U)){
            StreetLamp.SetActive(false);
        }
    }
}
