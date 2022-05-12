using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoHome : MonoBehaviour
{
    public string sceneName;
    
    public void OnTriggerEnter(Collider other){
        SceneManager.LoadScene("Land");
    }
}
