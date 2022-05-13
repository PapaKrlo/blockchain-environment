using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OpenVault : MonoBehaviour
{
    public Animator animator;
    public Text item1;
    public Text item2;
    public Text item3;
    private int opened = 0;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if( item1.text.Equals("B") && item2.text.Equals("X") && item3.text.Equals("Q")){
            //Console.WriteLine("heyy");
            Debug.Log("hey");
            animator.Play("Base Layer.openVault");
            opened += 1;
        }
        else{
            if(opened>=1){
                FindObjectOfType<AudioManager>().Play("VaultClose");

            }
            animator.Play("Base Layer.empty");
            opened = 0;
        }

        vaultSound();
    }

    void vaultSound() 
    {
        if(opened == 1) 
        {
            FindObjectOfType<AudioManager>().Play("VaultOpen");

            FindObjectOfType<AudioManager>().Play("DingDing");

        }
        //opened = false;
    }
}
