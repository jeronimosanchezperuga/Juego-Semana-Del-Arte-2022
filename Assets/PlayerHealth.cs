using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static int health = 100;
    static GameObject thisObject;

    // Start is called before the first frame update
    void Start()
    {
        thisObject = gameObject;
    }

    public static void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(thisObject);
        }
    }
}
