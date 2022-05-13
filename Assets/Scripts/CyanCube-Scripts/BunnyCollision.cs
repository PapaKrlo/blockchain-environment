using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyCollision : MonoBehaviour
{
    public Animator animator;
    public string thump;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }


    public void OnTriggerEnter(Collider other){
        animator.Play("Base Layer.Run");
        FindObjectOfType<AudioManager>().Play(thump);
        FindObjectOfType<AudioManager>().Play("Coin");   
   
    }
}
