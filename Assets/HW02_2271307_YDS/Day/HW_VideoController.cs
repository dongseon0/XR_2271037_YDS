using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class HW_VideoController : MonoBehaviour
{
    public VideoPlayer[] Video;
    void Start()
    {   
        Video[0].Play();
        Video[0].isLooping = true ;
        Video[1].Play();
        Video[1].isLooping = true ;
        
    }
    }

    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.Return)){
    //         for(int i=0; i<Video.length; i++){
    //             if(Video.isPlaying){
    //                 //Video.Stop();
    //                 Video.Pause();
    //             }else{
    //                 Video.Play();
    //             }
            
    //     }
    // }
    // }
    
