using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIUpdater : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textHealth;

    PlayerScore score;
    PlayerHealth health;
 

    private void Start()
    {
        score = FindObjectOfType<PlayerScore>();
        health = FindObjectOfType<PlayerHealth>();
    }

    void Update()
    {
        textScore.text = score.score.ToString();
        textHealth.text = health.health.ToString();
    }
}