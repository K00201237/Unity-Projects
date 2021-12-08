using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // DEclaring variables
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        // Using get component to get the rigidbody function
        enemyRb = GetComponent<Rigidbody>();
        // Using the find function to search for the player tag
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Apply force in direction of our player by subtracting player postion by enemy position
        enemyRb.AddForce((player.transform.position - transform.position).normalized * speed);
    }
}
