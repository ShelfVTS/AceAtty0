using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CumShitter : MonoBehaviour
{
    public Animator animator;
    private int x = 0;

    void Update()
    {
        if (x == 0)
        {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                UnEvidenceMover();

            }
        }

    }

    public void EvidenceMover()
    {
        animator.SetBool("EviSlide", true);
        animator.SetBool("stahhtaah", true);
    }

    public void UnEvidenceMover()
    {
        animator.SetBool("EviSlide", false);
    }
}