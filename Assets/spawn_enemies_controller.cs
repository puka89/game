using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_enemies_controller : MonoBehaviour
{
    public Transform enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn_cube", 2, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn_cube()
    {
        float axis_x = Random.Range(-15, 15);
        float axis_z;
        if(axis_x >= 0)
        {
            axis_z = 15 - axis_x;
        }
        else
        {
            axis_z = -15 - axis_x;
        }

        Instantiate(enemy, new Vector3(axis_x, 2, axis_z), Quaternion.identity);
    }
}
