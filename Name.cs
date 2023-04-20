using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    private string input;

    public void ReadStringInput(string s)
    {
        input = s;
        Debug.Log(input);
    }

}


