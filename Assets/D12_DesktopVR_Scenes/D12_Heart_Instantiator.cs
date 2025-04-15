using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D12_Heart_Instantiator : MonoBehaviour
{
    int cloneCount = 10;
    public GameObject TargetObjectToClone;

    void Start()
    {
        InstantiateHearts();
    }

    public void InstantiateHearts()
    {
        for(int i = 0; i < cloneCount; i++)
        {
            // Set Random Position
            Vector3 randomSphere = Random.insideUnitSphere * 5;
            randomSphere.y = 0.5f;
            Vector3 randomPos = randomSphere + transform.position;

            // Set Random Rotation
            float randomAngle = Random.value * 360f;
            Quaternion randomRot = Quaternion.Euler(new Vector3(0, randomAngle, 0));

            // Instantiate GameObject
            GameObject Clone = Instantiate(TargetObjectToClone, randomPos, randomRot);
            Clone.transform.SetParent(transform);
            if(Clone.activeSelf == false)
            {
                Clone.SetActive(true);
            }
        }
    }
}
