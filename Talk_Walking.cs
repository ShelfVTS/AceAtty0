using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk_Walking : MonoBehaviour
{
    public Animator animator;
    public int x = 0;
    public int z = 2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            UnTalkMover();

            if(x == 2)
            {
                RemoverGumShoever();
            }
            
            if(x == 1)
            {
                RightSlide();
            }

            if(z == 1)
            {
                TalkMover();
            }
            
        }

    }

    public void TalkMover()
    {
        animator.SetBool("TalkMoveDown", true);
        
    }

    public void UnTalkMover()
    {
        animator.SetBool("TalkMoveDown", false);
    }

    public void GumShoever()
    {
        animator.SetBool("SlideVert", true);
        animator.SetBool("Gummy", true);
        x = 2;
    }

    public void RemoverGumShoever()
    {
        animator.SetBool("SlideVert", false);
        animator.SetBool("Gummy", true);
    }

    public void LeftSlide()
    {
        animator.SetBool("Leftist", true);
        animator.SetBool("BenShaboolo", true);
        x = 1;
    }

    public void RightSlide()
    {
        animator.SetBool("Leftist", false);
        animator.SetBool("BenShaboolo", true);
    }

    
}
