using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Programmer: Mark G.
 * File Name: OutOfBounds.cs
 * Description: Destroys game object when reaches bound limit.
 */

/*
 * Modification Details:
 * (7/5/21) - Creation.
 * (7/5/21) - Private float variable bound declared and initialized to -15.
 * (7/5/21) - If structure added to determine if object has passed bounds
 *            then destroy object if true.
 * (7/5/21) - Cleaned code for finalization.
 */

public class OutOfBounds : MonoBehaviour
{
    // Variables:
    private float bound = -15.0f;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < bound)
        {
            Destroy(gameObject);
        }
    }
}
// End of program.