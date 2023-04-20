using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideDown : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            LocationMoveUp();
        }
    }

    public void LocationMove()
    {
        animator.SetBool("MoveMenuDown", false);
        animator.SetBool("starter", true);
    }

    public void LocationMoveUp()
    {
        animator.SetBool("MoveMenuDown", true);
    }
}
