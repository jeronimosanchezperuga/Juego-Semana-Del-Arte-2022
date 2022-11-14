using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIUpdater : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textHealth;

    void Update()
    {
        textScore.text = PlayerScore.score.ToString();
        textHealth.text = PlayerHealth.health.ToString();
    }
}