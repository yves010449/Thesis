using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class LearningModuleManager : MonoBehaviour
{
    public static LearningModuleManager instance;

    [SerializeField]
    TextMeshProUGUI tmp;
    public int learningModuleCollected = 0;
    [SerializeField]
    int maxlearningModule = 1;

    public UnityEvent OnCollectAll, OnCorrect, OnInCorrect;
    // Start is called before the first frame update

    public int totalQuestions = 0;
    public int totalCorrectAnswers = 0;
    public int totalDeaths= 0;


    private void Awake() {
        instance = this;

    }

    void Start()
    {
        tmp.SetText($"LEARNING MODULES FOUND: {learningModuleCollected} out of {maxlearningModule}");

    }

    public void AddCollected() {
        learningModuleCollected++;
        tmp.SetText($"LEARNING MODULES FOUND: {learningModuleCollected} out of {maxlearningModule}");
        UpgradeManager.instance.upgradePoints++;
        UpgradeManager.instance.CheckUpgradePoints();
        CheckModules();
    }
    public void CheckModules() {
        if(learningModuleCollected >= maxlearningModule) {
            OnCollectAll?.Invoke();
        }
    }

    public void CorrectAnswer() {
        OnCorrect?.Invoke();
        totalCorrectAnswers++;
        totalQuestions++;
    }
    public void IncorrectAnswer() {
        OnInCorrect?.Invoke();
        totalQuestions++;
    }
    public void Death() {
        PlayerInput.instance.CanMove = false;
        totalDeaths++;
    }

    public int ComputeAccuracy() {
        return (totalCorrectAnswers / totalQuestions) * 100;
    }

    //IEnumerator Timer() {
    //    yield return new WaitForSeconds(1);
    //}

    //float currentTime = 0;

    //private void Update() {
    //    currentTime += Time.deltaTime;
    //    Debug.Log(currentTime);
    //}
}
