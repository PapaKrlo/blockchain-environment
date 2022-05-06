using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransactionRabbit : MonoBehaviour
{
    public float speed = 2;
    private Vector3 direction = Vector3.forward;
    public bool clicked = false;

    void Update()
    {
        if(clicked){
            transform.position += direction * speed * Time.deltaTime;   
            if(transform.position.z >= 21){
                direction = Vector3.right;
            }
            if(transform.position.x >= -14.9){
                direction = Vector3.back;
                transform.localEulerAngles = new Vector3(0,180,0);
            }
            if(transform.position.z <= -41){
                direction = Vector3.left;
            }
            if(transform.position.x <= -19.59 && transform.position.z <=20 ){
                direction = Vector3.forward;
                transform.localEulerAngles = new Vector3(0,0,0);
            }
        }
    }
    public void moveRabbit(){
        clicked = true;
        Animator animator = transform.gameObject.GetComponent<Animator>();
        animator.runtimeAnimatorController = Resources.Load("Assets/Rabbits/Animations/Rabbit2.controller") as RuntimeAnimatorController;
    }
}
