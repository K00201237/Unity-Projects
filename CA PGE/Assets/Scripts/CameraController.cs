using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Create variables for the our player game object and store the camera offset.
    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        // camera offset equals the cameras position minus the player transform position
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // the late update function is called every frame to update the camera postion to equal players transform plus the offset.
        transform.position = player.transform.position + offset; 
    }
}
