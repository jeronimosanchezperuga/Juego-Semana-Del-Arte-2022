using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour
{
    public GameObject[] basuraPrefabs;
    public Transform[] spawnPoints;
    public int randomIndex;
    public int randomPointIndex;
    public float timeBetweenSpawns;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DelayedStart",2);
    }

    void DelayedStart()
    {
        StartCoroutine(TimeBetweenSpawns(timeBetweenSpawns));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }

    void BasuraInstantiate()
    {
        randomIndex = Random.Range(0, basuraPrefabs.Length);
        randomPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(basuraPrefabs[randomIndex], spawnPoints[randomPointIndex].position, Quaternion.identity);
    }

    IEnumerator TimeBetweenSpawns(float time)
    {
        while(true)
        {
            yield return new WaitForSecondsRealtime(time);
            BasuraInstantiate();
        }
        
    }
    
}
