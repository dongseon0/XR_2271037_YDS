using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D07_Sample_Lantern : MonoBehaviour
{
    int state;
    public GameObject Lantern;



    void Start()
    {
        state = 0;
        Lantern.SetActive(false);
;    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L)){
            Lantern.SetActive(true);
        }
    }
}
