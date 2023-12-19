using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Simple script used to animate the Jet to fly past volcano
public class MovementScript : MonoBehaviour
{
    
    // Update manually moves plane 3 steps a frame to have it fly across screen
    void Update()
    {
        transform.position += new Vector3(3, 0, 0);
    }
}
