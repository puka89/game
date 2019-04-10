using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class events : MonoBehaviour
{
    private void Start()
    {
        foreach (string str in Input.GetJoystickNames())
        {
            Debug.Log("Connected: " + str);
        }
    }


    void Update()
    {
        return;
        System.Array values = System.Enum.GetValues(typeof(KeyCode));
        foreach (KeyCode code in values)
        {
            if (Input.GetKeyDown(code)) { Debug.Log(System.Enum.GetName(typeof(KeyCode), code)); }
        }
    }
}
