using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TachoScript : MonoBehaviour
{
    public bool isGreen;
    public Sprite tachoVerde;
    public Sprite tachoNegro;
    public SpriteRenderer spriteRenderer;
    public float swipeMinDistance;
    private Vector2 startTouchPosition, endTouchPosition;
    private bool switchAllowed = false;
    public GameObject imgBtnSwitchBlack;
    public GameObject imgBtnSwitchGreen;


    void Start()
    {
        isGreen = true;
        spriteRenderer.sprite = tachoVerde;
    }

    void Update()
    {
        SwipeCheck();

        if (Input.GetKeyDown(KeyCode.Space) || switchAllowed)
        {
            SwitchBinType();
            switchAllowed = false;
        }
    }

    private bool SwipeCheck()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            startTouchPosition = Input.GetTouch(0).position;

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            endTouchPosition = Input.GetTouch(0).position;
            if (endTouchPosition.y - startTouchPosition.y > swipeMinDistance)
            {
                Debug.Log(endTouchPosition.y - startTouchPosition.y);
                switchAllowed = true;
            }
        }
        return switchAllowed;
    }

    public void SwitchBinType()
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
        imgBtnSwitchGreen.SetActive(!isGreen);
        imgBtnSwitchBlack.SetActive(isGreen);
    }
}
