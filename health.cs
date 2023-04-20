using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    private int x = 0;

    public Animator animator;

    void OnMouseDown()
    {

        if (x == 5)
        {
            animator.SetBool("healthDropdown", true);
        }

        x++;
    }

}
