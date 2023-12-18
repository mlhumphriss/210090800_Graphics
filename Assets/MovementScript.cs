using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(3, 0, 0);
    }
}
