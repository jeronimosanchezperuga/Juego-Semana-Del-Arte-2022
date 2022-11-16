using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    static GameObject thisObject;
    public SceneAdmin sceneAdmin;

    // Start is called before the first frame update
    void Start()
    {
        thisObject = gameObject;
        sceneAdmin = FindObjectOfType<SceneAdmin>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            sceneAdmin.StopGame();
            Destroy(thisObject);
        }
    }
}
