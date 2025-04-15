using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class D12_UI_Controller : MonoBehaviour
{
    public TMP_Text Heart_PickCounts, Heart_PutCounts;
    int pickCounter, putCounter;

    void Start()
    {
        Heart_PickCounts.text = pickCounter.ToString();
        Heart_PutCounts.text = putCounter.ToString();
    }

    public void Increase_PickCounter()
    {
        print($"increase pickCounter");
        pickCounter ++;
        Heart_PickCounts.text = pickCounter.ToString();
    }

    public void Decrease_PickCounter()
    {
        print($"decrease pickCounter");
        pickCounter--;
        Heart_PickCounts.text = pickCounter.ToString();
    }

    public void Increase_PutCounter()
    {
        print($"increase putCounter");
        putCounter ++;
        Heart_PutCounts.text = putCounter.ToString();
    }


    public int GetPickCounts()
    {
        return pickCounter;
    }
}
