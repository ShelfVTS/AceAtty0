using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide_Right : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            SlideLeft();
        }
    }

    public void SlideRight()
    {
        animator.SetBool("SlidingRight", false);
        animator.SetBool("starter", true);
    }

    public void SlideLeft()
    {
        animator.SetBool("SlidingRight", true);
    }
}
