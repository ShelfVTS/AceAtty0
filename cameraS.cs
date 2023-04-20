using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Threading;
using System.Threading.Tasks;

public class cameraS : MonoBehaviour
{
    private GameObject cam;
    public float movementSpeed = 10;
    private int x = 0;
    private int y = 1; 
    private Vector3 endPosition = new Vector3(917, 15, 1187);
    // Use this for initialization
    void Start()
    {
        cam = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (y == 0)
        {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                y = 1;
            }
        }

        if (y == 1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                y = 0;
            }
        }

        if (x == 6)
        {
            if (transform.position != endPosition)
            {
                transform.position = Vector3.MoveTowards(transform.position, endPosition, movementSpeed * Time.deltaTime);
            }
        }

        if (Input.GetButtonDown("Fire1") && y == 1)
        {
            x++;
        }

    }

}
