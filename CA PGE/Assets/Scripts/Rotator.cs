using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // The rotate function is being used to rotate our pickup objects using a vector to rotate by the x,y and z axis. deltatime will update the rotation every frame.
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
