using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAdmin : MonoBehaviour
{
    [SerializeField] GameObject panelGameOver;

    // Start is called before the first frame update
    void Start()
    {
        panelGameOver.SetActive(false);
        Time.timeScale = 1;
    }

    public void StopGame()
    {
        Time.timeScale = 0;
        panelGameOver.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
