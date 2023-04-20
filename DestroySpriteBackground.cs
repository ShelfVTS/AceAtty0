using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DestroySpriteBackground : MonoBehaviour
{
    private int x = 0;
    public Animator animator;

    public SpriteRenderer spriteRenderer;
    public Sprite newSprite1;

    void OnMouseDown()
    {
        x += 1;

        if (x > 7)
        {
            spriteRenderer.sprite = newSprite1;
        }
    }
}