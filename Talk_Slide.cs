using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk_Slide : MonoBehaviour
{
    public Animator animator;
    private int x = 0;

    void Update()
    {
        if (x == 0)
        {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                LeftSlide();

            }
        }

    }

    public void RightSlide()
    {
        animator.SetBool("GumSlide", true);
        animator.SetBool("star", true);
    }

    public void LeftSlide()
    {
        animator.SetBool("GumSlide", false);
    }
}
