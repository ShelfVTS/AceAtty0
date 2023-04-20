using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evidencePress : MonoBehaviour
{
    private float y;
    public GameObject textBox;
    private textSlide talkwalk;
    public GameObject texts;
    private TextMaker textdex;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "E1")
        {
            Debug.Log("touching1");
            y = 1;

        }

        if (col.tag == "E2")
        {
            Debug.Log("touching2");
            y = 2;
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && y == 1)
        {
            Debug.Log("Correct");
            talkwalk = textBox.GetComponent<textSlide>();
            talkwalk.SlideUp();
            textdex = texts.GetComponent<TextMaker>();
            textdex.textIndex = 1;
        }

        if (Input.GetKeyDown(KeyCode.Return) && y == 2)
        {
            Debug.Log("Incorrect");
        }
    }
}
