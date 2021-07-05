using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * File: PlayerController.cs
 * Programmer: Mark G.
 * Creation Date: July 4, 2021
 * Description: Player control script for player movement of the 
 *              Unit 1 - Player Control.
 */

/*
 * Modification Details:
 * (7/4/21) - Creation
 * (7/4/21) - Translate object by 1 meter in the z added.
 * (7/4/21) - Translate hard units changed to Vector3 class method forward.
 * (7/4/21) - Eliminate machine dependancy and unit speed increased to 20 
 *            meters.
 * (7/4/21) - Hard Value changed to float speed variable.
 * (7/4/21) - turnSpeed float variable added and translate function added.
 * (7/4/21) - Basic vehicle control added with horizontalInput float variable
 *            and Input function.
 * (7/4/21) - Change first translate to add control with forwardInput float
 *            variable.
 * (7/4/21) - Horiztoal control function changed from translate to rotate.
 * (7/4/21) - Variables change from public to private.
 * (7/4/21) - Code cleaned for .
 */

public class PlayerController : MonoBehaviour
{
    // Variables:
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward based on vertical input.
        transform.Translate(Vector3.forward * Time.deltaTime * speed
                            * forwardInput);
        // Rotates the vehicle based on horizontal input.
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed
                         * horizontalInput);
    }
}
// End of code.