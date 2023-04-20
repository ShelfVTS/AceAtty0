using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorSpawner : MonoBehaviour
{
    public GameObject spawner;
    public Vector3 starter = new Vector3(-0, 0, -0);
    public Vector3 evidence1 = new Vector3(1066, 25, 1044);
    public Vector3 evidence2 = new Vector3(-47, 18, -95);
    public Vector3 evidence3 = new Vector3(-47, 11, -95);
    public Vector3 evidence4 = new Vector3(-47, 7, -95);
    private int x = 0;
    private int maxPositions = 4;
    private int minPositions = 1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            x++;
            if (x > maxPositions)
            {
                x = 1;
            }
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            x--;
            if (x < minPositions)
            {
                x = 4;
            }
        }

        switch (x)
        {
            case 1:
                spawner.transform.position = evidence1;
                break;
            case 2:
                spawner.transform.position = evidence2;
                break;
            case 3:
                spawner.transform.position = evidence3;
                break;
            case 4:
                spawner.transform.position = evidence4;
                break;
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            spawner.transform.position = starter;
        }
    }
}