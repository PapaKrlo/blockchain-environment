using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CamManager : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;

 
 void Start() {
     cam1.enabled = true;
     cam2.enabled = false;
 }
 
 void Update() {
 
     if (Keyboard.current.cKey.wasPressedThisFrame) {
         cam1.enabled = !cam1.enabled;
         cam2.enabled = !cam2.enabled;
     }
 }
    
}
