using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textSlide : MonoBehaviour
{
    public Animator animator;

    public void SlideUp()
    {
        animator.SetBool("SlideUp", true);
        animator.SetBool("starter", true);
    }

    public void SlideDown()
    {
        animator.SetBool("SlideUp", false);
    }
}
