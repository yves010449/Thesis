using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
[System.Serializable]
public class LearningModuleManager : MonoBehaviour
{
    public static LearningModuleManager instance;

    [SerializeField]
    TextMeshProUGUI tmpLearningModule;

    [SerializeField]
    TextMeshProUGUI tmpAccuracy;
    [SerializeField]
    TextMeshProUGUI tmpDeath;

    public int learningModuleCollected = 0;
    [SerializeField]
    int maxlearningModule = 1;

    [SerializeField]
    Button[] buttons;

    public UnityEvent OnCollectAll, OnCorrect, OnInCorrect, OnCollect;
    // Start is called before the first frame update

    public int totalQuestions = 0;
    public int totalCorrectAnswers = 0;
    public int totalDeaths= 0;

    private void Awake() {
        instance = this;


    }

    void Start()
    {
        if (PlayerPrefs.HasKey("totalCorrectAnswers")) {
            totalCorrectAnswers = PlayerPrefs.GetInt("totalCorrectAnswers");
        }
        if (PlayerPrefs.HasKey("totalQuestions")) {
            totalQuestions = PlayerPrefs.GetInt("totalQuestions");
        }
        if (PlayerPrefs.HasKey("DeathCount")) {
            totalDeaths = PlayerPrefs.GetInt("DeathCount");
        }
        if (PlayerPrefs.HasKey("LearningModulesCollected")) {
            learningModuleCollected = PlayerPrefs.GetInt("LearningModulesCollected");
        }
        tmpLearningModule.SetText($"LEARNING MODULES FOUND: {learningModuleCollected} out of {maxlearningModule}");
        ActivateModule();
        CheckModules();
    }

    public void AddCollected() {
        learningModuleCollected++;
        PlayerPrefs.SetInt("LearningModulesCollected", learningModuleCollected);
        tmpLearningModule.SetText($"LEARNING MODULES FOUND: {learningModuleCollected} out of {maxlearningModule}");
        UpgradeManager.instance.upgradePoints++;
        UpgradeManager.instance.CheckUpgradePoints();
        CheckModules();
        OnCollect?.Invoke();
    }
    public void CheckModules() {
        if(learningModuleCollected >= maxlearningModule) {
            OnCollectAll?.Invoke();
        }
    }

    public void CorrectAnswer() {
        totalCorrectAnswers++;
        totalQuestions++;
        PlayerPrefs.SetInt("totalCorrectAnswers", totalCorrectAnswers);
        PlayerPrefs.SetInt("totalQuestions", totalQuestions);
        OnCorrect?.Invoke();
    }
    public void IncorrectAnswer() {
        totalQuestions++;
        PlayerPrefs.SetInt("totalQuestions", totalQuestions);
        OnInCorrect?.Invoke();
    }
    public void Death() {
        PlayerController.instance.CanMove = false;
        totalDeaths++;
        PlayerPrefs.SetInt("DeathCount", totalDeaths);
    }

    public void ComputeAccuracy() {
        tmpAccuracy.SetText("Your overall accuracy in answering code bot is "+((float)totalCorrectAnswers / (float)totalQuestions).ToString("0.00%"));
       tmpDeath.SetText($"You died: {totalDeaths} times");
    }

    public void ActivateModule() {
        foreach (Button button in buttons) {
            if (PlayerPrefs.GetInt(button.name)==1) {
                button.interactable = true;
            }
        }
    }
}
