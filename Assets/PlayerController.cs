﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float stepDistance;
    public float leftLimit;
    public float rightLimit;
    public Vector3 initialPosition;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = initialPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) )
        {
            IrALaIzquierda();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            IrALaDerecha();
        }
    }

    public void IrALaIzquierda()
    {
        Debug.Log("A la izquierda");
        if(transform.position.x > leftLimit)
        {
            transform.Translate(-stepDistance, 0, 0);
        }
    }
    public void IrALaDerecha()
    {
        Debug.Log("A la Derecha");
        if (transform.position.x < rightLimit)
        {
            transform.Translate(stepDistance, 0, 0);
        }
    }
}
