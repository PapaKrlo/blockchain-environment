using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Steps : MonoBehaviour
{
    //public AudioSource someSound;
    public Sound sound;
    // Update is called once per frame
     void Start()
     {
         sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;
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
            
    
            sound.source.Play(); 
                   
        }
        if(Keyboard.current.upArrowKey.wasReleasedThisFrame    
        || Keyboard.current.leftArrowKey.wasReleasedThisFrame 
         || Keyboard.current.rightArrowKey.wasReleasedThisFrame 
         || Keyboard.current.downArrowKey.wasReleasedThisFrame 
         ||Keyboard.current.wKey.wasReleasedThisFrame
         || Keyboard.current.aKey.wasReleasedThisFrame
         || Keyboard.current.sKey.wasReleasedThisFrame
         || Keyboard.current.dKey.wasReleasedThisFrame){
            sound.source.Stop(); 

            
        } 
        //  else{
        //     //FindObjectOfType<AudioManager>().Stop("Footstep");
        //     if(sound.source.isPlaying){
        //         sound.source.Stop();

        //     }

        //  }
     }
 

}
