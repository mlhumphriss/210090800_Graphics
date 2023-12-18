using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainScript : MonoBehaviour
{
    public ParticleSystem ps;
    public bool rainOn = false;

    // Start is called before the first frame update
    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        ps.Stop();
        
    }

    // Update is called once per frame
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
