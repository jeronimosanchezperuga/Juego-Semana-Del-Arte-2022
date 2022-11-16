using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int score;

    void Start()
    {
        score = 0;
    }

    public void AddScore()
    {
        score++;
    }
}
