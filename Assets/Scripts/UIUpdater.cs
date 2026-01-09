using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class UIUpdater : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI textHealth;
    public TextMeshProUGUI textGameOver;
    public TextMeshProUGUI textInicio;

    void Start()
    {
        textGameOver.gameObject.SetActive(false);
        textInicio.gameObject.SetActive(true);
        GameManager.Instance.uiUpdater = this;
    }

    void Update()
    {
        textScore.text = PlayerScore.score.ToString();
        textHealth.text = PlayerHealth.health.ToString();
    }

    public void ShowGameOver(bool value)
    {
        textGameOver.gameObject.SetActive(value);
    }

    public void ShowMainMenu(bool value)
    {
       textInicio.gameObject.SetActive(value);
    }
}