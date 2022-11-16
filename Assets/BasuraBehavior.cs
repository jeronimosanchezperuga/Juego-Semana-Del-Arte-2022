using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasuraBehavior : MonoBehaviour
{
    public float rotationSpeed;
    public float val = 1;

    // Start is called before the first frame update
    void Start()
    {
        val = Random.Range(-0.5f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * val);
    }
}
