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
        health = 100;
    }

    public static void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Death();
        }
    }

    static void Death()
    {
        // Handle player death (e.g., play animation, sound, etc.)
        Destroy(thisObject);
        GameManager.Instance.SetGameState(GameManager.GameState.GameOver);
    }
}
