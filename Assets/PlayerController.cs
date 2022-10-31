using System.Collections;
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
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > leftLimit)
        {
            transform.Translate(-stepDistance,0,0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < rightLimit)
        {
            transform.Translate(stepDistance, 0, 0);
        }
    }
}
