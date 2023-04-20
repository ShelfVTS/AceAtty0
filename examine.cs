using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class examine : MonoBehaviour
{
    private int x = 0;
    private bool ex = false;
    public GameObject options;
    public GameObject character;
    

    public void ExamineRoom()
    {
        ex = true;
    }

    void Update()
    {
        if (ex == true && x == 0)
        {
            options.transform.Translate(0, -100, 0);
            character.transform.Translate(0, -100, 0);
            x++;
        }
        
        if (ex == false && x == 1)
        {
            options.transform.Translate(0, 100, 0);
            character.transform.Translate(0, 100, 0);
            x--;
        }
    }
}   
