using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Steps : MonoBehaviour
{
    
    // Update is called once per frame
     void Start()
     {
     }
     void Update(){
         if (Keyboard.current.upArrowKey.wasPressedThisFrame 
         || Keyboard.current.leftArrowKey.wasPressedThisFrame 
         || Keyboard.current.rightArrowKey.wasPressedThisFrame 
         || Keyboard.current.downArrowKey.wasPressedThisFrame 
         ||Keyboard.current.wKey.wasPressedThisFrame
         || Keyboard.current.aKey.wasPressedThisFrame
         || Keyboard.current.sKey.wasPressedThisFrame
         || Keyboard.current.dKey.wasPressedThisFrame) {
            //isWalking = true;
        //     if(!audio.isPlaying)
        //  {
        //      // ... play them.
        //      audio.clip = AudioFile;
        //      audio.Play();
        //  }
            FindObjectOfType<AudioManager>().Play("Footstep");
         }
     }
 

}
