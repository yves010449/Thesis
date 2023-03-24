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
    public bool isPaused;

    public UnityEvent OnPause,OnResume;

    private void Awake() {
        instance = this;
        Application.targetFrameRate = 120;
    }

    private void Start() {
        Time.timeScale = 1;
    }

    public void PauseGame() {
        isPaused = true;
        Time.timeScale = 0;
        OnPause?.Invoke();
    }
    public void ResumeGame() {
        isPaused = false;
        Time.timeScale = 1;
        OnResume?.Invoke();
    }
    public void StartNewGame() {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.SetInt("CurrentLevel", 1);
    }
    public void ContinueGame() {

        SceneManager.LoadScene(PlayerPrefs.GetInt("CurrentLevel"));
    }

    public void MainMenu() {
        SceneManager.LoadScene(0);
    }
    public void ExitGame() {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void OpenSurvey(string url) {
        Application.OpenURL(url);
    }
}
