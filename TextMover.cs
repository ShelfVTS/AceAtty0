using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMover : MonoBehaviour
{
    public GameObject text;
    private bool x = false;
    private int y = 0;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "mover")
        {
            x = true;
        }
    }

    void Update()
    {
        if(x == true && y == 0)
        {
            text.transform.Translate(0, 25, 0);
            y = 1;
        }
        
    }
}
