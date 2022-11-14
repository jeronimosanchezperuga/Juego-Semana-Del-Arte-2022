using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TachoScript : MonoBehaviour
{
    public bool isGreen;
    public Sprite tachoVerde;
    public Sprite tachoNegro;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        isGreen = true;
        spriteRenderer.sprite = tachoVerde;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isGreen = !isGreen;
            if (isGreen)
            {
                spriteRenderer.sprite = tachoVerde;
            }
            else
            {
                spriteRenderer.sprite = tachoNegro;
            }
        }
    }
}
