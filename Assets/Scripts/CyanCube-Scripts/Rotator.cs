using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Rotator : MonoBehaviour
{
    //Rotational Speed
    //public float speed = 25f;
   
    // //Forward Direction
    // public bool ForwardX = false;
    // public bool ForwardY = false;
    // public bool ForwardZ = false;
   
    // //Reverse Direction
    // public bool ReverseX = false;
    // public bool ReverseY = false;
    // public bool ReverseZ = false;
   
    // void Update ()
    // {
        //Forward Direction
       
        //if(ForwardY == true)
        //if(transform.rotation.y >= -55){
        // if(transform.rotation.y >= -55){
        //     transform.Rotate(0, -Time.deltaTime * speed,  0, Space.Self);
        // }else{
        //         transform.Rotate(0, Time.deltaTime * speed,  0, Space.Self);

        // }
        //}
        // else if(transform.rotation.y <= -155){
        //         transform.Rotate(0, -Time.deltaTime * speed,  0, Space.Self);

        // }
     
        
       
       
       
       
    // }
           // Use this for initialization
        public float speed = 1;
        public float RotAngleY = 310;
        void Start () {
            
        }
        
     // Update is called once per frame
     void Update () {
         float rY = Mathf.SmoothStep(90,RotAngleY,Mathf.PingPong(Time.time * speed,1));
         transform.rotation = Quaternion.Euler(0,rY,0);
     } 
}