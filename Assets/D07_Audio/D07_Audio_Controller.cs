using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D07_Audio_Controller : MonoBehaviour
{
    public AudioSource[] Audio;
    void Start()
    {   
        Audio[0].loop = true;
        Audio[0].Play();
        Audio[1].loop = true;
        Audio[1].Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)){
            for (int i=0; i<Audio.Length; i++){
                if(Audio[i].isPlaying){
                    Audio[i].Pause();
                }else{
                    Audio[i].Play();
                }
            }
        }
    }
}
