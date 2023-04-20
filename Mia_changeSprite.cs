using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mia_changeSprite : MonoBehaviour
{
    public GameObject cube;
    public Animator animator;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "reciever")
        {
            animator.SetBool("isTyping", true);
            
        }

        else if (col.tag == "Player")
        {
            animator.SetBool("isTyping", false);
            
        }
    }
}
