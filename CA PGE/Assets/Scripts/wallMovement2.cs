using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMovement2 : MonoBehaviour
{
    // Declaring variables
    public float speed = 1;

    Vector3 pointA;
    Vector3 pointB;

    // Start is called before the first frame update
    void Start()
    {
        // Setting the X, Y and Z coords for a vector 3
        pointA = new Vector3(-16, 6, 0);
        pointB = new Vector3(-24, 6, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Here I can use the lerp function to interpolate between two points, which I have previously set.
        // The PingPong function returns a value that will increment and decrement between the value 0 and length.
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time / speed, 1));
    }
}

