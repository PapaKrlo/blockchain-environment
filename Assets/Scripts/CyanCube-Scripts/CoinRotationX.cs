using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotationX : MonoBehaviour
{

    public float zAxisRot = 120;
    public Vector3 maxposition = new Vector3(0, 0, 0);
    public Vector3 minposition = new Vector3(0, 0, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= maxposition.z) {
            transform.Rotate(new Vector3(0, 0, zAxisRot) * Time.deltaTime);
        } 

        if (transform.position.z <= minposition.z) {
            transform.Rotate(new Vector3(0, 0, -zAxisRot) * Time.deltaTime);
        }   
    }
}
