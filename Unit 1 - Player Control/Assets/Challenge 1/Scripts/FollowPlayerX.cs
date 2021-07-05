using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * File: FollowPlayerX.cs
 * Programmer: Mark G.
 * Creation Date: July 4, 2021
 * Description: Transforms camera's location to match players location.
 */

/*
 * Modification Details:
 * (7/4/21) - offset has been initialized.
 * (7/4/21) - Code cleaned for finalization.
 */

public class FollowPlayerX : MonoBehaviour
{
    // Variables
    public GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 10);

    void Update()
    {
        // Moves camera with player with offset added on.
        transform.position = plane.transform.position + offset;
    }
}
// End of code.