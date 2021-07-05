using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Programmer: Mark G.
 * File Name: BusMovement.cs
 * Description: Creates movement for the bus object when created.
 */

/*
 * Modification Details:
 * (7/5/21) - Creation.
 * (7/5/21) - Private float variable speed declared and initialized to 25.
 * (7/5/21) - Translate call placed in update for object movement.
 * (7/5/21) - Code cleaned for finalization.
 */

public class BusMovement : MonoBehaviour
{
    // Variables:
    private float speed = 25.0f;
    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
// End of program