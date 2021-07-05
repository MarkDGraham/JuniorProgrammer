using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Programmer: Mark G.
 * File Name: SpawnBus.cs
 * Description: Creates an instance for a bus character with speed and then
 *              removes the bus when a checkpoint is reached.
 */

/*
 * Modification Details:
 * (7/5/21) - Creation.
 * (7/5/21) - Public GameObject enemyBus created.
 * (7/5/21) - Spawn switch created with instantiate function. 
 * (7/5/21) - Quaternion enemyRotation declared and initialized to 180 on y.
 * (7/5/21) - InvokeRepeating Function added to start.
 * (7/5/21) - Code cleaned for finalization.
 */

public class SpawnBus : MonoBehaviour
{
    // Variables:
    public GameObject enemyBus;
    private float startDelay = 2;
    private float spwnInterval = 3f;
    Quaternion enemyRotation = Quaternion.Euler(0, 180, 0);
    private bool Switch = true;

    void Start()
    {
        InvokeRepeating("SpawnSwitch", startDelay, spwnInterval);
    }

    void SpawnSwitch()
    {
        if (Switch == true)
        {
            Instantiate(enemyBus, new Vector3(5, 0, 175), enemyRotation);
            Switch = false;
        }
        else
        {
            Instantiate(enemyBus, new Vector3(-5, 0, 175), enemyRotation);
            Switch = true;
        }
    }
}
//End of code.