using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasuraCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Piso"))
        {
            PlayerHealth.TakeDamage(10);
        }
        Destroy(gameObject);
    }
}
