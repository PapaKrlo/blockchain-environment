using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Hack1 : MonoBehaviour
{
    public Text displayText;
    private string[] letters = {"F", "Q", "N", "A", "J", "7"};
    private int index = 0;


    // Update is called once per frame
    void Update()
    {   
        displayText.text = letters[index];
    }
    public void startClick(){
        index+=1;
        if(index==letters.Length){
            index=0;
        }
    }
}
