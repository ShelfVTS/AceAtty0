using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Threading;
using System.Threading.Tasks;

public class screenFlash : MonoBehaviour
{
    public GameObject anim;
    private int x = 0;

    public async void OnMouseDown()
    {
        if(x == 7)
        {
            anim.transform.Translate(0, 100, 0);
            await Task.Delay(100);
            anim.transform.Translate (0, 100, 0);
            
        }
        x++;
    }
    
}