using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //implement game states
    public enum GameState
    {
        MainMenu,
        Playing,
        Paused,
        GameOver
    }

    //make this class a singleton
    public static GameManager Instance { get; private set; }

    public GameState state;
    public UIUpdater uiUpdater;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        uiUpdater = FindObjectOfType<UIUpdater>();
        state = GameState.Playing;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.state == GameState.GameOver && Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
            this.state = GameState.Playing;
        }
    }

    // Method to manage game state
    public void SetGameState(GameState newState)
    {
        state = newState;
        switch (newState)
        {
            case GameState.MainMenu:
                // Handle main menu state
                break;
            case GameState.Playing:
                // Handle playing state
                break;
            case GameState.Paused:
                // Handle paused state
                break;
            case GameState.GameOver:
                // Handle game over state
                GameOver();
                break;
        }
    }

    void GameOver()
    {
        Time.timeScale = 0;
        uiUpdater.ShowGameOver();
    }
}
