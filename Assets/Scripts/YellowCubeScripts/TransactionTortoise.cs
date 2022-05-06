using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransactionTortoise : MonoBehaviour
{
    public float speed = 2;
    private Vector3 direction = Vector3.forward;
    public bool clicked = false;

    void Update()
    {
        if(clicked){
            transform.position += direction * speed * Time.deltaTime;   
            if(transform.position.z >= 20.7){
                direction = Vector3.right;
                transform.localEulerAngles = new Vector3(0,90,0);
            }
            if(transform.position.x >= -11.8){
                direction = Vector3.back;
                transform.localEulerAngles = new Vector3(0,180,0);
            }
            if(transform.position.z <= -42.1){
                direction = Vector3.left;
                transform.localEulerAngles = new Vector3(0,270,0);
            }
            if(transform.position.x <= -22.5 && transform.position.z <=20 ){
                direction = Vector3.forward;
                transform.localEulerAngles = new Vector3(0,0,0);
            }
        }
    }
    public void moveTortoise(){
        clicked = true;
        Animator animator = transform.gameObject.GetComponent<Animator>();
        animator.runtimeAnimatorController = Resources.Load("Assets/QuirkySeries/Pets/Tortoise/Animations/Tortoise_LOD0.controller") as RuntimeAnimatorController;
    }
}
