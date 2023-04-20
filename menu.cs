using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu : MonoBehaviour
{
    public GameObject menuObject;
    private int x = 0;
    private int a = 5;

    public static bool checkSuffix(int x, int a)
    {

        // Convert numbers into strings
        string s1 = x.ToString();
        string s2 = a.ToString();

        // Find the lengths of strings
        // s1 and s2
        int n1 = s1.Length;
        int n2 = s2.Length;

        // Base case
        if (n1 < n2)
        {
            return false;
        }

        // Traverse the strings s1 & s2
        for (int i = 0; i < n2; i++)
        {

            // If at any index characters
            // are unequals then return false
            if (s1[n1 - i - 1] != s2[n2 - i - 1])
            {
                return false;
            }
        }

        // Return true
        return true;
    }


    void Update()
    {
        bool result = checkSuffix(x, a);

        //Detect when the E arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (result)
            {
                menuObject.transform.Translate(0, 100, 0);
            }
            else
            {
                menuObject.transform.Translate(0, -100, 0);
            }

            x += 5;
        }
    }
}
