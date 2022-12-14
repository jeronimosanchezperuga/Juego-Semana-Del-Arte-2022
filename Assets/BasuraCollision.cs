using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasuraCollision : MonoBehaviour
{
    public bool isReciclable;

    void OnCollisionEnter2D(Collision2D col)
    {
        //si toca el piso, resta vida
        if (col.gameObject.CompareTag("Piso"))
        {
            PlayerHealth.TakeDamage(10);
            //si toca al player
        }else if (col.gameObject.CompareTag("Player"))
        {
            //si el player es verde y la basura reciclable o
            //si el player es negro y la basura no reciclable
            // suma puntos
            if ((isReciclable && col.gameObject.GetComponent<TachoScript>().isGreen)
                || (!isReciclable && !col.gameObject.GetComponent<TachoScript>().isGreen))
            {
                PlayerScore.AddScore();
            }
            //de otra manera, resta vida
            else
            {
                PlayerHealth.TakeDamage(10);
            }
        }
        //pase lo que pase, al colisionar se destruye
        Destroy(gameObject);
    }
}
