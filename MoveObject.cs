using System.Collections;
using UnityEngine;

public class MoveObject: MonoBehaviour
{
    public float speed;
    public float distance;
    public GameObject pointer;
    private int x;
    public GameObject cube;

    void Update()
    {
        Vector3 movement = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            movement += Vector3.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            movement += Vector3.down;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement += Vector3.right;
        }

        transform.position += movement * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.P) && x == 1)
        {
            Debug.Log("paintandpiss");
            cube.transform.Translate(0, 2, 0);
        }

        if (Input.GetKeyDown(KeyCode.P) && x == 2)
        {
            Debug.Log("Incorrect");
        }
    }

    public void EvidencePress()
    {
        pointer.transform.Translate(0, 0, -50);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Background_painting")
        {
            Debug.Log("touching paint");
            x = 1;
        }

    }
}