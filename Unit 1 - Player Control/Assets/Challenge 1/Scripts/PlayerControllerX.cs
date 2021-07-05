using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * File: PlayerControllerX.cs
 * Programmer: Mark G.
 * Creation Date: July 4, 2021
 * Description: Player control script for player movement of the 
 *              Unit 1 - Player Control Challenge.
 */

/*
 * Modification Details:
 * (7/4/21) - Float variable speed set to 15 meters.
 * (7/4/21) - Translate function set to forward instead of backward.
 * (7/4/21) - Float variable rotation speed set to 45 meters.
 * (7/4/21) - verticalInput added to rotate method.
 * (7/4/21) - Code cleaned for finalization.
 */

public class PlayerControllerX : MonoBehaviour
{
    // Variables:
    private float speed = 15.0f;
    private float rotationSpeed = 45.0f;
    private float verticalInput;

    void FixedUpdate()
    {
        // Get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // Move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
    }
}
// End of code.