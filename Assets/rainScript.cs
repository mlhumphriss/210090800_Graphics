using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Script used to allow rain particle effect to be toggled
public class rainScript : MonoBehaviour
{
    public ParticleSystem ps;
    public bool rainOn = false;

    // Start used to ensure Rain is off and that script is controlling Particle System
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        ps.Stop();
        
    }

    // Update used similar to check for R key press, then toggles rain on and off using a bool and ParticleSystem control words
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {

            if(rainOn == true)
            {    
                ps.Stop();
                rainOn = false;
            }
            else
            {
                ps.Play();
                rainOn = true;
            }

        }
    }
}
