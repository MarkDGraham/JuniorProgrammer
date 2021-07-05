using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * File: SpinPropellerX.cs
 * Programmer: Mark G.
 * Creation Date: July 4, 2021
 * Description: Makes the propeller spin for Unit 1 - Player Control Challenge.
 */

/*
 * Modification Details:
 * (7/4/21) - Float variable rotationSpeed created.
 * (7/4/21) - Rotate method added to rotate propeller.
 * (7/4/21) - Float variable rotationSpeed initialized to 1000.
 * (7/4/21) - Code cleaned for finaliztion.
 */

public class SpinPropellerX : MonoBehaviour
{
    // Variables: 
    private float rotationSpeed = -1000.0f;

    void Update()
    {
        // Rotates the propeller around the z-axis.
        transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed);
    }
}
// End of code.