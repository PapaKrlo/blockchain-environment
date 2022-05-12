using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class RotatorCoinX : MonoBehaviour
{  
        // Use this for initialization
        public float speed = 0.7f;
        public float RotAngleY = 360;
        public float rNum = 0;
        void Start () {
            
        }
        
     // Update is called once per frame
     void Update () {
         float rX = Mathf.SmoothStep(rNum,RotAngleY,Mathf.PingPong(Time.time * speed,1));
         transform.rotation = Quaternion.Euler(rX,0,0);
     } 
}