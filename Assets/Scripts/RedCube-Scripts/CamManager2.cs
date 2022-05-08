using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager2 : MonoBehaviour
{
   public Camera cam1;
    public Camera cam2;
    public Camera cam3;

 
    void Start() {
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;

    }
 
//  void Update() {
 
//      if (Keyboard.current.cKey.wasPressedThisFrame) {
//          cam1.enabled = !cam1.enabled;
//          cam2.enabled = !cam2.enabled;
//      }
//  }
 public void changetoLeftCamera(){
        cam1.enabled = false;
        cam2.enabled = true;
        cam3.enabled = false;
 }
  public void changetoRightCamera(){
        cam1.enabled = false;
        cam2.enabled = false;
        cam3.enabled = true;
 }
  public void changetoCenterCamera(){
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
 }
}
