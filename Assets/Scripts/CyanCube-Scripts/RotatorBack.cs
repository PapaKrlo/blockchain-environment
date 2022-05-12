using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class RotatorBack : MonoBehaviour
{  
        // Use this for initialization
        public float speed = 0.7f;
        public float RotAngleY = 130;
        public float rNum = 45;
        void Start () {
            
        }
        
     // Update is called once per frame
     void Update () {
         float rY = Mathf.SmoothStep(rNum,RotAngleY,Mathf.PingPong(Time.time * speed,1));
         transform.rotation = Quaternion.Euler(0,-rY,0);
     } 
}