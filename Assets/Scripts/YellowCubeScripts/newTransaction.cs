using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newTransaction : MonoBehaviour
{
    public float speed = 2;
    private Vector3 direction = Vector3.forward;
    public bool clicked = false;
    // // Start is called before the first frame update
    // void Start()
    // {

    // }

    // // Update is called once per frame
    void Update()
    {
        if(clicked){
            transform.position += direction * speed * Time.deltaTime;   
            if(transform.position.z >= 21){
                direction = Vector3.right;
            }
            if(transform.position.x >= -14.9){
                direction = Vector3.back;
            }
            if(transform.position.z <= -41){
                direction = Vector3.left;
            }
            if(transform.position.x <= -19.9 && transform.position.z <=20 ){
                direction = Vector3.forward;
            }
        }
    }
    public void moveRabbit(){
        clicked = true;
    }
}
