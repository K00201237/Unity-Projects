using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{

    // Declaring variables
    public GameObject enemyPreFab;
    public GameObject enemyPreFab2;
    private float spawnRange = 12;

    // Start is called before the first frame update
    void Start()
    {
        // Using the random range function to genearte an x position and z position with the spawnrange variable.
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        // Setting the random spawn location. The Y value is set to 0.5 so the objects do not fall thhrough the floor.
        Vector3 randomPos = new Vector3(spawnPosX, (float)0.5, spawnPosZ);
        // Spawning two enemy game objects.
        Instantiate(enemyPreFab, randomPos, enemyPreFab.transform.rotation);
        Instantiate(enemyPreFab2, randomPos, enemyPreFab2.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
