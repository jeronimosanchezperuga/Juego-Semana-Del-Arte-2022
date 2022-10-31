using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    public GameObject[] basuraPrefabs;
    public int randomIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            randomIndex = Random.Range(0,basuraPrefabs.Length);
            Instantiate(basuraPrefabs[randomIndex]);
        }
    }
}
