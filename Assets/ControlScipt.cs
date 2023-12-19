using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ControlScipt : MonoBehaviour
{
    //Varaiables
    public float camSpeed = 50.0f;    
    public float camSens = 1.0f;



    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move camera x/y/z axis'
        transform.position += transform.forward * Input.GetAxis("Vertical") * camSpeed * Time.deltaTime;
        transform.position += transform.right * Input.GetAxis("Horizontal") * camSpeed * Time.deltaTime;
        if(Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.up * camSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.up * -1f * camSpeed * Time.deltaTime;
        }

        //Rotation from mouse movement
        float miceX =Input.GetAxis("Mouse X");
        float miceY =Input.GetAxis("Mouse Y");
        transform.eulerAngles += new Vector3(-miceY * camSens, miceX *camSens, 0);

    }
}
