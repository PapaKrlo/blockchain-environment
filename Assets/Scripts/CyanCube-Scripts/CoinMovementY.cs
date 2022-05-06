using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMovementY : MonoBehaviour
{
    public Vector3 maxposition = new Vector3(0, 0, 0);
    public Vector3 minposition = new Vector3(0, 0, 0);
    Vector3 direction = Vector3.up; 
    public float speed;

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
        transform.position += direction * Time.deltaTime * speed;
    }
}
