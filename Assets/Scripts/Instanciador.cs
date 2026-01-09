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
        if (GameManager.Instance.state != GameManager.GameState.Playing)
            return;
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
