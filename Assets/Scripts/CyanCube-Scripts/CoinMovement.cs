using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    public Vector3 maxposition = new Vector3(0, 0, 0);
    public Vector3 minposition = new Vector3(0, 0, 0);
    Vector3 direction = Vector3.forward; 
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= maxposition.z) {
            direction = Vector3.back;
        } 

        if (transform.position.z <= minposition.z) {
            direction = Vector3.forward;
        }
        transform.position += direction * Time.deltaTime * speed;
    }
}
