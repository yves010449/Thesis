using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Vector2 SpawnPos;

    public UnityEvent OnPause,OnResume;

    private void Awake() {
        instance = this;
        Application.targetFrameRate = 120;
    }

    public void PauseGame() {
        Time.timeScale = 0;
        OnPause?.Invoke();
    }
    public void ResumeGame() {
        Time.timeScale = 1;
        OnResume?.Invoke();
    }
}
