using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIUpdater : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textHealth;
    public TextMeshProUGUI textGameOver;

    void Start()
    {
        textGameOver.gameObject.SetActive(false);
        GameManager.Instance.uiUpdater = this;
    }

    void Update()
    {
        textScore.text = PlayerScore.score.ToString();
        textHealth.text = PlayerHealth.health.ToString();
    }

    public void ShowGameOver()
    {
        textGameOver.gameObject.SetActive(true);
    }
}