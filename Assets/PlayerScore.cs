﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public static int score;

    void Start()
    {
        score = 0;
    }

    public static void AddScore()
    {
        score++;
    }
}
