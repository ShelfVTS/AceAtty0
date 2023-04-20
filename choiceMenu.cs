using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class choiceMenu : MonoBehaviour
{
    public float movementSpeed = 10;
    private int x = 0;
    private int y = 1;
    public GameObject rb;
    public GameObject a;
    private Vector3 endPosition = new Vector3(1022, 21, 1078);
    private Vector3 startPosition = new Vector3(1022, -21, 1078);
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<GameObject>();
    }

    // Update is called once per frame
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

        if (x == 5)
        {
            if (transform.position != endPosition)
            {
                transform.position = Vector3.MoveTowards(transform.position, endPosition, movementSpeed * Time.deltaTime);
            }
        }

        if (Input.GetButtonDown("Fire1") && y == 1)
        {
            x++;
            
        }
    }

    public void moveDown()
    {
        Destroy(a);
    }

}