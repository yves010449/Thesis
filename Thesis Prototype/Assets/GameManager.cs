using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Vector2 SpawnPos;

    public UnityEvent OnPause,OnResume;

    private void Awake() {
        instance = this;
        Application.targetFrameRate = 120;
    }

    private void Start() {
        Time.timeScale = 1;
    }

    public void PauseGame() {
        Time.timeScale = 0;
        OnPause?.Invoke();
    }
    public void ResumeGame() {
        Time.timeScale = 1;
        OnResume?.Invoke();
    }
    public void StartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void MainMenu() {
        SceneManager.LoadScene(0);
    }
    public void ExitGame() {
        Debug.Log("Exit");
        Application.Quit();
    }
}
