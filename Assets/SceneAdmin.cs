using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneAdmin : MonoBehaviour
{
    [SerializeField] GameObject panelGameOver;
    [SerializeField] GameObject panelStart;
    [SerializeField] Toggle m_Toggle;
    [SerializeField] GameObject instanciador;
    [SerializeField] GameObject player;

    public bool separar =  true;

    // Start is called before the first frame update
    void Start()
    {
        m_Toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(m_Toggle);
        });
        player.SetActive(false);
        instanciador.SetActive(false);
        panelStart.SetActive(true);
        panelGameOver.SetActive(false);
        instanciador.SetActive(true);
       
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
    void ToggleValueChanged(Toggle change)
    {
        separar = change.isOn;
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        player.SetActive(true);
        instanciador.SetActive(true);
        panelStart.SetActive(false);
    }
}
