using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
    public Vector3 maxposition = new Vector3(0, 0, 0);
    public Vector3 minposition = new Vector3(0, 0, 0);
    Vector3 direction = Vector3.left; 
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= maxposition.x) {
            direction = Vector3.left;
        } 

        if (transform.position.x <= minposition.x) {
            direction = Vector3.right;
        }
        transform.position += direction * Time.deltaTime * speed;
    }
}
