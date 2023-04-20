using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DestroySprite : MonoBehaviour
{
    private int x = 0;
    private int y = 0;
    public Animator animator;

    void Update()
    {
        if (y == 0)
        {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                y = 1;
            }
        }

        if (y == 1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                y = 0;
            }
        }

        if (Input.GetButtonDown("Fire1") && y == 1)
        {
            x += 1;

            animator.SetBool("beginanim", true);

            if (x == 4)
            {
                animator.SetBool("click4", true);
            }

            if (x == 5)
            {
                animator.SetBool("click4", false);
            }

            if (x == 6)
            {
                animator.SetBool("click4", true);
            }

            if (x == 8)
            {
                animator.SetBool("click4", false);
            }
        }

        
    }

    void OnTriggerEnter(Collider col)
    {
        animator.SetBool("isTyping", true);

        if (col.tag == "Player")
        {
            animator.SetBool("isTyping", false);
            Debug.Log("hey all");
        }
    }   
}


