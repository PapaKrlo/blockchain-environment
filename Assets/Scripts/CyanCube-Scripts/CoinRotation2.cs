using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation2 : MonoBehaviour
{
    public float degreesPerSecond = -120;

    // Update is called once per frame
    private void Update()
    {
    transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);
    }

}