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
        state = GameState.MainMenu;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            switch(this.state)
                {
                case GameState.MainMenu:
                    SetGameState(GameState.Playing);
                    StartGame();
                    break;
                case GameState.GameOver:
                    RestartGame();
                    break;
            }                      
        }
    }

    // Method to manage game state
    public void SetGameState(GameState newState)
    {
        switch (newState)
        {
            case GameState.MainMenu:
                // Handle main menu state
                this.state = GameState.MainMenu;
                MainMenu();
                break;
            case GameState.Playing:
                // Handle playing state
                uiUpdater.ShowMainMenu(false);
                uiUpdater.ShowGameOver(false);
                this.state = GameState.Playing;
                break;
            case GameState.Paused:
                // Handle paused state
                break;
            case GameState.GameOver:
                // Handle game over state
                this.state = GameState.GameOver;
                GameOver();
                break;
        }
    }

    void GameOver()
    {
        Time.timeScale = 0;
        uiUpdater.ShowGameOver(true);
    }

    void MainMenu()
    {
        // Load main menu scene or activate main menu UI
        uiUpdater.ShowGameOver(false);
        uiUpdater.ShowMainMenu(true);
    }

    void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SetGameState(GameState.MainMenu);
    }

    void StartGame()
    {
        Time.timeScale = 1;
        SetGameState(GameState.Playing);
    }
}
