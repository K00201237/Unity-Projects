using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallMovement : MonoBehaviour
{
    public float speed = 1;

    Vector3 pointA;
    Vector3 pointB;

    // Start is called before the first frame update
    void Start()
    {
        pointA = new Vector3(16, 6, 0);
        pointB = new Vector3(24, 6, 0);
    }

    // Update is called once per frame
    void Update()
    {
       // float time = Mathf.PingPong(Time.time * speed, 1);
       // transform.position = Vector3.Lerp(pointA, pointB, time);
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time / speed, 1));
    }
}
