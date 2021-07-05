using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * File: FollowPlayer.cs
 * Programmer: Mark G.
 * Creation Date: July 4, 2021
 * Description: Transforms camera's location to match players location.
 */

/*
 * Modification Details:
 * (7/4/21) - Creation
 * (7/4/21) - Transform position added to transform to player's position.
 * (7/4/21) - Distance added to player position to retain original camera
 *            position.
 * (7/4/21) - Hard value offset changed to Vector3 offset variable.
 * (7/4/21) - Update changed to LateUpdate for less jittery.
 * (7/4/21) - Code cleaned for finalization.
 */

public class FollowPlayer : MonoBehaviour
{
    // Variables:
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);

    void LateUpdate()
    {
        // Translate camera to match player position.
        transform.position = player.transform.position + offset;
    }
}
// End of code.