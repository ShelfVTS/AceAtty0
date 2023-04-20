using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Anim : MonoBehaviour
{
    public Animator animator;
    private float x = 1;
    public GameObject menu;
    public float movementSpeed = 10;
    public Vector3 endPosition = new Vector3(2, -104, 77);
    public Vector3 startPosition = new Vector3(-84, -40, -22);

    // Start is called before the first frame update
    void Update()
    {
        if(x == 0)
        {
            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                Dropdown();
            }
        }

        if(x == 1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                UnDropdown();
            }
        }
        
    }

    private void Start()
    {
        animator.SetBool("gamer", false);
    }

    public void Dropdown()
    {
        if(x == 0)
        {
            animator.SetBool("EPress", false);
            animator.SetBool("gamer", true);
            x = 1;
            menu.transform.position += new Vector3(0, 100 ,0);
        }
    }

    public void UnDropdown()
    {
        if(x == 1)
        {
            animator.SetBool("EPress", true);
            animator.SetBool("gamer", true);
            x = 0;
            menu.transform.position += new Vector3(0, -100, 0);
        }
    }
}
