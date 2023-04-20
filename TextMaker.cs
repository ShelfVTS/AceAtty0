using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMaker : MonoBehaviour
{
    public string[] textSection1;
    public string[] textSection2;
    public string[] textSection3;
    public float delay;
    public Text displayText;
    private int sectionIndex = 0;
    public int textIndex = 0;
    public bool isTyping = false;
    public bool isTyping2 = false;
    public AudioSource blip;
    private float evidencePress = 0;
    public GameObject cube1;
    public GameObject cube3;
    public Transform cube2;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            evidencePress = 1;
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            evidencePress = 0;
        }

        switch (textIndex)
        {
            case 1:
                choice01();
                break;
            case 2:
                choice02();
                break;
            case 3:
                choice03();
                break;
            default:
                // Handle default case if necessary
                break;
        }


        SpriteMap();
    }

    public void choice01()
    {
        if (!isTyping2 && evidencePress == 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                StartCoroutine(TypeText(textSection1[sectionIndex]));
                sectionIndex++;
                isTyping2= false;
   
            }
        }
    }

    public void choice02()
    {
        textIndex = 2;
        if (!isTyping2 && evidencePress == 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                StartCoroutine(TypeText(textSection2[sectionIndex]));
                sectionIndex++;
            }
            
        }
    }

    public void choice03()
    {
        textIndex = 3;
        if (!isTyping2 && evidencePress == 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                StartCoroutine(TypeText(textSection3[sectionIndex]));
                sectionIndex++;
            }
        }
    }

    IEnumerator TypeText(string text)
    {
        displayText.text = "";
        foreach (char letter in text.ToCharArray())
        {
            displayText.text += letter;
            yield return new WaitForSeconds(delay);
            blip.Play();
            isTyping2 = true;
            isTyping = true;
        }
        isTyping2 = false;
    }

    public void SpriteMap()
    {
        if (!isTyping2)
        {
            cube1.transform.position = cube2.position;
            cube3.transform.position = cube2.position + new Vector3(0, -1000, 0);

        }
        if (isTyping2)
        {
            cube1.transform.position = cube2.position + new Vector3(0, 1000, 0);
            cube3.transform.position = cube2.position;
        }
    }
}