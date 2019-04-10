using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapturedEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        return;
        if(Input.GetKeyDown("joystick button 3"))
        {
            Debug.Log("Fire");
        }

        // Debug.Log(Input.GetAxis("Horizontal"));
    }
}
