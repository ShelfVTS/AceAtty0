using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evidence : MonoBehaviour
{
    public float sideDistance;
    public float vertDistance;
    private bool y = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            y = true;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && y == true)
        {
            transform.position += Vector3.up * vertDistance;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && y == true)
        {
            transform.position += Vector3.down * vertDistance;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && y == true)
        {
            transform.position += Vector3.left * sideDistance;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && y == true)
        {
            transform.position += Vector3.right * sideDistance;
        }
    }
}


