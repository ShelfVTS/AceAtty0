using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour
{
    private float x = 0;

    
    void OnMouseDown()
    {
        x++;
    }

    // Update is called once per frame
    void Update()
    {
        if (x == 9)
        {
            LoadScene();
        }
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
