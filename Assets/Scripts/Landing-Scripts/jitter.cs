using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jitter : MonoBehaviour
{
    Vector3 maxposition = new Vector3(0, 19, 0);
    Vector3 minposition = new Vector3(0, 17, 0);
    Vector3 direction = Vector3.up; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= maxposition.y) {
            direction = Vector3.down;
        } 

        if (transform.position.y <= minposition.y) {
            direction = Vector3.up;
        }
        transform.position += direction * Time.deltaTime;
    }
}
